using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<double> maxMinNumbers = new List<double> { 1, 31, 51, 2, 41, 284, 172 };
            SuperList superList = new SuperList(maxMinNumbers);

            superList.GetMinMax1(out double min, out double max);
            Console.WriteLine($"Minimum: {min}, Maximum: {max}");

            SuperList.GetMinMax2R result = superList.GetMinMax2();
            Console.WriteLine($"Minimum: {result.min}, Maximum: {result.max}");

            Tuple<double, double> result2 = superList.GetMinMax3(ref max, ref min);
            Console.WriteLine($"GetMinMax3: Min = {result2.Item1}, Max = {result2.Item2}");

            (double, double) result3 = superList.GetMinMax4(double.MaxValue, double.MinValue);
            Console.WriteLine($"GetMinMax4: Min = {result3.Item1}, Max = {result3.Item2}");
        }
    }
}
