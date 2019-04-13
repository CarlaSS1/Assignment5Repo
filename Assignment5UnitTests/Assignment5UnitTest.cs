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
using Problem5.Plugs;
using System.Linq;

namespace Assignment5UnitTests
{
    /// <summary>
    /// Represents the assignment 5 unit tests.
    /// </summary>
    [TestClass]
    public class Assignment5UnitTest
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Car_ValidCarWith5Wheels_NumberOfWheelsAreSetTo5()
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
            ComputerBuilder computerBuilder = new ComputerBuilder();

            // Act
            Case myCase = new Case(15, 15, 15, 2, 2);
            computerBuilder.AddCase(myCase);
            var builder = computerBuilder.Build();

            // Assert
            Assert.AreEqual(builder.PCCase, myCase);
        }

        [TestMethod]
        public void Handle_WhenFlaggedMailIsSent_AddFlaggedMailIntoTheList()
        {
            // Arrange
            //Worker worker = new Worker();

            //MailDispatcher mailReactor = new MailDispatcher();

            //Sender sender = new Sender("Chungus", "123 Example Street");

            //Receiver receiver = new Receiver("Carla", "149 Folkstone ave");

            //Mail mail1 = new Mail(0.1, 12.0, true, sender, receiver);

            //// Act
            //mailReactor.Handle(mail1);

            //// Assert
            //Assert.AreEqual(worker.FlaggedMails.Count(), 1);



            var x = typeof(MailDispatcher).Assembly.DefinedTypes.Where(c => c == typeof(MailHandler));
        }

        [TestMethod]
        public void Test_For_Problem_4()
        {
            // Arrange

            // Act

            // Assert
        }

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
        public void AddCpu_WhenCpuSpeedIsZero_Throws()
        {
            // Arrange
            MotherboardBuilder motherboardBuilder = new MotherboardBuilder();

            // Act
            Cpu processor = new Cpu("My Processor", 0.0, CpuManufacturer.AMD, CpuSocketTypes.BGA, 23, 5);

            motherboardBuilder.AddCpu(processor);

            motherboardBuilder.Build();

            // Assert - Expected Exception.
        }

        // Add additional test cases here
        // Also, please be sure to note down what you are
        // trying to test for.
    }
}
