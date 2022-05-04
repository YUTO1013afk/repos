using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (sum <= 500)
            {
                Console.WriteLine("数値を入力してください。");
                int num = int.Parse(Console.ReadLine());
                sum =  sum + num;
            }

            return;
            Console.ReadKey();
        }
    }
}
