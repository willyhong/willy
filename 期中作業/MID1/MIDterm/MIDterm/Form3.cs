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
    public partial class 確認表 : Form
    {
        
        public string type = "";
        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        SqlCommandBuilder cmdbl;
        DataSet ds;
        public 確認表()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            第一頁 myform5 = new 第一頁();
            myform5.Show();
            this.Hide();
        }

        private void btn確認_Click(object sender, EventArgs e)
        {
            店家選擇 myform選擇 = new 店家選擇();
            myform選擇.Show();
            this.Hide();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand("update dalistu set Stu_name =@stuname, class = @class ", con);
            cod.Parameters.AddWithValue("@stuname", cbstuname.Text);
            cod.Parameters.AddWithValue("@class", cbclassdtil.Text);
            cod.ExecuteNonQuery();





            




        }

        private void 確認表_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR"; //DESKTOP-76UHSNG\WILLYJR

            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            blindstudentview();
            stuclass();
            stuname();
            
            
           


        }


       
        private void stuname()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand("select distinct stu_name from student where class ='" + type + "'", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cbstuname.DataSource = mydatatable;
            cbstuname.DisplayMember = "stu_name";
            reader.Close();
            con.Close();

        }


        private void stuclass()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand("select distinct class from student", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cbclassdtil.DataSource = mydatatable;
            cbclassdtil.DisplayMember = "class";
          
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
                    r.DefaultCellStyle.BackColor = Color.LightBlue;
                else
                    r.DefaultCellStyle.BackColor = Color.White;
            }
            dataGridView1.Columns[0].ReadOnly = false;
        }







        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbclassdtil_SelectedIndexChanged(object sender, EventArgs e)
        {
            int res = 0;
            if (int.TryParse(cbclassdtil.Text, out res))
            {
                type = cbclassdtil.Text;
                
                blindstudentview();
                stuname();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
