/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment5;
using Problem2;
using Problem3;
using Problem4;
using Problem5;
using System;

namespace Assignment5UnitTests
{
    /// <summary>
    /// Represents the assignment 5 unit tests.
    /// </summary>
    [TestClass]
    public class Assignment5UnitTest
    {
        [TestMethod]
        public void Test_For_Problem_1()
        {
            // Arrange
            Car car = new Car(Guid.NewGuid(), 5.00, "Red mustang", "Donut", "Mattel", 1999, 16, 10, 0.50, true);

            // Act
            car.Model = "Some model";
            car.NumberOfWheels = 5;
            car.RaceToyCar();

            // Assert
            Assert.AreEqual(car.NumberOfWheels, 5);
        }

        [TestMethod]
        public void Test_For_Problem_2()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void Test_For_Problem_3()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void Test_For_Problem_4()
        {
            // Arrange

            // Act

            // Assert
        }

        [TestMethod]
        public void Test_For_Problem_5()
        {
            // Arrange

            // Act

            // Assert
        }

        // Add additional test cases here
        // Also, please be sure to note down what you are
        // trying to test for.
    }
}
