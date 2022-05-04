using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("player1の数値を入力してください。");
            int player1PosX = int.Parse(Console.ReadLine());

            Console.WriteLine("player2の数値を入力してください。");
            int player2PosX = int.Parse(Console.ReadLine());

            //プレイヤ1の位置が「2」かつ「6」の場合に仕掛けを解除
            if (player1PosX == 1 || player2PosX == 6) { 
                    Console.WriteLine("仕掛け解除");
                }

            Console.ReadKey();
        }
    }
}
