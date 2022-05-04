using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("数値を入力してください。");

            Console.WriteLine("1回目");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("2回目");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("3回目");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("4回目");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("5回目");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("合計");
            Console.WriteLine(a + b + c + d + e);

            Console.ReadKey();
        }
    }
}
