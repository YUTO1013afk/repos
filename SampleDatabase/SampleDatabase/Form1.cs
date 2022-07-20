using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;


namespace SampleDatabase
{
    public partial class Form1 : Form
    {
        //クラスの準備
        private SqlConnection cn = new SqlConnection(); //データベースへの参照
        private SqlCommand cmd = new SqlCommand(); //SQL文を格納するクラス
        private SqlDataReader rd; //SQL文の結果を格納するクラス

        //データベースに接続するための「接続文字列」を取得
        /*        private string cnstr =
                     @"Data Source = (LocalDB)\MSSQLLocalDB;" +
                     @"AttachDbFilename=|DataDirectory|\AddressDatabase.mdf;" +
                     @"Integrated Security = True;" +
                     "Connect Timeout = 30";
        */
        private string cnstr =
             ConfigurationManager.ConnectionStrings["AddrDatabase"].ConnectionString;

        public Form1()
        {
            InitializeComponent();

            //①SqlConnectionクラスのインスタンスに接続文字列を渡し、
            //データベースをオープンする。
            cn.ConnectionString = cnstr;
            cn.Open();

            //②データベースへの参照をSqlCommandクラスのインスタンスに渡す 
            //cmdはSqlCommandのインスタンス 
            cmd.Connection = cn;
            //コマンドの解釈方法をSqlCommandのインスタンスに渡す。
            //(CommandType.Text=SQLコマンドであることを示す)
            cmd.CommandType = CommandType.Text;
            //送信するSELECT文をSqlCommandのインスタンスに渡す。
            cmd.CommandText = "SELECT * FROM [dbo].[Address]";

            //③④SQLをExecuteReaderで送信し、結果をSqlDataReaderで受け取る
            rd = cmd.ExecuteReader();

            //結果を一行ずつ取り出す
            while (rd.Read())
            {
                //データテーブルの各行に結果を格納。
                //rd[SELECT文の項目名]で値を取り出し
                addressDataSet.addressDataTable.AddaddressDataTableRow(
                (int)(rd["id"]),
                rd["name"].ToString(),
                rd["address"].ToString()
                );
            }

            //⑤各種クローズ処理
            rd.Close(); //SqlDataReaderのクローズ
            cn.Close(); //データベースのクロース 
        }

        /// <summary>
        /// ID検索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchIdButton_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = cnstr;
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Address] WHERE ID LIKE N'%" + IdTextBox.Text + "%'";

            addressDataSet.addressDataTable.Rows.Clear();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                addressDataSet.addressDataTable.AddaddressDataTableRow(
                    (int)(rd["Id"]),
                    rd["Name"].ToString(),
                    rd["Address"].ToString()
                );
            }
            rd.Close();
            cn.Close();
        }

            /// <summary>
            /// グリッドviewのクリア
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void ClearButton_Click(object sender, EventArgs e)
            {
                addressDataSet.addressDataTable.Rows.Clear();

            }

            /// <summary>
            /// 住所検索
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void SearchAllButton_Click(object sender, EventArgs e)
            {
                cn.ConnectionString = cnstr;
                cn.Open();

                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[Address] WHERE ADDRESS LIKE N'%" + AdrTextBox.Text + "%'";

                addressDataSet.addressDataTable.Rows.Clear();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    addressDataSet.addressDataTable.AddaddressDataTableRow(
                        (int)(rd["Id"]),
                        rd["Name"].ToString(),
                        rd["Address"].ToString()
                    );
                }
                rd.Close();
                cn.Close();
            }

            /// <summary>
            /// 登録ボタン
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void SaveButton_Click(object sender, EventArgs e)
            {
                using (Form2 frm = new Form2())
                {                  
                    //フォームをモーダル（子ウィンドウを閉じるまで
                    //親ウィンドウが操作できない⇔モーダレス（.Show））で開く
                    frm.ShowDialog();
                }
            }

            /// <summary>
            /// 削除ボタン
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void DeleteButton_Click(object sender, EventArgs e)
            {
                cn.ConnectionString = cnstr;
                cn.Open();

                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                int idx = (int)this.dataGridView1.CurrentRow.Cells[0].Value;
                cmd.CommandText = "DELETE FROM Address WHERE ID = " + idx;

                rd = cmd.ExecuteReader();
                rd.Close();
                cn.Close();

                //全件検索のイベントを実行
                SearchAllButton_Click(null, null);

            }
        }
    }
