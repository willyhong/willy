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
    public partial class Form2 : Form
    {
        string type = "95";
        public string str接收的字串 = " ";
        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            
                scsb = new SqlConnectionStringBuilder();
                scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";   //DESKTOP - 76UHSNG\WILLYJR
                scsb.InitialCatalog = "midterm";
                scsb.IntegratedSecurity = true;
                bindMyGridView();
                stuclass();
                decide();
                totalqty();
                totalprice();
                timer1.Enabled = true;
                dalistu();
            
           
        }
        private void dalistu()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = ("select d.Stu_name from dalistu d where d.class ='" + type + "'");
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.Connection = con;
            tb值日生.Text = Convert.ToString(cmd3.ExecuteScalar());
        }
        private void totalqty()
        {
            SqlConnection ttqty = new SqlConnection(scsb.ToString());
            ttqty.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select sum(o.Orde_qty) from Order_detail o where o.class ='" + type + "'";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = ttqty;
            tb訂購總數.Text = Convert.ToString(cmd.ExecuteScalar());
        }

        private void totalprice()
        {
            SqlConnection ttprice = new SqlConnection(scsb.ToString());
            ttprice.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select sum( o.Orde_qty*o.Product_price ) from Order_detail o where o.class ='" + type + "'";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = ttprice;
            tb總價.Text = Convert.ToString(cmd.ExecuteScalar());
        }


        private void decide()
        {
            SqlConnection cc = new SqlConnection(scsb.ToString());
            cc.Open();
            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "select Store_name from Store s where s.Store_id in (select Store_id from Order_Master where class='" + type + "')";
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.Connection = cc;
            tb店家名稱.Text  = Convert.ToString(cmd3.ExecuteScalar());


            SqlConnection ct = new SqlConnection(scsb.ToString());
            ct.Open();
            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandText = "select Store_phone from Store s where s.Store_id in (select Store_id from Order_Master where class='" + type + "')";
            cmd4.CommandType = System.Data.CommandType.Text;
            cmd4.Connection = ct;
            tb店家電話.Text = Convert.ToString(cmd4.ExecuteScalar());


            SqlConnection cadd = new SqlConnection(scsb.ToString());
            cadd.Open();
            SqlCommand cmd5 = new SqlCommand();
            cmd5.CommandText = "select Store_add from Store s where s.Store_id in (select Store_id from Order_Master where class='" + type + "')";
            cmd5.CommandType = System.Data.CommandType.Text;
            cmd5.Connection = cadd;
            tb店家地址.Text = Convert.ToString(cmd5.ExecuteScalar());






        }
            public void bindMyGridView()
        {


            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            adap = new SqlDataAdapter("select distinct o.Product_name 品名,sum(o.Orde_qty) 數量 ,o.Product_price 單價,sum(o.Orde_qty)*o.Product_price 單一商品總價 from Order_detail o  where   o.class='" + type + "'group by o.Product_name,o.Product_price", con);


            ds = new System.Data.DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
           

            bool blnColorCahnge = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                blnColorCahnge = !blnColorCahnge;
                if (blnColorCahnge)
                    r.DefaultCellStyle.BackColor = Color.LightGray;
                else
                    r.DefaultCellStyle.BackColor = Color.White;
            }



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

        private void btn確認_Click(object sender, EventArgs e)
        {
            DialogResult drResult;//紀錄對話框選擇回傳訊息
            drResult = MessageBox.Show("費用已經繳清也完成訂購了?", "訂單確認",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResult == DialogResult.No)//區分YES.NO
            {
                
            }
            else
            {
                
                
                MessageBox.Show("謝謝!辛苦了", "訂單明細", MessageBoxButtons.OK);
                Application.Exit();
            }
            
        }

        

        


        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int res = 0;
            if (int.TryParse(cbclass.Text, out res))
            {
                type = cbclass.Text;


                bindMyGridView();
                decide();
                totalqty();
                totalprice();
                dalistu();
            }
        }

        private void tb總價_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox7.Text = DateTime.Now.ToString("d");
        }

        private void tb值日生_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
