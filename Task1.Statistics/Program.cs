using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        int sum = 0;
        long product = 1;
        int evenCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            product *= numbers[i];

            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
        }

        double average = (double)sum / numbers.Length;
        int aboveAverage = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > average)
            {
                aboveAverage++;
            }
        }

        Console.WriteLine("Массив: " + string.Join(", ", numbers));
        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Произведение: " + product);
        Console.WriteLine("Чётных чисел: " + evenCount);
        Console.WriteLine("Больше среднего (" + average.ToString("F1") + "): " + aboveAverage);
    }
}
