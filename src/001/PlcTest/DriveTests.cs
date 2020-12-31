using NUnit.Framework;
using PlcConnector;
using Tc.Prober.Runners;

namespace PlcTest
{
    public class DriveTests
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            // This starts the operations on Plc connector.
            Entry.Plc.Connector.BuildAndStart();
        }

        [Test]
        [TestCase(1d, 1d, 100d)]            // Test cases
        [TestCase(2.15d, 0.5d, 100.0d)]
        [TestCase(3.15d, 3.5d, 100.0d)]
        [Timeout(5000)]                     // Timeout for the test if the test does not complete within given time it will fail.
        public void MoveAbsoluteTest(double position, double speed, double accdcc)
        {
            //-- Arrange
            var sut = Entry.Plc.MAIN_TESTS._driveTest; // This just shortens the path to object under test
            // Arrange expected parameters
            var expectedTargetPosition = position;    
            var expectedTargetSpeed = speed;
            var expectedTargetAccDcc = accdcc;

            //-- Act

            // 'Run' is an extension method that will run the action until returns 'true'
                
            sut.Run(a => a.MoveAbsoluteTest(expectedTargetPosition, 
                expectedTargetSpeed, expectedTargetAccDcc));

            // Alternatively
#if ALTERNATIVE           
            sut.Run(a =>
            {
                bool done = a.MoveAbsoluteTest(expectedTargetPosition,
                expectedTargetSpeed, expectedTargetAccDcc);
                return done;
            });
#endif

            //-- Assert

            Assert.AreEqual(expectedTargetPosition, 
                sut._drive._targetPosition.Synchron);
            Assert.AreEqual(expectedTargetSpeed, 
                sut._drive._targetSpeed.Synchron);
            Assert.AreEqual(expectedTargetAccDcc, 
                sut._drive._targetAccDcc.Synchron);
        }
    }
}