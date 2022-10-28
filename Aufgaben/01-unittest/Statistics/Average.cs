using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentNullException();
            }

            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }
        public double Median(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentNullException();
            }

            double[] a = numbers.ToArray();

            return ArrayStatistics.MedianInplace(a);
        }
    }
}
