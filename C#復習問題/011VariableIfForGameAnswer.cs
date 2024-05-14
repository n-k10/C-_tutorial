using System;

class NumberGuessingGame
{
    static void Main()
    {
        // 問題1: 整数型の変数 'secretNumber' を宣言し、10で初期化してください。
        int _____ = __;

        // 問題2: 整数型の変数 'guess' を宣言するだけです。初期化はしません。
        int _____;

        // 問題3: プレイヤーに数字を入力してもらい、'guess' に代入します。
        Console.WriteLine("0から20の数字を当ててください！");
        _____ = Convert.ToInt32(Console.ReadLine());

        // 問題4: if文を使って、'guess' が 'secretNumber' と等しいかどうかを確認します。
        if (_____ == ____)
        {
            Console.WriteLine("正解です！");
        }

        // 問題5: else-ifを使って、'guess' が 'secretNumber' より大きい場合には「大きすぎます」と表示します。
        _____ (_____ > ____)
        {
            Console.WriteLine("大きすぎます！");
        }

        // 問題6: elseを追加して、それ以外の場合には「小さすぎます」と表示します。
        _____
        {
            Console.WriteLine("小さすぎます！");
        }

        // 問題7: 整数型の変数 'tries' を宣言し、1で初期化します。
        int _____ = __;

        // 問題8: for文を使って、さらに2回プレイヤーに数字を当てさせます。
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("もう一度試してください！");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == secretNumber)
            {
                Console.WriteLine("正解です！");
                break; // 正解した場合、ループから抜け出します。
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("大きすぎます！");
            }
            else
            {
                Console.WriteLine("小さすぎます！");
            }

            // 問題9: 'tries' の値を1増やします。
            _____++;
        }

        // 問題10: 「試行回数：[tries]回」と表示します。
        Console.WriteLine("試行回数：" + _____ + "回");
    }
}
