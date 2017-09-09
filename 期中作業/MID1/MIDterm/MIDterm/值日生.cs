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
    public partial class 值日生 : Form
    {


        string type = "95";
        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        
        DataSet ds;
        public 值日生()
        {
            InitializeComponent();
        }

        private void 值日生_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";   //DESKTOP - 76UHSNG\WILLYJR
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            bindMyGridView();
            stuclass();
        }


        private void stuclass()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand("select distinct class from student", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cbclass.DataSource = mydatatable;
            cbclass.DisplayMember = "class";
            reader.Close();
            con.Close();

            con.Close();

        }

        public void bindMyGridView()
        {


            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            adap = new SqlDataAdapter("select o.Order_num 訂單編號, o.stu_name 訂購人,o.Product_name 品名,o.Orde_qty 數量 ,o.Product_price 單價,o.Orde_qty*o.Product_price 單一商品總價 from Order_detail o where  o.class='" + type + "'", con);


            ds = new System.Data.DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 60;

            bool blnColorCahnge = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                blnColorCahnge = !blnColorCahnge;
                if (blnColorCahnge)
                    r.DefaultCellStyle.BackColor = Color.LightBlue;
                else
                    r.DefaultCellStyle.BackColor = Color.White;
            }



        }

        private void cbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int res = 0;
            if (int.TryParse(cbclass.Text, out res))
            {
                type = cbclass.Text;


                bindMyGridView();
            }
        }

        private void btn未付款_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string a = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("delete from Order_detail where Order_num ='" + a + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                bindMyGridView();
                MessageBox.Show("資料刪除完成 !!!!!!!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show("請選擇一筆資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            DialogResult drResult;//紀錄對話框選擇回傳訊息
            drResult = MessageBox.Show("第"+cbclass.Text+"期今天的餐點都領取完畢了?還是要重新選擇店家呢?", "確認",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResult == DialogResult.No)
            {
                MessageBox.Show("在等一下吧!", "餐點確認", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from Order_Master where class = '"+cbclass.Text+"'";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.ExecuteNonQuery();
                con.Close();

                SqlConnection con1 = new SqlConnection(scsb.ToString());
                con1.Open();
                string strSQL1 = "delete from Order_detail where class = '" + cbclass.Text + "'";
                SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
                cmd1.ExecuteNonQuery();
                con1.Close();


                MessageBox.Show("今天的訂單已刪除完成!", "刪除確認", MessageBoxButtons.OK);
                

            }
        }
    }
}
