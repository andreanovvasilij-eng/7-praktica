using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_задание
{
    
        class Program
        {
            static void Main(string[] args)
        {
  
                {
                    string[] catalog = {
                "Ноутбук;50000;Электроника",
                "Мышь;1000;Аксессуары",
                "Клавиатура;3000;Аксессуары",
                "Смартфон;35000;Электроника",
                "Стол;12000;Мебель",
                "Стул;5000;Мебель",
                "Планшет;25000;Электроника",
                "Лампа;2000;Освещение"
            };

                    Console.WriteLine("=== Каталог товаров ===");
                    Console.WriteLine("Товары в категории «Аксессуары»:");
                    for (int i = 0; i < catalog.Length; i++)
                    {
                        string[] parts = new string[3];
                        int start = 0, part = 0;
                        for (int j = 0; j < catalog[i].Length; j++)
                        {
                            if (catalog[i][j] == ';')
                            {
                                parts[part] = catalog[i].Substring(start, j - start);
                                start = j + 1;
                                part++;
                            }
                        }
                        parts[2] = catalog[i].Substring(start);
                        if (parts[2] == "Аксессуары")
                        {
                            Console.WriteLine($"{parts[0]} — {parts[1]} руб. ({parts[2]})");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Товары с ценой от 1000 до 10000 руб.:");
                    for (int i = 0; i < catalog.Length; i++)
                    {
                        string[] parts = new string[3];
                        int start = 0, part = 0;
                        for (int j = 0; j < catalog[i].Length; j++)
                        {
                            if (catalog[i][j] == ';')
                            {
                                parts[part] = catalog[i].Substring(start, j - start);
                                start = j + 1;
                                part++;
                            }
                        }
                        parts[2] = catalog[i].Substring(start);
                        double price = Convert.ToDouble(parts[1]);
                        if (price >= 1000 && price <= 10000)
                        {
                            Console.WriteLine($"{parts[0]} — {parts[1]} руб. ({parts[2]})");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Все товары, отсортированные по цене (по возрастанию):");
                    int n = catalog.Length;
                    string[] sorted = new string[n];
                    for (int i = 0; i < n; i++)
                    {
                        sorted[i] = catalog[i];
                    }
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = 0; j < n - i - 1; j++)
                        {
                            string[] partsJ = new string[3];
                            int startJ = 0, partJ = 0;
                            for (int k = 0; k < sorted[j].Length; k++)
                            {
                                if (sorted[j][k] == ';')
                                {
                                    partsJ[partJ] = sorted[j].Substring(startJ, k - startJ);
                                    startJ = k + 1;
                                    partJ++;
                                }
                            }
                            partsJ[2] = sorted[j].Substring(startJ);
                            double priceJ = Convert.ToDouble(partsJ[1]);
                            string[] partsJ1 = new string[3];
                            int startJ1 = 0, partJ1 = 0;
                            for (int k = 0; k < sorted[j + 1].Length; k++)
                            {
                                if (sorted[j + 1][k] == ';')
                                {
                                    partsJ1[partJ1] = sorted[j + 1].Substring(startJ1, k - startJ1);
                                    startJ1 = k + 1;
                                    partJ1++;
                                }
                            }
                            partsJ1[2] = sorted[j + 1].Substring(startJ1);
                            double priceJ1 = Convert.ToDouble(partsJ1[1]);
                            if (priceJ > priceJ1)
                            {
                                string temp = sorted[j];
                                sorted[j] = sorted[j + 1];
                                sorted[j + 1] = temp;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        string[] parts = new string[3];
                        int start = 0, part = 0;
                        for (int j = 0; j < sorted[i].Length; j++)
                        {
                            if (sorted[i][j] == ';')
                            {
                                parts[part] = sorted[i].Substring(start, j - start);
                                start = j + 1;
                                part++;
                            }
                        }
                        parts[2] = sorted[i].Substring(start);
                        Console.WriteLine($"{parts[0]} — {parts[1]} руб. ({parts[2]})");
                    }
                }
            }
        }


}





        




     