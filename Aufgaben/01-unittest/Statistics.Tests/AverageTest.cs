using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            //Arrange
            List<int> numbers = new List<int> { 1, 3 };
            double expected = 2;
            Average average = new Average();

            //Act
            double actual = average.Mean(numbers);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            //Arrange
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            double expected = 3;
            Average average = new Average();

            //Act
            double actual = average.Mean(numbers);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfNoNumbers()
        {
            //Arrange
            List<int> numbers = new List<int> { };
            Average average = new Average();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => average.Mean(numbers));
        }

        //Aufgabe 5

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            //Arrange
            List<double> numbers = new List<double> { 1, 2, 6, 7, 8 };
            double expected = 6;
            Average average = new Average();

            //Act
            double actual = average.Median(numbers);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            //Arrange
            List<double> numbers = new List<double> { 1, 2, 5, 6, 7, 8 };
            double expected = 5.5;
            Average average = new Average();

            //Act
            double actual = average.Median(numbers);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForNoElements_Exception()
        {
            //Arrange
            List<double> numbers = new List<double> { };
            Average average = new Average();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => average.Median(numbers));
        }
    }
}
