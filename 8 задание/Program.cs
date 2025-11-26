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
                int[] results = { 45, 78, 92, 67, 95, 81, 68, 74, 89, 63, 79, 94, 83, 58, 96 };
                Console.WriteLine("=== СТАТИСТИКА РЕЗУЛЬТАТОВ ===");

                var sorted = results.OrderBy(r => r).ToArray();
                double median = sorted.Length % 2 == 0 ?
                    (sorted[sorted.Length / 2 - 1] + sorted[sorted.Length / 2]) / 2.0 :
                    sorted[sorted.Length / 2];
                Console.WriteLine($"Медиана: {median}");

                double avg = results.Average();
                double std = Math.Sqrt(results.Average(r => Math.Pow(r - avg, 2)));
                Console.WriteLine($"Стандартное отклонение: {std:F1}");
                // группировка по балам через вложенный цикл
                int topCount = (int)Math.Ceiling(results.Length * 0.1);
                int[] topResults = new int[topCount];
                for (int i = 0; i < results.Length - 1; i++)
                {
                    for (int j = 0; j < results.Length - 1 - i; j++)
                    {
                        if (results[j] < results[j + 1])
                        {
                            int temp = results[j];
                            results[j] = results[j + 1];
                            results[j + 1] = temp;
                        }
                    }
                }
                for (int i = 0; i < topCount; i++)
                {
                    topResults[i] = results[i];
                }

                Console.WriteLine($"Топ {topCount} результатов: {string.Join(", ", topResults)}");


                Console.WriteLine("Группировка по баллам:");
                    var groups = new[] { "0-59", "60-69", "70-79", "80-89", "90-100" };
                    foreach (var group in groups)
                    {
                        int min = int.Parse(group.Split('-')[0]);
                        int max = int.Parse(group.Split('-')[1]);
                        int count = results.Count(r => r >= min && r <= max);
                        Console.WriteLine($"{group}: {count} чел.");
                       
                    }
                   
            }
        }
    }
}








  

