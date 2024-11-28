using System;

public class Program
{
    public static void Main(string[] args)
    {
        HandleMultipleExceptions("abc", 5);
        HandleMultipleExceptions("2", 5);
        HandleMultipleExceptions("2", 1);
    }

    public static void HandleMultipleExceptions(string inputString, int index)
    {
        int[] numbers = { 1, 2, 3 };

        try
        {
            int parsedNumber = int.Parse(inputString);
            int number = numbers[index];
            Console.WriteLine($"Number at index {index} is {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Format");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index Out Of Range");
        }
    }
}
