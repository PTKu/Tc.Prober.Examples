using NUnit.Framework;
using PlcConnector;
using Tc.Prober.Runners;

namespace PlcTest
{
    public class DriveTests
    {
        [SetUp]
        public void Setup()
        {
            Entry.Plc.Connector.BuildAndStart();
        }

        [Test]
        [Timeout(5000)]
        public void MoveAbsoluteTest()
        {
            //-- Arrange
            var sut = Entry.Plc.MAIN._driveTest;
            var expectedTargetPosition = 1000d;
            var expectedTargetSpeed = 1000d;
            var expectedTargetAccDcc = 1000d;

            //-- Act
            sut.Run(a => a.MoveAbsoluteTest(expectedTargetPosition, 
                expectedTargetSpeed, expectedTargetAccDcc));

            //-- Assert
            Assert.AreEqual(expectedTargetPosition, 
                sut._drive._targetPosition);
            Assert.AreEqual(expectedTargetSpeed, 
                sut._drive._targetSpeed);
            Assert.AreEqual(expectedTargetAccDcc, 
                sut._drive._targetAccDcc);
        }
    }
}