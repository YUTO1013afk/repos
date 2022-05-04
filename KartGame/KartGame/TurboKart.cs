using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartGame
{
    // Kartクラス継承してTurboKartクラスを作る
    class TurboKart : Program
    {
        // ブーストするメソッドのみ追加
        public void Turbo()
        {
            Console.WriteLine("ブースト！");
        }

        // Hornメソッドをオーバーライドする
        public override void Horn()
        {
            Console.WriteLine("ビービー");
        }
    }
}
