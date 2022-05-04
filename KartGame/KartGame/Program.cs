using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartGame
{
    internal class Program
    {
        public int weight; //重量
        public int speed; // 速度
        
        // アクセルを踏むメソッド
        public void Force()
        {
            Console.WriteLine("加速or減速");    // 減速機能を追加
        }

        // クラクションを鳴らす
        public virtual void Horn()
        {
            Console.WriteLine("ブッブー");
        }

        static void Main(string[] args)
        {
            SkyKart skyKart = new SkyKart();
            SkyKart kart = new SkyKart();
            TurboKart turboKart = new TurboKart();
            TurboKart karts = new TurboKart();

            skyKart.Force();
            skyKart.Flying();
            turboKart.Force();
            turboKart.Turbo();
            kart.Horn();
            karts.Horn();
            Console.ReadKey();
        }
    }
}
