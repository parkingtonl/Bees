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

        [Test]
        public void Worker_Damage_Test()
        {
            // Arrange
            var worker = new Worker(5);

            // Act
            worker.Damage(20);
            worker.Damage(20);
            worker.Damage(20);
            worker.Damage(20);

            // Assert
            Assert.IsNotNull(worker);
            Assert.AreEqual(worker.Status(), 64M);
            Assert.AreEqual(worker.Threshold(), 70M);
            Assert.AreEqual(worker.IsAlive(), false);
        }

        [Test]
        public void Queen_Damage_Test()
        {
            // Arrange
            var queen = new Queen(6);

            // Act
            queen.Damage(20);
            queen.Damage(20);
            queen.Damage(20);
            queen.Damage(20);

            // Assert
            Assert.IsNotNull(queen);
            Assert.AreEqual(queen.Status(), 40.96M);
            Assert.AreEqual(queen.Threshold(), 20M);
            Assert.AreEqual(queen.IsAlive(), true);
        }

        [Test]
        public void Damage_None_Test()
        {
            // Arrange
            var worker = new Worker(5);
            var damage = 0;

            // Act
            worker.Damage(damage);

            // Assert
            Assert.IsNotNull(worker);
            Assert.AreEqual(worker.Status(), 100M);
            Assert.AreEqual(worker.Threshold(), 70M);
            Assert.AreEqual(worker.IsAlive(), true);
        }

        [Test]
        public void Damage_Full_Test()
        {
            // Arrange
            var worker = new Worker(5);
            var damage = 100;

            // Act
            worker.Damage(damage);

            // Assert
            Assert.IsNotNull(worker);
            Assert.AreEqual(worker.Status(), 0M);
            Assert.AreEqual(worker.Threshold(), 70M);
            Assert.AreEqual(worker.IsAlive(), false);
        }

        [Test]
        public void Damage_Below_Range_Test()
        {
            // Arrange
            var worker = new Worker(5);
            var damage = -5;

            // Act
            worker.Damage(damage);

            // Assert
            Assert.IsNotNull(worker);
            Assert.AreEqual(worker.Status(), 100M);
            Assert.AreEqual(worker.Threshold(), 70M);
            Assert.AreEqual(worker.IsAlive(), true);
        }

        [Test]
        public void Damage_Above_Range_Test()
        {
            // Arrange
            var worker = new Worker(6);
            var damage = 150;

            // Act
            worker.Damage(damage);

            // Assert
            Assert.IsNotNull(worker);
            Assert.AreEqual(worker.Status(), 0M);
            Assert.AreEqual(worker.Threshold(), 70M);
            Assert.AreEqual(worker.IsAlive(), false);
        }

        [Test]
        public void Status_Test()
        {
            // Arrange
            var drone = new Drone(7);
            var worker = new Worker(8);
            var queen = new Queen(9);

            // Act

            // Assert
            Assert.AreEqual(drone.Status(), 100M);
            Assert.AreEqual(worker.Status(), 100M);
            Assert.AreEqual(queen.Status(), 100M);
        }

        [Test]
        public void IsAlive_Test()
        {
            // Arrange
            var drone = new Drone(10);
            var worker = new Worker(11);
            var queen = new Queen(12);

            // Act

            // Assert
            Assert.AreEqual(drone.IsAlive(), true);
            Assert.AreEqual(worker.IsAlive(), true);
            Assert.AreEqual(queen.IsAlive(), true);
        }

        [Test]
        public void Threshold_Test()
        {
            // Arrange
            var drone = new Drone(13);
            var worker = new Worker(14);
            var queen = new Queen(15);

            // Act

            // Assert
            Assert.AreEqual(drone.Threshold(), 50M);
            Assert.AreEqual(worker.Threshold(), 70M);
            Assert.AreEqual(queen.Threshold(), 20M);
        }

        [Test]
        public void Id_Test()
        {
            // Arrange
            var drone = new Drone(16);
            var worker = new Worker(17);
            var queen = new Queen(18);

            // Act

            // Assert
            Assert.AreEqual(drone.Id(), 16);
            Assert.AreEqual(worker.Id(), 17);
            Assert.AreEqual(queen.Id(), 18);
        }
    }
}
