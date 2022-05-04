using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //変数の初期化
            Console.WriteLine("現在の所持金を入力してください。");
            int money = int.Parse(Console.ReadLine());  //現在の所持金

            Console.WriteLine("時給を入力してください。");
            int salary = int.Parse(Console.ReadLine()); //時給

            Console.WriteLine("働いた時間を入力してください。");
            int hour = int.Parse(Console.ReadLine()); //働いた時間

            //現在の所持金の合計を計算して表示
            Console.WriteLine("現在の所持金の合計");
            int sum = money + salary * hour;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
