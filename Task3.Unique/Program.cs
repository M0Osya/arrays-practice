using System;

class Program
{
    public static int[] GetUnique(int[] source)
    {
        int[] unique = new int[source.Length];
        int count = 0;

        for (int i = 0; i < source.Length; i++)
        {
            bool found = false;

            for (int j = 0; j < count; j++)
            {
                if (unique[j] == source[i])
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                unique[count] = source[i];
                count++;
            }
        }

        int[] result = new int[count];

        for (int i = 0; i < count; i++)
            result[i] = unique[i];

        return result;
    }

    static void Main()
    {
        int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };
        int[] unique = GetUnique(source);

        Console.WriteLine("Исходный:   " + string.Join(", ", source));
        Console.WriteLine("Уникальные: " + string.Join(", ", unique));
    }
}
