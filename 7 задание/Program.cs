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
                string[] products =
                {
            "Ноутбук-1200-Электроника",
            "Смартфон-800-Электроника",
            "Футболка-25-Одежда",
            "Джинсы-60-Одежда",
            "Кофеварка-150-БытоваяТехника",
            "Микроволновка-200-БытоваяТехника",          
            "Наушники-100-Электроника",
            "Кроссовки-80-Одежда",    
        };
                Console.WriteLine("КАТАЛОГ ТОВАРОВ");                               
                Console.WriteLine("Товары в диапазоне 50-200:");
                var priceRange = products.Where(p =>
                {
                    var price = Convert.ToDouble(p.Split('-')[1]);
                    return price >= 50 && price <= 200;
                });


                foreach (var product in priceRange)
                {
                    var parts = product.Split('-');
                    Console.WriteLine($"{parts[0]} - {parts[1]} - {parts[2]}");
                    
                }
                Console.WriteLine();


                Console.WriteLine("Товары отсортированные по цене (возрастание):");
                var sortedByPriceAsc = products.OrderBy(p => Convert.ToDouble(p.Split('-')[1]));
                foreach (var product in sortedByPriceAsc)
                {
                    var parts = product.Split('-');
                    Console.WriteLine($"{parts[0]} - {parts[1]} - {parts[2]}");                   
                }
                Console.WriteLine();


                Console.WriteLine("Товары отсортированные по цене (убывание):");
                var sortedByPriceDesc = products.OrderByDescending(p => Convert.ToDouble(p.Split('-')[1]));
                foreach (var product in sortedByPriceDesc)
                {
                    var parts = product.Split('-');
                    Console.WriteLine($"{parts[0]} - {parts[1]} - {parts[2]}");
                }
                Console.WriteLine();  
                
                Console.WriteLine("Количество товаров по категориям:");
                var categories = products.Select(p => p.Split('-')[2]).Distinct();
                foreach (var category in categories)
                {
                    var count = products.Count(p => p.Split('-')[2] == category);
                    Console.WriteLine($"{category}: {count} товаров");
            //Where() - фильтрация по условию

            //OrderBy() / OrderByDescending() - сортировка

            //First() - получение первого элемента

            //Average() - вычисление среднего значения

            //Count() - подсчет элементов

            //Select() + Distinct() - получение уникальных категорий
                }
            }
        }
    }
}
            


        




        




     