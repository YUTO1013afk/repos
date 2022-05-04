using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力してEnterを押してください。");

            string name = Console.ReadLine();

            Console.WriteLine("入力された名前");

            Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
