void PrintNumbers(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}

PrintNumbers(new int[]{1, 2, 3, 4, 5});
