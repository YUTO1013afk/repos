using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // コンストラクタに引数を渡してインスタンスを作る
            Player player = new Player("ひろし", 100, 0);
            Player player2 = new Player("たけし", 100, 0);

            // 現在の体力の値を取得
            int hp = player.GetHp();

            // 体力の値を減らす
            int newHP = hp - 2000;

            // newHPをplayerの体力に代入する
            player.SetHp(newHP);

            // playerの今の体力を表示する
            Console.WriteLine("HPは" + player.GetHp());

            // playerのHpプロパティに代入
            player.Hp -= 70;
            Console.WriteLine("HPは" + player.Hp);

            Console.ReadKey();

/*            // player1の経験値をコンソールに表示
            player.Attack();
            Console.WriteLine("現在のexpは" + player.exp + "です");

            // player2の経験値をコンソールに表示
            player2.Attack();
            Console.WriteLine("現在のexpは" + player2.exp + "です");

            // player1のhpをコンソールに表示
            player.Defense();
            Console.WriteLine("現在のhpは" + player.hp + "です");

            // player2のhpをコンソールに表示
            player2.Defense();
            Console.WriteLine("現在のhpは" + player2.hp + "です");

*/        }
    }
}
