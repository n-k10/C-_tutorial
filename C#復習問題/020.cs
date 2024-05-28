int[] scores = {80, 95, 100, 70, 85};
for (int i = 0; i < scores.Length; i++)
{
    if (scores[i] >= 90)
    {
        Console.WriteLine("High score!");
    }
    else
    {
        Console.WriteLine("Keep trying!");
    }
}


#別解
int[] scores = {80, 95, 100, 70, 85};
foreach (int score in scores)
{
    if (score >= 90)
    {
        Console.WriteLine("High score!");
    }
    else
    {
        Console.WriteLine("Keep trying!");
    }
}
