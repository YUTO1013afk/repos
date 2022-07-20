using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form1 : Form
    {
        // コンストラクタ
        public Form1()
        {
            InitializeComponent();

            // フォームのロードイベントメソッドを設定
            this.Load += Form1_Load;
            // フォームのキーダウンイベントメソッドを設定
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);

        }

        // フォームのロードイベントメソッド
        private void Form1_Load(object sender, EventArgs e)
        {
            // 透過色に背景色を設定
            this.TransparencyKey = this.BackColor;
        }

        // フォームのキーダウンイベントメソッド
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // フォームを移動させるピクセル数
            int movePixel = 10;
            if (e.Shift)
            {
                movePixel = 1;
            }
            switch (e.KeyCode)
            {
                // 上移動
                case Keys.Up:
                    this.Top -= movePixel;
                    break;
                // 下移動
                case Keys.Down:
                    this.Top += movePixel;
                    break;
                // 左移動
                case Keys.Left:
                    this.Left -= movePixel;
                    break;
                // 右移動
                case Keys.Right:
                    this.Left += movePixel;
                    break;
            }
        }
    }

/*    class Desktop
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        private static extern IntPtr ReleaseDC(IntPtr hwnd, IntPtr hdc);


        public void DrawStringDesktop()
        {
            String hello = "Hello World";
            IntPtr disDC = GetDC(IntPtr.Zero);
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics g = Graphics.FromHdc(disDC);
            IntPtr hDC = g.GetHdc();
            g.ReleaseHdc(hDC);

            Font font = new Font("MSゴシック", 16);
            SizeF stringSize = g.MeasureString(hello, font, 1000);

            g.DrawString(hello, font, new SolidBrush(Color.FromArgb(128, 0, 0, 0)), Screen.PrimaryScreen.Bounds.Width - stringSize.Width, 0);

            g.Dispose();

            ReleaseDC(IntPtr.Zero, disDC);
        }
    }
*/
}