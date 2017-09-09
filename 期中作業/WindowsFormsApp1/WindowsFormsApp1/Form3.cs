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
    public partial class Form3 : Form
    {
        public string type = "";
        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        SqlCommandBuilder cmdbl;
        DataSet ds;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
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
            cbclassdetil.DataSource = mydatatable;
            cbclassdetil.DisplayMember = "class";
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

       

        private void btnupdate_Click(object sender, EventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds);
            MessageBox.Show("資料已更新完成!!!", "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rowvalidated(object sender, DataGridViewCellEventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds);

        }


        private void cbclassdetil_SelectedIndexChanged(object sender, EventArgs e)
        {
            int res = 0;
            if (int.TryParse(cbclassdetil.Text, out res))
            {
                type = cbclassdetil.Text;
                //orderno = cbclassdetil.Text;
                blindstudentview();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = cbclassdetil.Items.Count;


            if (cbclassdetil.SelectedIndex < c - 1)
            {
                cbclassdetil.SelectedIndex += 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cbclassdetil.SelectedIndex > 0)
            {
                cbclassdetil.SelectedIndex -= 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.a = type;
            f7.ShowDialog();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            blindstudentview();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();


                string b = "";
                b = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand cmd2 = new SqlCommand("delete from order_detail where stu_id ='" + b + "'", con);
                cmd2.ExecuteNonQuery();


                string a = "";
                a = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                SqlCommand cmd = new SqlCommand("delete from student where name ='" + a + "'", con);
                cmd.ExecuteNonQuery();



                con.Close();


                blindstudentview();
                MessageBox.Show("資料刪除完成 !!!!!!!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("請選擇一筆資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}