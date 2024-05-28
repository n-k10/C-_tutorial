int[] numbers = {5, 10, 15, 20, 25};
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);


#別解
int[] numbers = {5, 10, 15, 20, 25};
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine(sum);
