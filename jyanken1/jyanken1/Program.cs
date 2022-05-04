using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jyanken1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");
            Console.WriteLine("じゃんけんゲーム V1");
            Console.WriteLine("********************");
            Console.WriteLine("じゃんけんしましょ！");
            Thread.Sleep(2000);
            Console.WriteLine("じゃーん");
            Thread.Sleep(2000);
            Console.WriteLine("けーん");
            Thread.Sleep(2000);
            Console.WriteLine("ぽーん (１～3) ＞");
            Console.WriteLine("1:グー 2:チョキ 3:パー");

            //ユーザーからの入力値をnumに格納
            int num = int.Parse(Console.ReadLine());

            //1から3までの乱数を取得
            Random r1 = new System.Random();
            int com = r1.Next(1, 3);

            Console.WriteLine("コンピューター：" + com);
            Console.WriteLine("あなた：" + num);

            //じゃんけんの処理
            if (num == com)
            {
                Console.WriteLine("あいこ！");
            }
            else if (num == 1 && com == 3 || num == 2 && com == 1 || num == 3 && com == 2)
            {
                Console.WriteLine("あなたの負けです・・・");
            }
            else if (num == 3 && com == 1 || num == 2 && com == 3 || num == 1 && com == 2)
            {
                Console.WriteLine("あなたの勝ちです！");
            }

            Console.ReadKey();
        }
    }
}
