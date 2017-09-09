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
    public partial class Form5 : Form
    {

        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        SqlCommandBuilder cmdbl;
        DataSet ds;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";
            //scsb.DataSource = @"CHENG-PC\SQLEXPRESS";
            scsb.InitialCatalog = "FoodSystem";
            scsb.IntegratedSecurity = true;
            company();
            blindview();
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

        private void blindview()
        {


            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();


            SqlCommand cmd6 = new SqlCommand();
            cmd6.CommandText = "select company_id from company c where c.cname ='" + cbcompanylist.Text + "'";
            cmd6.CommandType = System.Data.CommandType.Text;
            cmd6.Connection = con;
            int companyid = Convert.ToInt32(cmd6.ExecuteScalar());

            adap = new SqlDataAdapter("select product_id 產品代號 , product_name 產品名稱 ,price 價格 ,note 備註 from products where company_id='" + companyid + "'", con);
            ds = new System.Data.DataSet();
            adap.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
            bool blnColorCahnge = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                blnColorCahnge = !blnColorCahnge;
                if (blnColorCahnge)
                    r.DefaultCellStyle.BackColor = Color.LightBlue;
                else
                    r.DefaultCellStyle.BackColor = Color.White;
            }
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void cbcompanylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            blindview();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds);
            MessageBox.Show("資料已更新完成!!!", "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string a = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("delete from products where product_id='" + a + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                blindview();
                MessageBox.Show("資料刪除完成 !!!!!!!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("請選擇一筆資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = cbcompanylist.Items.Count;


            if (cbcompanylist.SelectedIndex < c - 1)
            {
                cbcompanylist.SelectedIndex += 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (cbcompanylist.SelectedIndex > 0)
            {
                cbcompanylist.SelectedIndex -= 1;
            }
        }

        private void Form5_Activated(object sender, EventArgs e)
        {
            blindview();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
