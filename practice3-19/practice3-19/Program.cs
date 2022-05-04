using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_19
{
    internal class Program
    {
        //「ありがとうございました！」と表示をするメソッドを定義
        static void Thankyou()
        {
            Console.WriteLine("ありがとうございました！");
        }

        static void Main(string[] args)
        {
            //  Thankyouメソッドを呼び出す 
            Thankyou();
            Console.ReadKey();
        }
    }
}
