using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        private List<double> numbers;
        public SuperList(List<double> numbers)
        {
            this.numbers = numbers;
        }
        public class MinMax
        {
            public double Min { get; set; }
            public double Max { get; set; }
            public MinMax(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        public void GetMinMax1(out double min, out double max)
        {
            min = numbers[0];
            max = numbers[0];
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
        }

        public struct GetMinMax2R
        {
            public double min { get; set; }
            public double max { get; set; }
        }

        public GetMinMax2R GetMinMax2()
        {
            var result = new GetMinMax2R();
            result.min = numbers[0];
            result.max = numbers[0];
            foreach (var number in numbers)
            {
                if (number < result.min)
                {
                    result.min = number;
                }
                if (number > result.max)
                {
                    result.max = number;
                }
            }
            return result;
        }
        public Tuple<double, double> GetMinMax3(ref double min, ref double max)
        {
            min = numbers[0];
            max = numbers[0];
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
            return new Tuple<double, double>(min, max);
        }

        public (double,double) GetMinMax4(double min, double max)
        {
            min = numbers[0];
            max = numbers[0];
            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
            return (min, max);
        }
    }
}