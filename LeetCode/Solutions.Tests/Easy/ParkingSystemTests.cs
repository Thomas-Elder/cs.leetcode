using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class ParkingSystemTests
    {
        ParkingSystem ParkingSystem;

        [TestMethod]
        public void AddCar_WhenCalledOnParkingSystemWithLCExample_ReturnsCorrect()
        {
            // Big 1
            // Medium 2
            // Small 3

            // Arrange
            int big = 1;
            int medium = 1;
            int small = 0;

            // Act
            ParkingSystem = new ParkingSystem(big, medium, small);

            // Assert
            Assert.AreEqual(true, ParkingSystem.AddCar(1));
            Assert.AreEqual(true, ParkingSystem.AddCar(2));
            Assert.AreEqual(false, ParkingSystem.AddCar(3));
            Assert.AreEqual(false, ParkingSystem.AddCar(1));
        }
    }
}
