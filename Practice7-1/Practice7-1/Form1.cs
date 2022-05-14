using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //コンボボックス(ComboBox)へ項目を追加
            ComboBox.Items.Add("0.1");
            ComboBox.Items.Add("0.5");
            ComboBox.Items.Add("0.8");
            ComboBox.Items.Add("1.0");
        }

        public double tax;

        private void CalcButtonClicked(object sender, EventArgs e)
        {
            int price;
            int index = ComboBox.SelectedIndex;
            bool success = int.TryParse(this.priceBox.Text, out price);

            if (success == true)
            {
                // 消費税を計算する
                int taxPrice = (int)(price * (tax + 1));
                this.taxPriceBox.Text = String.Format("{0:#,0}",taxPrice).ToString();


                // 税を計算する
                  this.taxBox.Text = String.Format("{0:#,0}",taxPrice - price).ToString();

            }

            else
            {
                MessageBox.Show("入力が正しくありません");
                priceBox.Text = "";
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tax = double.Parse(ComboBox.Text);
        }
    }
}
