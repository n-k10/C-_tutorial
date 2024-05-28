void PrintNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}

PrintNumbers(new int[]{1, 2, 3, 4, 5});


#別解
void PrintNumbers(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}

PrintNumbers(new int[]{1, 2, 3, 4, 5});
