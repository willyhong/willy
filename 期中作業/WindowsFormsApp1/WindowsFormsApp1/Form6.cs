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
    public partial class Form6 : Form
    {

        SqlConnectionStringBuilder scsb;



        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";
            //scsb.DataSource = @"CHENG-PC\SQLEXPRESS";
            scsb.InitialCatalog = "FoodSystem";
            scsb.IntegratedSecurity = true;
            company();
        }


        private void company()
        {

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand("select cname from company", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cbcompanylist.DataSource = mydatatable;
            cbcompanylist.DisplayMember = "cname";
            reader.Close();
            con.Close();


        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (tbproductname.Text.Length > 0 && tbprice.Text.Length > 0)
            {

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();

                SqlCommand cmd6 = new SqlCommand();
                cmd6.CommandText = "select company_id from company c where c.cname ='" + cbcompanylist.Text + "'";
                cmd6.CommandType = System.Data.CommandType.Text;
                cmd6.Connection = con;
                int companyid = Convert.ToInt32(cmd6.ExecuteScalar());



                SqlCommand cmda2 = new SqlCommand("Insert into products Values(@product_name,@price,@note,@company_id)", con);
                cmda2.Parameters.AddWithValue("@product_name", tbproductname.Text);
                cmda2.Parameters.AddWithValue("@price", tbprice.Text);
                cmda2.Parameters.AddWithValue("@note", tbother.Text);
                cmda2.Parameters.AddWithValue("@company_id", companyid.ToString());
                cmda2.ExecuteNonQuery(); ////執行SQL語法
                con.Close();
                MessageBox.Show("新增完成!!!!!");

                tbproductname.Clear();
                tbprice.Clear();
                tbother.Clear();

            }
            else
            {
                MessageBox.Show("有欄位沒有輸入 請再試一次!!!!", "提示視窗", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
