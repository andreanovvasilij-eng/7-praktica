using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_практика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                  ЗАДАЧА 1
            Console.WriteLine("Задача 1: Базовые операции");
            int[] numbers = new int[10];
            Random randoms = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randoms.Next(1, 101);
            }
            Console.WriteLine("Массив");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма всех элементов: {sum}");
            double srZnach = (double)sum / numbers.Length;
            Console.WriteLine($"Среднее арифметическое: {srZnach}");
            int Count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Count++;
                }
            }
            Console.WriteLine($"Количество четных чисел: {Count}");
            Console.WriteLine();






            //                 ЗАДАЧА 2
            Console.WriteLine("Задача 2: Поиск элементов");
            string[] languages = { "Русский", "Татарский", "Чувашский", "Мордовский", "Английский" };
            Console.WriteLine("Наш массив:");
            for (int i = 0; i < languages.Length; i++)
            {
                Console.Write(languages[i] + ", ");
            }
            Console.WriteLine();
            string longest = languages[0];
            for (int i = 1; i < languages.Length; i++)
            {
                if (languages[i].Length > longest.Length)
                {
                    longest = languages[i];
                }
            }
            Console.WriteLine("Самая длинная строка: " + longest);
            Console.WriteLine();

            Console.Write("Введите ключевое слово или часть слова, которого ищете: ");
            Console.WriteLine();
            string search = Console.ReadLine();
            bool notSearch = false;
            Console.Write("Найденные строки: ");
            for (int i = 0; i < languages.Length; i++)
            {
                if (languages[i].Contains(search))
                {
                    Console.WriteLine("Найденные строки:");
                    Console.WriteLine(languages[i]);
                    notSearch = true;
                }
            }
            if (!notSearch)
            {
                Console.Write("Таких строк нет");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите строку, индекс которой вам нужен!");
            string index = Console.ReadLine();
            int position = -1;
            for (int i = 0; i < languages.Length; i++)
            {
                if (languages[i] == index)
                {
                    position = i;
                    break;
                }
            }

            if (position != -1)
            {
                Console.WriteLine($"Найдено на позиции: {position}");
            }
            else
            {
                Console.WriteLine("Не найдено");
            }




            //                     ЗАДАЧА 3
            Console.WriteLine("Задача 3: Обработка числовых данных");
            double[] numberS = new double[15];
            Random randomS = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numberS[i] = randomS.NextDouble();
            }            
            Console.WriteLine("Массив чисел:");
            for (int i = 0; i < numberS.Length; i++)
            {
                Console.Write(numberS[i] + " ");
            }
            Console.WriteLine("\n");
            double min = numberS[0];
            double max = numberS[0];
            for (int i = 1; i < numberS.Length; i++)
            {
                if (numberS[i] < min)
                    min = numberS[i];

                if (numberS[i] > max)
                    max = numberS[i];
            }

            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Максимальный элемент: " + max);
            double difference = max - min;
            Console.WriteLine("Разность максимально и минимального значения: " + difference);
            double summa = 0;
            for (int i = 0; i < numberS.Length; i++)
            {
                summa += numberS[i];
            }
            double BolSrCnach = summa / numberS.Length;
            Console.WriteLine("Среднее арифметическое: " + BolSrCnach);
            Console.WriteLine("Числа больше среднего: ");
            for (int i = 0; i < numberS.Length; i++)
            {
                if (numberS[i] > BolSrCnach)
                {
                    Console.Write(numberS[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();




            //               ЗАДАЧА 4
            int[] array = {1, 0, 3, 0, 5, 0, 7, 0, 9};          
            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }           
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                  count++;
            }
            Console.WriteLine();
            Console.WriteLine("Ненулевых элементов: " + count);         
            int[] result = new int[count];
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != 0)
                    {
                        result[j] = array[i];
                        j++;
                    }
                }
                Console.Write("Массив без нулей: ");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i] + " ");
                }
            
        }
    }
}

