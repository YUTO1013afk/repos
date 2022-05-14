using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jyanken4
{
    internal class Logic
    {
        /// <summary>
        /// プレイヤーのインスタンス作成
        /// </summary>
        /// <param name="name">ユーザ名</param>
        /// <returns>インスタンスを格納した配列</returns>
        public Player1[] Do(String name)
        {
            Player1[] player = Factory(name);
            return player;
        }

        /// <summary>
        /// プレイヤーのインスタンス作成
        /// </summary>
        /// <param name="name">ユーザ名</param>
        /// <returns>インスタンスを格納した配列</returns>
        public Player1[] Factory(String name)
        {
            Player1[] player = new Player1[2];
            player[0] = new Player(name);
            player[1] = new Player("コンピュータ");
            return player;
        }
    }
}
