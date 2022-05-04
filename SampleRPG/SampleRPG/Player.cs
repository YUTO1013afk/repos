using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleRPG
{
    internal class Player
    {
        private String name; // プレイヤの名前
        private int hp; // プレイヤの体力
        private int exp; //プレイヤのの経験値

        // 以下、publicなコンストラクタとメンバメソッドを定義
        public Player(string name, int hp, int exp)
        {
            this.name = name;   // 名前の初期値を代入
            this.hp = hp;   // 体力の初期値を代入
            this.exp = exp; // 経験値の初期化を代入
        }

        // Hpプロパティ
        public int Hp
        {
            set
            {
                this.hp = value;
                if (this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get
            {
                return this.hp;
            }
        }

        // hp変数に値を代入する
        public void SetHp(int hp)
        {
            this.hp = hp;
            if (this.hp < 0)
            {
                this.hp = 0;
            }
        }

        // hp変数の値を取得する
        public int GetHp()
        {
            return this.hp;
        }

        // 攻撃メソッド
        public void  Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
            exp += 10;
        }

        // 防御メソッド
        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した");
            hp -= 5;
            exp -= 5;
        }
    }
}
