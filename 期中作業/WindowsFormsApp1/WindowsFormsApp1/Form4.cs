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

namespace 期中專題_資策會南區_便當訂購系統
{
    public partial class Form4 : Form
    {

        SqlConnectionStringBuilder scsb;



        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tbcname.Text.Length > 0 && tbaddress.Text.Length > 0 &&
                tbphone.Text.Length > 0)
            {

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmda2 = new SqlCommand("Insert into company Values(@cname,@address,@phone1,@phone2,@note)", con);
                cmda2.Parameters.AddWithValue("@cname", tbcname.Text);
                cmda2.Parameters.AddWithValue("@address", tbaddress.Text);
                cmda2.Parameters.AddWithValue("@phone1", tbphone.Text);
                cmda2.Parameters.AddWithValue("@phone2", tbphone2.Text);
                cmda2.Parameters.AddWithValue("@note", tbother.Text);
                cmda2.ExecuteNonQuery(); ////執行SQL語法
                con.Close();
                MessageBox.Show("新增完成!!!!!");
                tbcname.Clear();
                tbaddress.Clear();
                tbphone.Clear();
                tbphone2.Clear();
                tbother.Clear();
            }
            else
            {

                MessageBox.Show("有欄位沒有輸入 請再試一次!!!!", "提示視窗", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";
            //scsb.DataSource = @"CHENG-PC\SQLEXPRESS";
            scsb.InitialCatalog = "FoodSystem";
            scsb.IntegratedSecurity = true;
        }
    }
}