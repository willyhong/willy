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
    public partial class Form2 : Form
    {
        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        SqlCommandBuilder cmdbl;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";
            //scsb.DataSource = @"CHENG-PC\SQLEXPRESS";
            scsb.InitialCatalog = "FoodSystem";
            scsb.IntegratedSecurity = true;
            blindview();
        }

        private void blindview()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            adap = new SqlDataAdapter("select company_id 代號,cname 名稱,address 地址,phone1 電話1,phone2 電話2,note 備註 from company", con);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds);
            MessageBox.Show("資料已更新完成!!!", "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string a = "";
                a = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string a2 = "";
                a2 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                SqlCommand UPtotal3 = new SqlCommand("UPDATE order_master SET company_id = NULL where company_id='" + a2 + "'", con);
                UPtotal3.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("delete from products where company_id in (select company_id from company c where c.cname='" + a + "')", con);

                SqlCommand cmd2 = new SqlCommand("delete from company where cname ='" + a + "'", con);



                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                blindview();
                MessageBox.Show("資料刪除完成 !!!!!!!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("請選擇一筆資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rowvalidated(object sender, DataGridViewCellEventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            blindview();
        }

    }
}
