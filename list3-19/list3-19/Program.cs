using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list3_19
{
    internal class Program
    {
        // 引数に商品名を受け取り、
        // 商品名に応じた値段を表示するメソッド
        static void Shop(String itemName)
        {
            Console.WriteLine("いらっしゃいませ！");

            if (itemName == "薬草")
            {
                Console.WriteLine(itemName + "は100円です");
            }
            else if (itemName == "棍棒")
            {
                Console.WriteLine(itemName + "は150円です");
            }
        }

        static void Main(string[] args)
        {
            // 「薬草」を引数に渡してShopメソッドを呼び出す
            Shop("薬草");
            Console.ReadKey();
        }
    }
}
