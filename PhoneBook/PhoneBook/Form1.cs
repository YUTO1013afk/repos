﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        Dictionary<String, String> phoneBook;

        public Form1()
        {
            InitializeComponent();

            // 電話帳に名前を登録する
            this.phoneBook = new Dictionary<String, String>();
            this.phoneBook.Add("山田一郎", "xxx-3456-4343");
            this.phoneBook.Add("山田二郎", "xxx-8823-9434");
            this.phoneBook.Add("山田三郎", "xxx-7793-2117");
            this.phoneBook.Add("山田史郎", "xxx-1693-7364");

            // ファイルからデータを読み込む
            ReadFromFile();

            // リストに名前を表示する
            foreach (KeyValuePair<string, string> data in phoneBook)
            {
                this.nameList.Items.Add(data.Key);
            }

        }

        private void ReadFromFile()
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\data.txt"))
            {
                while (!file.EndOfStream)
                {
                    String line = file.ReadLine();
                    String[] data = line.Split(',');
                    this.phoneBook.Add(data[0], data[1]);
                }
            }
        }

        private void NameSelected(object sender, EventArgs e)
        {
            // 選択した名前に対応する電話番号を表示する
            string name = this.nameList.Text;
            this.phoneNumber.Text = this.phoneBook[name];
        }
    }
}
