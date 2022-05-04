using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list3_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] weights;    // 配列用の変数を宣言する
            weights = new float[7]; //配列の要素数を決める

            //　配列の要素に値を代入する
            weights[0] = 41.2f;
            weights[1] = 42.5f;
            weights[2] = 44.9f;
            weights[3] = 43.2f;
            weights[4] = 45.1f;
            weights[5] = 43.2f;
            weights[6] = 42.7f;

            // 配列の値を全て表示する
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(weights[i]);
            }

            Console.ReadKey();
        }
    }
}
