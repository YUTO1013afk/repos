using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerPosX = 10; //プレイヤの位置は「X=5」
            int enemyPosX = 10; //敵の位置は「X=10」

            //プレイヤと敵の位置が等しい場合は敵と遭遇
            if (playerPosX == enemyPosX)
            {
                Console.WriteLine("敵と遭遇");
            }
        }
    }
}
