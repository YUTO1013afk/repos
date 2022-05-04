using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b;

            b = a++;

            Console.WriteLine("後置インクリメント");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);

            a = 8;
            b = ++a;

            Console.WriteLine("前置インクリメント");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.ReadKey();
        }
    }
}
