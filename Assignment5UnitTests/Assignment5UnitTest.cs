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
using System;
using Problem5.Plugs;
using System.Collections.Generic;

namespace Assignment5UnitTests
{
    /// <summary>
    /// Represents the assignment 5 unit tests.
    /// </summary>
    [TestClass]
    public class Assignment5UnitTest
    {
        /// <summary>
        /// Tests that the Number of wheels on the car are Four .
        /// </summary>
        [TestMethod]
        public void NumberOfWheels_ValidCarWithFourWheels_NumberOfWheelsAreSetToFour()
        {
            // Arrange
            Car car = new Car(Guid.NewGuid(), 5.00, "Red Car", "Donut", "Mattel", 1999, 16, 10, 0.50, true, model: "Ford", make: "Some make", wheels: 4);

            // Act - Values have been set in arrange phase

            // Assert
            Assert.AreEqual(car.NumberOfWheels, 4);
        }

        /// <summary>
        /// Tests a valid case object by adding a case to a computer.
        /// </summary>
        [TestMethod]
        public void AddCase_ValidCase_ReturnsComputerWithACase()
        {
            // Arrange
            ComputerBuilder computerBuilder = new ComputerBuilder();

            // Act
            Case myCase = new Case(15, 15, 15, 2, 2);
            computerBuilder.AddCase(myCase);
            var builder = computerBuilder.Build();

            // Assert
            Assert.AreEqual(builder.PCCase, myCase);
        }

        /// <summary>
        /// Test an mail list that is set to null to the Mail Dispatcher object.
        /// 
        /// It should throw a new ArgumentNullException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MailDispatcher_WhenMailListIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            MailDispatcher dispatcher;

            // Act
            List<Mail> mails = null;

            dispatcher = new MailDispatcher(null);
            // Assert - Expected Exception
            
        }

        /// <summary>
        /// Tests that the type a outlet has a prong count of two.
        /// </summary>
        [TestMethod]
        public void ProngCount_ValidTypeAOutlet_ValueProngCountForTypeAOutlet()
        {
            // Arrange
            PlugAdapter plugAdapter = new PlugAdapter();

            TypeAOutlet outlet = new TypeAOutlet();

            // Act
            plugAdapter.Adapt(outlet);

            // Assert
            Assert.AreEqual(outlet.ProngCount, 2);
        }

        /// <summary>
        /// Tests a cpu speed that has a speed of 0 that is being passed into the motherboard
        /// builder
        /// 
        /// It should throw a new ArgumentOutOfRangeException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCpu_WhenCpuSpeedIsZero_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            MotherboardBuilder motherboardBuilder = new MotherboardBuilder();

            // Act
            Cpu processor = new Cpu("My Processor", 0.0, CpuManufacturer.AMD, CpuSocketTypes.BGA, 23, 5);

            motherboardBuilder.AddCpu(processor);

            motherboardBuilder.Build();

            // Assert - Expected Exception.
        }
    }
}
