using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void Test_Addition()
        {
            //Arrange
            int expected = 30;
            int firstNumber = 20;
            int secondNumber = 10;

            //Act
            int actual = CalculatorLibrary.Calculation.Addition(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            //Arrange
            int expected = 10;
            int firstNumber = 20;
            int secondNumber = 10;

            //Act
            int actual = CalculatorLibrary.Calculation.Subtraction(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            //Arrange
            int expected = 200;
            int firstNumber = 20;
            int secondNumber = 10;

            //Act
            int actual = CalculatorLibrary.Calculation.Multiplication(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Division()
        {
            //Arrange
            int expected = 2;
            int firstNumber = 20;
            int secondNumber = 10;

            //Act
            int actual = CalculatorLibrary.Calculation.Division(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
