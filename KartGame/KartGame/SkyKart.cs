using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartGame
{
    // kartクラスを継承してSkyKartクラスを作る
    class SkyKart : Program
    {
        // 離陸するメソッドの追加
        public void Flying()
        {
            Console.WriteLine("離陸！");
        }

        // Hornメソッドをオーバーライドする
        public override void Horn()
        {
            Console.WriteLine("ピピーッ");
        }
    }
}
