using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //変数aに10を代入する
            int a = 10;

            //変数aを2回デクリメントして結果を表示
            a--;
            a--;
            Console.WriteLine(a);

            //変数aを「/=」演算子を使って「4」で割り、結果を表示
            a /= 4;
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
