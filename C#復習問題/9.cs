void PrintNumber()
{
    int number = 10;
    Console.WriteLine(number);
}

// この行はエラーになります。`number` は `PrintNumber` メソッド内でのみ有効です。
// Console.WriteLine(number);
