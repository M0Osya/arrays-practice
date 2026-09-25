using System;

class Program
{
    static void Main()
    {
        // Вариант 0. Успеваемость студентов

        string[] students = { "Анна", "Борис", "Виктор", "Галина" };
        int[] grades = { 85, 92, 78, 95 };

        Console.WriteLine("Успеваемость студентов");
        Console.WriteLine("----------------------");
        Console.WriteLine("{0,-15} {1,10}", "Имя", "Баллы");

        for (int i = 0; i < students.Length; i++)
            Console.WriteLine("{0,-15} {1,10}", students[i], grades[i]);

        int max = grades[0];

        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] > max)
                max = grades[i];
        }

        int bestIndex = Array.IndexOf(grades, max);

        double average = 0;

        for (int i = 0; i < grades.Length; i++)
            average += grades[i];

        average /= grades.Length;

        Console.WriteLine();
        Console.WriteLine($"Лучший студент: {students[bestIndex]}");
        Console.WriteLine($"Баллы: {grades[bestIndex]}");
        Console.WriteLine($"Средний балл группы: {average:F1}");
    }
}
