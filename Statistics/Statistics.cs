using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public double average { get; set; }
        public double max { get; set; }
        public double min { get; set; }
    }

    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            if (numbers.Count == 0)
            {
                return new Stats
                {
                    average = double.NaN,
                    max = double.NaN,
                    min = double.NaN
                };
            }

            double sum = 0;
            double max = numbers[0];
            double min = numbers[0];

            foreach (float num in numbers)
            {
                sum += num;
                if (num > max) max = num;
                if (num < min) min = num;
            }

            double average = sum / numbers.Count;

            return new Stats
            {
                average = average,
                max = max,
                min = min
            };
        }
    }
}
