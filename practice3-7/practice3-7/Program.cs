using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください。");
            
            int num = int.Parse(Console.ReadLine());
            
            if (num >= 3)
            {
                Console.WriteLine("勝ち");
            }

            Console.ReadKey();
        }
    }
}
