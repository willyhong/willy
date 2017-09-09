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
    public partial class Form7 : Form
    {


        SqlConnectionStringBuilder scsb;

        public string a;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";
            //scsb.DataSource = @"CHENG-PC\SQLEXPRESS";
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            if (tbname.Text.Length > 0 && tbid.Text.Length > 0)
            {

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();


                SqlCommand cmda2 = new SqlCommand("Insert into student Values(@stu_id,@stu_name,@class)", con);
               
                cmda2.Parameters.AddWithValue("@stu_id", tbid.Text);
                cmda2.Parameters.AddWithValue("@stu_name", tbname.Text);
                cmda2.Parameters.AddWithValue("@class", a);

                cmda2.ExecuteNonQuery(); ////執行SQL語法
                con.Close();
                MessageBox.Show("新增完成!!!!!");

                tbname.Clear();
                tbid.Clear();
                tbclass.Clear();

            }
            else
            {
                MessageBox.Show("有欄位沒有輸入 請再試一次!!!!", "提示視窗", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}