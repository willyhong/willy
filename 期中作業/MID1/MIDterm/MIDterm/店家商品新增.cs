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
    public partial class 店家商品新增 : Form
    {
        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        SqlCommandBuilder cmdbl;
        DataSet ds;
        public 店家商品新增()
        {
            InitializeComponent();
        }

        private void 店家商品新增_Load(object sender, EventArgs e)
        {
            
            scsb = new SqlConnectionStringBuilder();//DESKTOP-76UHSNG\WILLYJR
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";
            
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            Store();
            blindview();

        }
        private void Store()
        {

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand("select Store_name from Store", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cb店家.DataSource = mydatatable;
            cb店家.DisplayMember = "Store_name";
            reader.Close();
            con.Close();

            
        }
        private void blindview()
        {


            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();


            SqlCommand cmd6 = new SqlCommand();
            cmd6.CommandText = "select Store_id from Store s where s.Store_name ='" + cb店家.Text + "'";
            cmd6.CommandType = System.Data.CommandType.Text;
            cmd6.Connection = con;
            int storeid = Convert.ToInt32(cmd6.ExecuteScalar());

            adap = new SqlDataAdapter("select id 產品代號,  Product_name 產品名稱 ,Product_price 價格  from product where Store_id='" + storeid + "'", con);
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




        private void btn結束_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn查看資訊_Click(object sender, EventArgs e)
        {
            商品詳細資料 my資料 = new 商品詳細資料();
            my資料.ShowDialog();

        }

        private void cb店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            blindview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        

        

        

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        



        
    }
}
