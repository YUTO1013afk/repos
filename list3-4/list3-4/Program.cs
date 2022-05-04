using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int math = 80;  //数学の点数
            int english = 66;   //英語の点数
            int history = 95;   //歴史の点数

            //平均値を計算して表示
            float average = (math + english + history) / 3.0f;
            Console.WriteLine("平均は" + average + "点");
            Console.ReadKey();
        }
    }
}
