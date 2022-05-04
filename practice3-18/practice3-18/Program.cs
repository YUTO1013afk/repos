using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f };

            Console.WriteLine("体重データ");
            foreach (float w in weights)
            {
                Console.WriteLine(w);
            }

            Console.WriteLine();
            Console.WriteLine("43kg以下の体重");
            
            // 43kg以下の体重だけを表示する
            for  (int i = 0; i < weights.Length; i++)
            {
                if (weights[i] <= 43)
                {
                    Console.WriteLine(weights[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
