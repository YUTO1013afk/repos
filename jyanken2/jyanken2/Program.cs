using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jyanken2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");
            Console.WriteLine("じゃんけんゲーム V2");
            Console.WriteLine("********************");
            Console.WriteLine("じゃんけんしましょ！");
            Thread.Sleep(2000);
            Console.WriteLine("じゃーん");
            Thread.Sleep(2000);
            Console.WriteLine("けーん");
            Thread.Sleep(2000);
            Console.WriteLine("ぽーん (１～4) ＞");
            Console.WriteLine("1:グー 2:チョキ 3:パー 4:終了");

            //  ユーザーからの入力値をnumに格納
            int num = int.Parse(Console.ReadLine());

            if (num == 4)
            {
                return;
            }
     
            //  1から3までの乱数を取得
            Random r1 = new System.Random();
            int com = r1.Next(1, 3);

            //  じゃんけんの処理
            while (num != 4)
            {

                Console.WriteLine("コンピューター：" + com);
                Console.WriteLine("あなた：" + num);

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

                Console.WriteLine("もう一度じゃんけんしましょ！");
                Thread.Sleep(2000);
                Console.WriteLine("じゃーん");
                Thread.Sleep(2000);
                Console.WriteLine("けーん");
                Thread.Sleep(2000);
                Console.WriteLine("ぽーん (１～4) ＞");
                Console.WriteLine("1:グー 2:チョキ 3:パー 4:終了");

                //  ユーザーからの入力値をnumに格納
                num = int.Parse(Console.ReadLine());

                //  1から3までの乱数を取得
                r1 = new System.Random();
                com = r1.Next(1, 3);
            }

            return;
            Console.ReadKey();
        }
    }
}
