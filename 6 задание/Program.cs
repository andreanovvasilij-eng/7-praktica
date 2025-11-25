using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperatures = {
            -5, -3, 0, 2, 5, 8, 10,
            12, 14, 16, 18, 20, 22, 24,
            26, 28, 30, 29, 27, 25, 23,
            20, 18, 15, 12, 10, 8, 6, 4
        };
            int daysCount = temperatures.Length;
            int weeksCount = 4;
            int daysPerWeek = 7;
            double sum = 0;
            for (int i = 0; i < daysCount; i++)
            {
                sum += temperatures[i];
            }
            double avgTemp = sum / daysCount;
            Console.WriteLine($"Средняя температура за месяц: {avgTemp:F1} °C");
            double minWeekSum = double.MaxValue;
            double maxWeekSum = double.MinValue;
            int coldestWeek = 1;
            int warmestWeek = 1;
            for (int week = 0; week < weeksCount; week++)
            {
                double weekSum = 0;
                for (int day = 0; day < daysPerWeek; day++)
                {
                    weekSum += temperatures[week * daysPerWeek + day];
                }
                double weekAvg = weekSum / daysPerWeek;

                if (weekAvg < minWeekSum)
                {
                    minWeekSum = weekAvg;
                    coldestWeek = week + 1;
                }
                if (weekAvg > maxWeekSum)
                {
                    maxWeekSum = weekAvg;
                    warmestWeek = week + 1;
                }
            }
            Console.WriteLine($"Самая холодная неделя: {coldestWeek}");
            Console.WriteLine($"Самая тёплая неделя: {warmestWeek}");
            Console.WriteLine("Дни с температурой выше средней:");
            for (int i = 0; i < daysCount; i++)
            {
                if (temperatures[i] > avgTemp)
                {
                    Console.Write($"{i + 1} ");
                }
            }
            Console.WriteLine();
            int frost = 0;
            int cold = 0;
            int warm = 0;
            int hot = 0;

            for (int i = 0; i < daysCount; i++)
            {
                double temp = temperatures[i];
                if (temp < -10)
                    frost++;
                else if (temp <= 0)
                    cold++;
                else if (temp <= 25)
                    warm++;
                else
                    hot++;
            }
            Console.WriteLine("Распределение по диапазонам:");
            Console.WriteLine($"Мороз (< −10 °C): {frost} дней");
            Console.WriteLine($"Холодно (−10…0 °C): {cold} дней");
            Console.WriteLine($"Тепло (0…25 °C): {warm} дней");
            Console.WriteLine($"Жарко (> 25 °C): {hot} дней");
        }
    }



}





