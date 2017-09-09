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


namespace MIDterm
{
    public partial class 第一頁 : Form
    {
        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        SqlCommandBuilder cmdbl;
        DataSet ds;
        int storeid = 0;


        public 第一頁()
        {
            InitializeComponent();
        }
        private void Id ()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "select class from Order_Master";
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.Connection = con;

            storeid = Convert.ToInt32(cmd3.ExecuteScalar());
            con.Close();
        }

        private void btn值日生_Click(object sender, EventArgs e)
        {
            if (storeid > 0)
            {
                店家選擇 my店家 = new 店家選擇();
                my店家.Show();
                this.Hide();
            }
            else
            {
                確認表 myform2 = new 確認表();
                myform2.Show();
                this.Hide();
            }
        }

        private void btn登記_Click(object sender, EventArgs e)
        {
            訂購單 myform3 = new 訂購單();
            myform3.ShowDialog();
           
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            維護選項 myform4 = new 維護選項();
            myform4.Show();
            
        }

        private void 第一頁_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR"; //DESKTOP-76UHSNG\WILLYJR

            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            Id();

        }

        private void btn學生_Click(object sender, EventArgs e)
        {
            學生資料 myform4 = new 學生資料();
            myform4.Show();
            this.Hide();
        }

        private void btn櫃台_Click(object sender, EventArgs e)
        {
            Form2 my櫃台 = new Form2();
            my櫃台.Show();
            
        }
    }
}
