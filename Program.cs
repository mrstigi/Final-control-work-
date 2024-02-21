using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива строк через пробел:");
        string input = Console.ReadLine()!;
        string[] originalArray = input.Split(' ');

        string[] newArray = FilterArrayByLength(originalArray, 3);

        string originalArrayAsString = "[" + string.Join(", ", originalArray) + "]";
        string newArrayAsString = "[" + string.Join(", ", newArray) + "]";

        Console.WriteLine($"\nИсходный массив: {originalArrayAsString}");
        Console.WriteLine($"Новый массив с длиной <= 3: {newArrayAsString}");
    }

    static string[] FilterArrayByLength(string[] array, int maxLength)
    {
        int count = 0;
        foreach (string item in array)
        {
            if (item.Length <= maxLength)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        foreach (string item in array)
        {
            if (item.Length <= maxLength)
            {
                resultArray[index] = item;
                index++;
            }
        }

        return resultArray;
    }
}

