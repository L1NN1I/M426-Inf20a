using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyThreeTimesSix()
        {
            //Arrange
            int a = 3;
            int b = 6;
            int expected = 18;
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Multiply(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideTenWithTwo()
        {
            //Arrange
            int a = 10;
            int b = 2;
            int expected = 5;
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Divide(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        //Ich mache diesen Test nicht wie in Aufgabe 3.3 beschrieben, da ArgumentEx eine viel zu allgemeine Exeption ausgibt, diese sollte jedoch so genau wie möglich sein.
        [Fact]
        public void TestDevideTenWithZero()
        {
            //Arrange
            int a = 10;
            int b = 0;
            Calculator calculator = new Calculator();

            //Assert
            Assert.Throws<DivideByZeroException>(() => /*Act Teil*/ calculator.Divide(a, b));
        }
    }
}
