# Tc.Prober

## Brief description

### History

The concept of Tc.Prober was developed and used within MTS company as a part of an effort to provide high quality, testable components for industrial applications based on TwinCAT3 platform. Tc.Prober makes part of wider initiative that eventually became Inxton project.

### What Tc.Prober is

Tc.Prober is a library that in conjunction with Inxton.Vortex.Compiler (IVC) allows for running unit tests of the TwiCAT3 PLC code using well known unit testing frameworks in .net ecosystem.

Tc.Prober takes advantage of some features offered by TwinCAT3 platform, that makes it possible to invoke PLC methods marked with attribute TcRpcEneable over ADS from a .net based code.

In order to make the process faster to implement, we relay on IVC compiler that trans-piles the PLC program declarations and methods into so called twin-objects, these are C# classes mirroring the structure of the PLC program. They provide multiple layered access to the PLC programs’ data and remotely invokable methods.

Tc.Prober implements *runners* that provide control over the execution of the code under test. There is also an implementation of the runner that provides recording mechanism. This is especially useful when we have availability of a hardware for testing for limited time. In this way we can record the behavior of the hardware when available and re-run the tests with recorded image later.

So to answer a question of what the Tc.Prober is in short: library that make brings your unit testing iterations to .net testing frameworks of your choice be it xUnit, nUnit, MSUnit. 

### What Tc.Prober is not

In contrast to Tc.Unit Tc.Prober does not implement assertions nor executing mechanism directly in the PLC, it relays intead on testing frameworks .net environment.

### How does it work

Following is just a conceptual overview that does not aim to provide fully operational and usable example. In this GitHub repository you can find explanatory functional examples. For simplicity we provide the minimalistic way of writing the testing code that does not necessarily represents the best practice. 

Let's have a function block with following definition and method implementation:

~~~ PASCAL
FUNCTION_BLOCK fbDrive
VAR
    _position : LREAL;
    _targetPosition : LREAL;
END_VAR
//----------------------------------
METHOD MoveAbsolute : BOOL
VAR_INPUT
    Position : LREAL;
END_VAR
//----------------------------------
_targetPosition := Position;
MoveAbsolute := _position = _targetPosition;
//----------------------------------
~~~

This would be our production code that we shall unit test. For simplicity we simulate the position of the drive in _position variable when _position and _targetPosition equal the method returns true; that in this case stands for operation done.

Let's have testing function block that has an instance of ```fbDrive``` block and implements testing method ```MoveAbsoluteTest()``` that invokes fbDrive's MoveAbsolute() method.

~~~ PASCAL
FUNCTION_BLOCK INTERNAL fbDriveTests
VAR
    _drive : fbDrive;
END_VAR
//----------------------------------
{attribute 'TcRpcEnable'}
METHOD INTERNAL MoveAbsoluteTest  : BOOL
VAR_INPUT
    Position : LREAL;
END_VAR
//----------------------------------

MoveAbsoluteTest := fbDrive.MoveAbsolute(Position := Position);

//----------------------------------
~~~

This would be the part of code that executes the test for our ```fbDrive``` block. The body of the method only calls MoveAbsolute method.

Here are two things to notice:

* method ```MoveAbsoluteTest``` has ```TcRpcEnable``` attribute. This will tell IVC that we want this method to be invocable from a pc application (whatever that application is, in this case unit testing).
* the ```fbDriveTest``` and ```MoveAbsoluteTest```  are marked with access modifier ```INTERNAL``` which makes them visible only within the project where it is declared. In this way we render the testing blocks invisible to any external consumer of our library.

Now. In order to instantiate our testing block let's have ```MAIN_TESTS``` block that will hold the instance of testing function block. The program ```MAIN_TESTS``` must be assigned to a Plc Taks for TwinCAT can produce ADS symbols.

~~~ PASCAL
PROGRAM INTERNAL MAIN_TESTS
VAR
    _driveTest : fbDriveTests;
END_VAR
//----------------------------------
~~~

At this point we have our PLC code ready. We will need now to run IVC to make the plc program available to our unit testing project. There are two ways we can run the IVC running IVC CLI or install extension.

Few remarks here. If you are trying to make the project from scratch then you should go here to understand the basics of Inxton.Vortex.Framework (IVF).

Once we have suceessuly run the IVC we will get .net twin-project of our plc project that will allow us to access the plc program from .net environment.

~~~ CSharp
using Tc.Prober.Runners;
public class DriveTests
{
    [Test]
    [Timeout(5000)] // Timeout for the test if the test does not complete within given time it will fail.
    public void MoveAbsoluteTest()
    {
        //-- Arrange
        var sut = connector.MAIN._driveTest; // This just shortens the path to object under test
        var expectedTargetPosition = 1000d;  // This is expected target position

        //-- Act

        // 'Run' is an extension method that will run the action until returns 'true'
        sut.Run(a => a.MoveAbsoluteTest(expectedTargetPosition));

        // Alternatively
        sut.Run(a => {                             
              bool done = a.MoveAbsoluteTest(expectedTargetPosition)
              return done;
         })
         
        //-- Assert
        Assert.AreEqual(expectedTargetPosition, sut._drive._targetPosition);
    }
}
~~~
