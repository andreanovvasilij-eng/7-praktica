using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     
            {
                double[] results = { 85, 92, 78, 65, 88, 95, 73, 81, 90, 87,
                          76, 89, 94, 70, 82, 84, 91, 79, 86, 93 };

                Console.WriteLine("Результаты: " + string.Join(" ", results));
                var calc = new Program();  
                double median = calc.GetMedian(results);
                Console.WriteLine($"Медиана: {median:F2}");
                double stdDev = calc.GetStdDev(results);
                Console.WriteLine($"Стандартное отклонение: {stdDev:F2}");
                double[] top10 = calc.GetTop10Percent(results);
                Console.WriteLine("Топ‑10%: " + string.Join(" ", top10));
            }

            double GetMedian(double[] arr)
            {
                double[] sorted = (double[])arr.Clone();
                Array.Sort(sorted);
                int n = sorted.Length;
                if (n % 2 == 0)
                    return (sorted[n / 2 - 1] + sorted[n / 2]) / 2;
                else
                    return sorted[n / 2];
            }

            double GetStdDev(double[] arr)
            {
                double mean = arr.Average();
                double sumSquaredDifferences = arr.Sum(x => Math.Pow(x - mean, 2));
                double variance = sumSquaredDifferences / arr.Length;
                return Math.Sqrt(variance);
            }

            double[] GetTop10Percent(double[] arr)
            {
                int count = (int)Math.Ceiling(arr.Length * 0.1);
                double[] sorted = (double[])arr.Clone();
                Array.Sort(sorted);
                Array.Reverse(sorted);
                return sorted.Take(count).ToArray();
            }
        }


    }

}


