using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jyanken4
{
    internal abstract class Player1
    {
        internal Player[] players;
        /// <summary>
        /// メンバ変数
        /// </summary>

        /// <summary>
        /// プロパティ
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name">ユーザ名</param>
        public Player1(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// メッセージ出力（抽象メソッド）
        /// （継承時に必ずメソッドの中身を
        /// 実装することを前提としたメソッド
        /// </summary>
        public abstract void Msg();
    }

    /// <summary>
    /// 派生クラス①（ユーザ）
    /// </summary>
    internal class Player : Player1
    {

        /// <summary>
        /// コンストラクタ（基底クラスのものを使用）
        /// </summary>
        /// <param name="name"></param>
        public Player(string name) : base(name) { }

        /// <summary>
        /// メッセージ出力
        /// ※抽象メソッドを実装
        /// </summary>
        public override void Msg()
        {
            Console.WriteLine("あなたの勝ちです！");
        }

        /// <summary>
        /// 派生クラス②（コンピュータ）
        /// </summary>
        internal class Com : Player1
        {
            /// <summary>
            /// コンストラクタ（基底クラスのものを使用）
            /// </summary>
            /// <param name="name"></param>
            public Com(string name) : base(name) { }

            /// <summary>
            /// メッセージ出力
            /// ※抽象メソッドを実装ｓ
            /// </summary>
            public override void Msg()
            {
                Console.WriteLine("あなたの負けです・・・");
            }
        }
    }
}
