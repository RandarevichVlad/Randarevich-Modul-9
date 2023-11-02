using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie_1_Randarevich
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Иван", Age = 20, GPA = 3.5 },
                new Student { Name = "Петр", Age = 21, GPA = 3.2 },
                new Student { Name = "Алексей", Age = 22, GPA = 3.8 },
                new Student { Name = "Елена", Age = 20, GPA = 3.9 },
                new Student { Name = "Ольга", Age = 23, GPA = 3.6 },
                new Student { Name = "Дмитрий", Age = 21, GPA = 3.7 },
                new Student { Name = "Анна", Age = 22, GPA = 3.4 },
                new Student { Name = "Сергей", Age = 20, GPA = 3.1 },
                new Student { Name = "Мария", Age = 24, GPA = 3.3 },
                new Student { Name = "Николай", Age = 23, GPA = 3.5 }
            };

            Console.WriteLine("Выберите способ сортировки:");
            Console.WriteLine("1 - Сортировка по среднему баллу");
            Console.WriteLine("2 - Сортировка по возрасту");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // Сортировка студентов по среднему баллу (возрастание)
                    var sortedByGPA = students.OrderBy(s => s.GPA).ToList();
                    // Вывод отсортированных студентов по среднему баллу
                    Console.WriteLine("\nСтуденты, отсортированные по среднему баллу (по возрастанию):");
                    foreach (var student in sortedByGPA)
                    {
                        Console.WriteLine("Имя: " + student.Name + ", Средний балл: " + student.GPA);
                    }
                    break;
                case 2:
                    // Сортировка студентов по возрасту (возрастание)
                    var sortedByAge = students.OrderBy(s => s.Age).ToList();
                    // Вывод отсортированных студентов по возрасту
                    Console.WriteLine("\nСтуденты, отсортированные по возрасту (по возрастанию):");
                    foreach (var student in sortedByAge)
                    {
                        Console.WriteLine("Имя: " + student.Name + ", Возраст: " + student.Age);
                    }
                    break;
                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }
    }
}
