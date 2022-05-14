using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jyanken4
{
    internal class com
    {
        //定数の設定
        public const string atai = ("1か2か3か4を入力してね。");

        /// <summary>
        /// スタートメッセージの表示
        /// </summary>
        /// <param name="i">●回戦の●</param>
        public static void StartMsg(int i)
        {
            //2秒待つ
            //Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("☆☆☆☆☆☆☆");
            Console.WriteLine(string.Format(" {0,3}回戦", i + 1));
            Console.WriteLine("☆☆☆☆☆☆☆");

            Console.WriteLine("じゃーん");
            //Thread.Sleep(2000);
            Console.WriteLine("けーん");
            //Thread.Sleep(2000);
            Console.WriteLine("ぽん（1～4）＞");
            Console.WriteLine("1:ｸﾞｰ 2:ﾁｮｷ 3:ﾊﾟｰ 4:終了");
        }

        /// <summary>
        /// 入力値チェック
        /// </summary>
        /// <param name="user">入力値</param>
        /// <returns>-1:入力値エラー、0:正常、1:終了</returns>
        public static int ErrCheck(string user)
        {
            int tmp;
            if (!int.TryParse(user, out tmp))
            {
                //数値に変換できない場合
                Console.WriteLine(com.atai);
                return -1;
            }
            else if (tmp == 4)
            {
                //ゲーム終了
                return 1;
            }
            else if (tmp < 1 || 4 < tmp)
            {
                //入力値が数値だが範囲外の場合
                Console.WriteLine(com.atai);
                return -1;
            }
            else
            {
                //入力値が正しい場合
                return 0;
            }
        }

        /// <summary>
        /// ユーザ、コンピューターの手を変換（数字→文字列）
        /// </summary>
        /// <param name="te_before">手</param>
        /// <returns>変換後の文字列（ｸﾞｰ、ﾁｮｷ、ﾊﾟｰ）</returns>
        public static string Tehenkan(string te_before)
        {
            string te_after;
            switch (te_before)
            {
                case "1":
                    te_after = "ｸﾞｰ";
                    break;
                case "2":
                    te_after = "ﾁｮｷ";
                    break;
                default:
                    te_after = "ﾊﾟｰ";
                    break;
            }
            return te_after;
        }


        /// <summary>
        /// じゃんけんの勝負判定
        /// </summary>
        /// <param name="user">ユーザーの手</param>
        /// <param name="com">コンピュータの手</param>
        /// <param name="shohai">戦績詳細を格納するコレクション</param>
        /// <param name="player">Playerインスタンスの配列</param>
        public static string Hantei(string user, string com, Dictionary<string, int> shohai, Player1[] player)
        {
            //じゃんけん判定
            string kekka;
            if (user == com)
            {
                //あいこの場合
                kekka = "あいこ";
            }
            else if ((user == "1" && com == "2") || (user == "2" && com == "3") || (user == "3" && com == "1"))
            {
                kekka = "勝ち";
            }
            else
            {
                kekka = "負け";
            }

            //メッセージ出力、勝敗数の計算
            switch (kekka)
            {
                case "あいこ":
                    Console.WriteLine(kekka + "!");
                    shohai["あいこの数"]++;
                    break;
                case "勝ち":
                    player[0].Msg();
                    shohai["勝ちの数"]++;
                    break;
                default:
                    player[1].Msg();
                    shohai["負けの数"]++;
                    break;
            }

            return kekka;
        }
    }
}
