using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;

class StudentSystem
        {
            class Student
            {
                public string Name;
                public Dictionary<string, List<int>> Grades = new();

                public double AvgGrade(string subject) =>
                    Grades.ContainsKey(subject) ? Grades[subject].Average() : 0;

                public double OverallAvg() =>
                    Grades.Values.SelectMany(g => g).DefaultIfEmpty(0).Average();
            }

            static void Main()
            {
                var system = new StudentSystem();

                system.AddStudent("Анна", new Dictionary<string, int[]> {
            {"Математика", new[] {5, 4, 5}},
            {"Физика", new[] {4, 4, 5}},
            {"Химия", new[] {5, 5, 5}}
        });
                system.AddStudent("Борис", new Dictionary<string, int[]> {
            {"Математика", new[] {3, 4, 3}},
            {"Физика", new[] {4, 3, 4}},
            {"Химия", new[] {3, 3, 4}}
        });
                system.AddStudent("Виктор", new Dictionary<string, int[]> {
            {"Математика", new[] {5, 5, 5}},
            {"Физика", new[] {5, 5, 5}},
            {"Химия", new[] {5, 5, 5}}
        });

                Console.WriteLine("Средние > 4.0:");
                foreach (var s in system.Students.Where(s => s.OverallAvg() > 4.0))
                    Console.WriteLine($"{s.Name}: {s.OverallAvg():F2}");

                string bestSubj = system.GetBestSubject();
                Console.WriteLine($"\nЛучший предмет: {bestSubj}");

                Console.WriteLine("\nРейтинг:");
                var ranked = system.Students.OrderByDescending(s => s.OverallAvg()).ToList();
                for (int i = 0; i < ranked.Count; i++)
                    Console.WriteLine($"{i + 1}. {ranked[i].Name}: {ranked[i].OverallAvg():F2}");

                Console.WriteLine("\nОтличники:");
                foreach (var s in system.Students.Where(system.IsExcellent))
                    Console.WriteLine(s.Name);

                Console.WriteLine("Двоечники:");
                foreach (var s in system.Students.Where(system.IsPoor))
                    Console.WriteLine(s.Name);

                Console.WriteLine("\nГруппировка оценок:");
                var intervals = system.GroupByInterval();
                foreach (var (range, count) in intervals)
                    Console.WriteLine($"{range}: {count} оценок");
            }

            List<Student> Students = new();

            void AddStudent(string name, Dictionary<string, int[]> subjects)
            {
                var s = new Student { Name = name };
                foreach (var (subj, grades) in subjects)
                    s.Grades[subj] = grades.ToList();
                Students.Add(s);
            }

            string GetBestSubject()
            {
                var allGrades = Students
                    .SelectMany(s => s.Grades.Select(kv => (kv.Key, kv.Value.Average())))
                    .GroupBy(x => x.Key)
                    .Select(g => (Subject: g.Key, Avg: g.Average(x => x.Item2)))
                    .OrderByDescending(x => x.Avg)
                    .FirstOrDefault();
                return allGrades.Subject;
            }

            bool IsExcellent(Student s) =>
                s.Grades.Values.All(grades => grades.All(g => g == 5));

            bool IsPoor(Student s) =>
                s.Grades.Values.Any(grades => grades.Any(g => g <= 3));

            Dictionary<string, int> GroupByInterval()
            {
                var counts = new Dictionary<string, int>
                {
                    ["2–3"] = 0,
                    ["3–4"] = 0,
                    ["4–5"] = 0
                };
                var allGrades = Students.SelectMany(s => s.Grades.Values).SelectMany(g => g);
                foreach (int g in allGrades)
                {
                    if (g >= 2 && g < 3) counts["2–3"]++;
                    else if (g >= 3 && g < 4) counts["3–4"]++;
                    else if (g >= 4 && g <= 5) counts["4–5"]++;
                }
                return counts;
            }
        }

    }
}
}
