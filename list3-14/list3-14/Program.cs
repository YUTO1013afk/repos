using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list3_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerPosX = 5;
            int missilePosX = 15;

            //  プレイヤの位置とミサイルの位置が等しくなければ
            //  ミサイルの移動を繰り返す
            while (playerPosX != missilePosX)
            {
                Console.WriteLine("missile at" +  missilePosX);
                missilePosX--;  //  ミサイルを左に動かす
            }
            Console.WriteLine("HIT");
            Console.ReadKey();
        }
    }
}
