using NUnit.Framework;
using Bees;
using Bees.Interfaces;
using Bees.Models;

namespace BeesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Drone_Create_Test()
        {
            // Arrange
            var drone = new Drone(1);

            // Act


            // Assert
            Assert.IsNotNull(drone);
            Assert.AreEqual(drone.Status(), 100M);
            Assert.AreEqual(drone.Threshold(), 50M);
            Assert.AreEqual(drone.IsAlive(), true);
        }

        [Test]
        public void Worker_Create_Test()
        {
            // Arrange
            var worker = new Worker(2);

            // Act


            // Assert
            Assert.IsNotNull(worker);
            Assert.AreEqual(worker.Status(), 100M);
            Assert.AreEqual(worker.Threshold(), 70M);
            Assert.AreEqual(worker.IsAlive(), true);
        }

        [Test]
        public void Queen_Create_Test()
        {
            // Arrange
            var queen = new Queen(3);

            // Act


            // Assert
            Assert.IsNotNull(queen);
            Assert.AreEqual(queen.Status(), 100M);
            Assert.AreEqual(queen.Threshold(), 20M);
            Assert.AreEqual(queen.IsAlive(), true);
        }

        [Test]
        public void Drone_Damage_Test()
        {
            // Arrange
            var drone = new Drone(4);

            // Act
            drone.Damage(20);
            drone.Damage(20);
            drone.Damage(20);
            drone.Damage(20);

            // Assert
            Assert.IsNotNull(drone);
            Assert.AreEqual(drone.Status(), 40.96M);
            Assert.AreEqual(drone.Threshold(), 50M);
            Assert.AreEqual(drone.IsAlive(), false);
        }
    }
}
//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace BeesTests
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//        }
//    }
//}
