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
    public partial class 學生資料 : Form
    {
        public string type = "";
        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        SqlCommandBuilder cmdbl;
        DataSet ds;


        public 學生資料()
        {
            InitializeComponent();
        }

        private void 學生資料_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();//DESKTOP-76UHSNG\WILLYJR
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";

            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            blindstudentview();
            orderclass();
        }
        private void orderclass()
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







        }

        public void blindstudentview()
        {

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            adap = new SqlDataAdapter("select stu_id 代號,stu_name 名稱,class 期別 from student where class ='" + type + "'", con);

            ds = new System.Data.DataSet();
            adap.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];

            bool blnColorCahnge = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                blnColorCahnge = !blnColorCahnge;
                if (blnColorCahnge)
                    r.DefaultCellStyle.BackColor = Color.LightGray;
                else
                    r.DefaultCellStyle.BackColor = Color.White;
            }
            dataGridView1.Columns[0].ReadOnly = false;
        }

        private void cbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                int res = 0;
                if (int.TryParse(cbclass.Text, out res))
                {
                    type = cbclass.Text;
                    
                    blindstudentview();
                }
            
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds);
            MessageBox.Show("資料已更新完成!!!", "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn增刪減_Click(object sender, EventArgs e)
        {
            學生增刪改 myform刪改 = new 學生增刪改();
            myform刪改.Show();
            
        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            第一頁 myform1 = new 第一頁();
            myform1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
