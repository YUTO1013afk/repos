using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace jyanken4
{
    internal class Program
    {
        static void Result(List<int> com, List<int> num, List<string> result)
        {
            for (int k = 0; k < result.Count; k++)
            {
                if (com[k] == 1 && num[k] == 1)
                {
                    Console.WriteLine(String.Format("{0,3}", k + 1) + "回目 " + "COM=" + "グー" + "、user2=".PadLeft(9) + "グー" + "、結果=".PadLeft(6) + result[k]);
                }
                else if (com[k] == 2 && num[k] == 2)
                {
                    Console.WriteLine(String.Format("{0,3}", k + 1) + "回目 " + "COM=" + "チョキ" + "、user2=" + "チョキ" + "、結果=" + result[k]);
                }
                else if (com[k] == 3 && num[k] == 3)
                {
                    Console.WriteLine(String.Format("{0,3}", k + 1) + "回目 " + "COM=" + "パー" + "、user2=".PadLeft(9) + "パー" + "、結果=".PadLeft(6) + result[k]);
                }

                if (com[k] == 2 && com[k] > num[k])
                {
                    Console.WriteLine(String.Format("{0,3}", k + 1) + "回目 " + "COM=" + "チョキ" + "、user2=" + "グー" + "、結果=".PadLeft(6) + result[k]);
                }
                else if (com[k] == 2 && com[k] < num[k])
                {
                    Console.WriteLine(String.Format("{0,3}", k + 1) + "回目 " + "COM=" + "チョキ" + "、user2=" + "パー" + "、結果=".PadLeft(6) + result[k]);
                }
                else if (com[k] == 1 && num[k] == 2)
                {
                    Console.WriteLine(String.Format("{0,3}", k + 1) + "回目 " + "COM=" + "グー" + "、user2=".PadLeft(9) + "チョキ、" + "結果=" + result[k]);

                }
                else if (com[k] == 1 && num[k] == 3)
                {
                    Console.WriteLine(String.Format("{0,3}", k + 1) + "回目 " + "COM=" + "グー" + "、user2=".PadLeft(9) + "パー" + "、結果=".PadLeft(6) + result[k]);

                }
                else if (com[k] == 3 && num[k] == 1)
                {
                    Console.WriteLine(String.Format("{0,3}", k + 1) + "回目 " + "COM=" + "パー" + "、user2=".PadLeft(9) + "グー" + "、結果=".PadLeft(6) + result[k]);

                }
                else if (com[k] == 3 && num[k] == 2)
                {
                    Console.WriteLine(String.Format("{0,3}", k + 1) + "回目 " + "COM=" + "パー" + "、user2=".PadLeft(9) + "チョキ" + "、結果=" + result[k]);

                }
            }

            // 戦績を表示する
            int i;
            int lose = 0;
            int win = 0;
            int even = 0;

            for (i = 0; i < result.Count; i++)
            {


                if (result[i] == "勝ち")
                {
                    win++;
                }
                else if (result[i] == "負け")
                {
                    lose++;
                }
                else
                {
                    even++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(i + "戦中、" + "勝ち=" + win + "、負け=" + lose + "、あいこ=" + even);
            Console.WriteLine("またね！");
        }

        static void Main(string[] args)

        {
            Console.WriteLine("********************");
            Console.WriteLine("じゃんけんゲーム V4");
            Console.WriteLine("********************");

            //ユーザの名前取得
            Console.WriteLine("あなたの名前を入力してください＞");
            string userName = Console.ReadLine();
            Console.WriteLine("じゃんけんしましょ！");

            // 変数iの宣言
            int i = 0;

            Console.WriteLine();
            Console.WriteLine("☆☆☆☆☆☆☆");
            Console.WriteLine(string.Format(" {0,3}回戦", i + 1));
            Console.WriteLine("☆☆☆☆☆☆☆");
            //Thread.Sleep(2000);
            Console.WriteLine("じゃーん");
            //Thread.Sleep(2000);
            Console.WriteLine("けーん");
            //Thread.Sleep(2000);
            Console.WriteLine("ぽーん (１～4) ＞");
            Console.WriteLine("1:グー 2:チョキ 3:パー 4:終了");

            //ユーザとコンピュータのインスタンス作成
            Logic user = new Logic();
            Player1[] player = user.Do(userName);

            // 変数numの宣言
            int num;

            // 配列の宣言
            var list = new List<int>();
            var list2 = new List<int>();
            var list3 = new List<String>();

            //  じゃんけんの処理
            while (true)
            {
                //  1から3までの乱数を取得
                Random r1 = new Random();
                int com = r1.Next(1, 4);

                //  ユーザーからの入力値をinputに格納
                string input = Console.ReadLine();

                // 文字列やNull値の場合のエラー処理
                if (input.All(char.IsDigit) == false || input == "")
                {
                    Console.WriteLine("1か2か3か4を入力してね。");
                    Console.WriteLine("");
                    Console.WriteLine("☆☆☆☆☆☆☆");
                    Console.WriteLine(string.Format(" {0,3}回戦", i + 1));
                    Console.WriteLine("☆☆☆☆☆☆☆");
                    Console.WriteLine("もう一回！じゃんけんしましょ！");
                    //Thread.Sleep(2000);
                    Console.WriteLine("じゃーん");
                    //Thread.Sleep(2000);
                    Console.WriteLine("けーん");
                    //Thread.Sleep(2000);
                    Console.WriteLine("ぽーん (１～4) ＞");
                    Console.WriteLine("1:グー 2:チョキ 3:パー 4:終了");
                    continue;
                }

                try
                {   // 全角を半角に変換
                    input = Strings.StrConv(input, VbStrConv.Narrow);

                    // inputを数値に変換してnumに代入する
                    num = int.Parse(input);
                }

                // Overflowしたときのエラー処理
                catch (OverflowException)
                {
                    Console.WriteLine("1か2か3か4を入力してね。");
                    Console.WriteLine("");
                    Console.WriteLine("☆☆☆☆☆☆☆");
                    Console.WriteLine(string.Format(" {0,3}回戦", i + 1));
                    Console.WriteLine("☆☆☆☆☆☆☆");
                    Console.WriteLine("もう一回！じゃんけんしましょ！");
                    //Thread.Sleep(2000);
                    Console.WriteLine("じゃーん");
                    //Thread.Sleep(2000);
                    Console.WriteLine("けーん");
                    //Thread.Sleep(2000);
                    Console.WriteLine("ぽーん (１～4) ＞");
                    Console.WriteLine("1:グー 2:チョキ 3:パー 4:終了");
                    continue;
                }

                // 終了処理
                if (num == 4)
                {
                    goto LOOPEND;
                }

                // 0か5以上の値が入力されたときのエラー処理
                else if (num > 4 || num == 0)
                {
                    Console.WriteLine("1か2か3か4を入力してね。");
                    Console.WriteLine("");
                    Console.WriteLine("☆☆☆☆☆☆☆");
                    Console.WriteLine(string.Format(" {0,3}回戦", i + 1));
                    Console.WriteLine("☆☆☆☆☆☆☆");
                    Console.WriteLine("もう一回！じゃんけんしましょ！");
                    //Thread.Sleep(2000);
                    Console.WriteLine("じゃーん");
                    //Thread.Sleep(2000);
                    Console.WriteLine("けーん");
                    //Thread.Sleep(2000);
                    Console.WriteLine("ぽーん (１～4) ＞");
                    Console.WriteLine("1:グー 2:チョキ 3:パー 4:終了");
                    continue;
                }

                if (com == 1 && num == 1)
                {
                    Console.WriteLine("コンピュータ：" + "グー");
                    Console.WriteLine("あなた：" + "グー");

                }
                else if (com == 2 && num == 2)
                {
                    Console.WriteLine("コンピュータ：" + "チョキ");
                    Console.WriteLine("あなた：" + "チョキ");
                }
                else if (com == 3 && num == 3)
                {
                    Console.WriteLine("コンピュータ：" + "パー");
                    Console.WriteLine("あなた：" + "パー");
                }

                if (com == 2 && com > num)
                {
                    Console.WriteLine("コンピュータ：" + "チョキ");
                    Console.WriteLine("あなた：" + "グー");
                }
                else if (com == 2 && com < num)
                {
                    Console.WriteLine("コンピュータ：" + "チョキ");
                    Console.WriteLine("あなた：" + "パー");
                }
                else if (com == 1 && num == 2)
                {
                    Console.WriteLine("コンピュータ：" + "グー");
                    Console.WriteLine("あなた：" + "チョキ");

                }
                else if (com == 1 && num == 3)
                {
                    Console.WriteLine("コンピュータ：" + "グー");
                    Console.WriteLine("あなた：" + "パー");

                }
                else if (com == 3 && num == 1)
                {
                    Console.WriteLine("コンピュータ：" + "パー");
                    Console.WriteLine("あなた：" + "グー");

                }
                else if (com == 3 && num == 2)
                {
                    Console.WriteLine("コンピュータ：" + "パー");
                    Console.WriteLine("あなた：" + "チョキ");

                }

                // 判定
                if (num == com)
                {
                    Console.WriteLine("あいこ！");
                    list.Add(com);
                    list2.Add(num);
                    list3.Add("あいこ");
                }
                else if (num == 1 && com == 3 || num == 2 && com == 1 || num == 3 && com == 2)
                {
                    Console.WriteLine("あなたの負けです・・・");
                    list.Add(com);
                    list2.Add(num);
                    list3.Add("負け");
                }
                else if (num == 3 && com == 1 || num == 2 && com == 3 || num == 1 && com == 2)
                {
                    Console.WriteLine("あなたの勝ちです！");
                    list.Add(com);
                    list2.Add(num);
                    list3.Add("勝ち");
                }

                Console.WriteLine("もう一回！じゃんけんしましょ！");
                i += 1;
                Console.WriteLine("");
                Console.WriteLine("☆☆☆☆☆☆☆");
                Console.WriteLine(string.Format(" {0,3}回戦", i + 1));
                Console.WriteLine("☆☆☆☆☆☆☆");
                //Thread.Sleep(2000);
                Console.WriteLine("じゃーん");
                //Thread.Sleep(2000);
                Console.WriteLine("けーん");
                //Thread.Sleep(2000);
                Console.WriteLine("ぽーん (１～4) ＞");
                Console.WriteLine("1:グー 2:チョキ 3:パー 4:終了");
                continue;
            }

            LOOPEND:
            // 戦績を表示する
            Console.WriteLine("**************");
            Console.WriteLine(player[0].Name + "の総合戦績");
            Console.WriteLine("**************");

            // resultメソッドを呼び出す
            Result(list, list2, list3);
            Console.ReadKey();
        }
    }
}
