using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] employees =
        {
            "Родионов Никита Сергеевич-Менеджер",
            "Старков Владимир Олегович-Аналитик",
            "Шеенков Виктор Алексеевич-1C Разработичк",
            "Васильева Анна Владимировна-1C Разработчик",
            "Воронов Сергей Петрович-Аналитик",
            "Григорьев Иван Михайлович-Менеджер",
            "Жукова Елена Александровна-Разработчик"
        };
            Console.WriteLine("===Анализ сотрудников===");
            string targetPosition = "Менеджер";
            Console.WriteLine($"Сотрудники с должностью {targetPosition}:");
            var byPosition = employees
                .Where(e => e.Split('-')[1] == targetPosition);
            if (byPosition.Any())
            {
                foreach (var emp in byPosition)
                {
                    Console.WriteLine($"{emp.Split('-')[0]}");
                }
            }
            else
            {
                Console.WriteLine("Не найдено");
            }
            Console.WriteLine();
            char targetLetter = 'В';
            Console.WriteLine($"Сотрудники, чья фамилия начинается на {targetLetter}:");
            var FirstLetter = employees
                .Where(e => e.Split('-')[0].StartsWith(targetLetter.ToString()));
            if (FirstLetter.Any())
            {
                foreach (var emp in FirstLetter)
                {
                    Console.WriteLine($"{emp}");
                }

            }
        }
    }
}

    



