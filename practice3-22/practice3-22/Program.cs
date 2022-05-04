using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_22
{
    internal class Program
    {
        // 数値を引数に取り、
        // 平均値をfloat型で返すメソッド
        static float CalcAverage(int x, int y, int z)
        {
            float avg = (x + y + z) / 3;
            return avg;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("数値を3回入力して下さい");

            Console.Write("1回目:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("2回目:");
            int b = int.Parse(Console.ReadLine());

            Console.Write("3回目:");
            int c = int.Parse(Console.ReadLine());

            float avg = CalcAverage(a, b, c);
            Console.WriteLine("平均値:" + avg);
            Console.ReadKey();
        }
    }
}
