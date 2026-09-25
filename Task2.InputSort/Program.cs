using System;

class Program
{
    static void Main()
    {
        int n;

        while (true)
        {
            Console.Write("Введите количество элементов: ");

            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                break;

            Console.WriteLine("Ошибка: количество элементов должно быть больше 0.");
        }

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Элемент [{i}]: ");

                try
                {
                    numbers[i] = int.Parse(Console.ReadLine()!);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }
        }

        Console.WriteLine("Исходный массив:  " + string.Join(", ", numbers));

        int[] reversed = new int[n];

        for (int i = 0; i < n; i++)
            reversed[i] = numbers[n - 1 - i];

        Console.WriteLine("Обратный порядок: " + string.Join(", ", reversed));

        Array.Sort(numbers);

        Console.WriteLine("Отсортированный:  " + string.Join(", ", numbers));

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];

            if (numbers[i] > max)
                max = numbers[i];
        }

        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Минимум: " + min);
    }
}
