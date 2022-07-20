using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace SampleDatabase
{
    public partial class Form2 : Form
    {
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader rd;
        //データベースに接続するための「接続文字列」を取得
        //private string cnstr =
        //    @"Data Source = (LocalDB)\MSSQLLocalDB;" +
        //    @"AttachDbFilename=|DataDirectory|\AddressDatabase.mdf;" +
        //    @"Integrated Security = True;" +
        //    "Connect Timeout = 30";

        private string cnstr = ConfigurationManager.ConnectionStrings["AddrDatabase"].ConnectionString;


        public Form2()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = cnstr;
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [dbo].[Address] VALUES(" +
                "'" + int.Parse(IdTextBox.Text) + "'," +
                "N'" + NameTextBox.Text + "'," +
                "N'" + AdrTextBox.Text + "')";

            while (true) { 
            try
            {
                MessageBox.Show("IDはすでに登録されています");
                break;

            }
            catch (SqlException)
            {
                IdTextBox.Text = "";
            }
            } 
            
            rd = cmd.ExecuteReader();
            rd.Close();
            cn.Close();
            this.Close();

        }
    }
}
