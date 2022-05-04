using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_20
{
    internal class Program
    {
        // 引数にint型の数値を受け取り、その値が偶数か奇数どうか判定
        static void ShowEvenOrOdd(int num)
        {
            if ((num % 2) == 0 ) {
                Console.WriteLine("偶数です");
            }
            else
            {
                Console.WriteLine("奇数です");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください");
            Console.Write("入力値 ");

            // int型のnumに入力された数値を代入
            int num = int.Parse(Console.ReadLine());

            // numを引数に渡してShowEvenOrOddメソッドを呼び出す
            ShowEvenOrOdd(num);

            Console.ReadKey();
        }
    }
}
