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
    public partial class 店家選擇 : Form   //DESKTOP-76UHSNG\WILLYJR //.
    {
        //SqlConnection con = new SqlConnection(@"Data Source= .;Initial Catalog=midterm;Integrated Security=True");
        SqlConnectionStringBuilder scsb;
        SqlConnection con;
        string[,] database;
        int ID = 0;
        string type = "";
        public 店家選擇()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult drResult;//紀錄對話框選擇回傳訊息
            drResult = MessageBox.Show("今天的"+type+"值日生是你嗎", "值日生確認",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResult == DialogResult.Yes)
            {
                值日生 myform總表 = new 值日生();
                myform總表.Show();
            }
            else
            {
                MessageBox.Show("幹什麼東西! 想白吃白喝阿! 乖乖繳錢");
            }
        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            第一頁 myform第一 = new 第一頁();
            myform第一.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 店家選擇_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR"; //DESKTOP-76UHSNG\WILLYJR

            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;

            Stuclass();
            storeid();
            dalistu();
            Storename();

        }
        private void Storename()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "select Store_id from Order_Master";
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.Connection = con;

            ID = Convert.ToInt32(cmd3.ExecuteScalar());
            con.Close();

        }
        private void dalistu()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "select Stu_name from dalistu";
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.Connection = con;

            type =cmd3.ExecuteScalar().ToString();
            con.Close();
        }
        private void storeid()
        {
            comboBox1.Items.Clear();
           
            con = DataBaseClass.DataBase(@"DESKTOP-76UHSNG\WILLYJR", "midterm", true, "", "");
            string strSQL = "select * from Store ";
            int x = DataBaseClass.datax(con, strSQL);
            int y = DataBaseClass.datay(con, strSQL);
            database = new string[x, y];
            database = DataBaseClass.search(con, strSQL);
            comboBox1.Items.Clear();
            for(int i=0;i<database.GetLength(0);i++)
            {
                comboBox1.Items.Add(database[i, 0]);
                
            }
            con.Close();
        }

        private void Stuclass()
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                DialogResult drResult;//紀錄對話框選擇回傳訊息
                drResult = MessageBox.Show("今天已經有選擇店家 是否要刪除訂單並重選", "值日生確認",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drResult == DialogResult.Yes)
                {
                    
                    if (comboBox1.Text.Length > 0 && tbstore.Text.Length > 0)
                    {
                        SqlConnection con1 = new SqlConnection(scsb.ToString());
                        con1.Open();
                        string strSQL = "delete from Order_Master where class = '" + cbclassdtil.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(strSQL, con1);
                        cmd1.ExecuteNonQuery();
                        con1.Close();

                        SqlConnection con2 = new SqlConnection(scsb.ToString());
                        con2.Open();
                        string strSQL1 = "delete from Order_detail where class = '" + cbclassdtil.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(strSQL1, con2);
                        cmd2.ExecuteNonQuery();
                        con2.Close();


                        
                        SqlConnection con = new SqlConnection(scsb.ToString());
                        con.Open();
                        SqlCommand cmda2 = new SqlCommand("Insert into Order_Master(Store_id,Store_name,class)Values(@StoreID,@storename,@class)", con);
                        cmda2.Parameters.AddWithValue("@StoreID", comboBox1.Text);
                        cmda2.Parameters.AddWithValue("@storename", tbstore.Text);
                        cmda2.Parameters.AddWithValue("@class", cbclassdtil.Text);
                        cmda2.ExecuteNonQuery();
                        MessageBox.Show("店家資訊已重新寫到訂單！", "傳輸訊息", MessageBoxButtons.OK);
                        con.Close();

                    }
                    
                }
                
            }
            else
            {
                if (comboBox1.Text.Length > 0 && tbstore.Text.Length > 0)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    SqlCommand cmda2 = new SqlCommand("Insert into Order_Master(Store_id,Store_name,class)Values(@StoreID,@storename,@class)", con);
                    cmda2.Parameters.AddWithValue("@StoreID", comboBox1.Text);
                    cmda2.Parameters.AddWithValue("@storename", tbstore.Text);
                    cmda2.Parameters.AddWithValue("@class", cbclassdtil.Text);
                    cmda2.ExecuteNonQuery();
                    MessageBox.Show("店家資訊已寫到訂單！", "傳輸訊息", MessageBoxButtons.OK);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("沒有資料！請再試一次", "錯誤訊息");
                }
            }
        }

       

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con = DataBaseClass.DataBase(@"DESKTOP-76UHSNG\WILLYJR", "midterm", true, "", "");
            string strSQL = "select * from Store ";
            int x = DataBaseClass.datax(con, strSQL);
            int y = DataBaseClass.datay(con, strSQL);
            database = new string[x, y];
            database = DataBaseClass.search(con, strSQL);
            if (comboBox1.SelectedIndex >= 0)
            {
                
                tbstore.Text = database[comboBox1.SelectedIndex, 1];
            }
            con.Close();
        }

        private void btnstore_Click(object sender, EventArgs e)
        {
            商品詳細資料 myform商品 = new 商品詳細資料();
            myform商品.ShowDialog();
            
        }

        private void tbstore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
