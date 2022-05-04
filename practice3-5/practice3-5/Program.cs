using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int型の変数を2つ用意
            int a = 15;
            int b = 2;

            float answer;   // 浮動小数点の結果を代入する変数を用意

            // int型の値に小数点を掛けて計算する場合
            answer = a * 1.0f / b;
            Console.WriteLine(answer);

            // 暗黙のキャストでint型をfloat型にして計算する場合
            float c = a;
            answer = c / b;
            Console.WriteLine(answer);

            // 明示的なキャストでint型をfloat型にして計算する場合
            answer = (float)a / b;
            Console.WriteLine(answer);

            Console.ReadKey();

        }
    }
}
