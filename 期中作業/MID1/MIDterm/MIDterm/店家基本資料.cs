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
    public partial class 店家基本資料 : Form
    {
        SqlConnectionStringBuilder scsb;
        int 店家ID = 0;
        int 店家phone = 0;
        public 店家基本資料()
        {
            InitializeComponent();
        }

        private void 店家基本資料_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();      //DESKTOP-76UHSNG\WILLYJR  //  .
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";//ipaddress>>SQLsever的伺服器名稱"/"; "@"不考慮特殊符號
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;



        }


        





        private void btn返回_Click(object sender, EventArgs e)
        {
           維護選項 myform維護 = new 維護選項();
            myform維護.Show();
            this.Hide();
        }

        

        

        private void btn查詢_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "Select * from Store where Store_id like @searchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", tbID.Text);//SQL 模糊查詢 任意字元
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    tbID.Text = string.Format("{0}", reader["Store_id"]);
                    tb名稱.Text = string.Format("{0}", reader["Store_name"]);
                    tbadd.Text = string.Format("{0}", reader["Store_add"]);
                    tbphone.Text = string.Format("{0}", reader["Store_phone"]);
                    


                }
                else
                {
                    MessageBox.Show("查無此店");
                    tb名稱.Text = "";
                    tbphone.Text = "";
                    tbadd.Text = "";
                    
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入店家ID");
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bool ifnum = Int32.TryParse(tbphone.Text, out 店家ID);
            bool ifnum2 = Int32.TryParse(tbID.Text, out 店家ID);

            if (ifnum && ifnum2 && 店家ID > 0)
            {
                if (tbID.Text.Length > 0)
                {



                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "insert into store values(@SearchID,@Name,@NewAddress,@Newphone)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", tbID.Text);
                    cmd.Parameters.AddWithValue("@Name", tb名稱.Text);
                    cmd.Parameters.AddWithValue("@NewAddress", tbadd.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", tbphone.Text);



                    cmd.ExecuteNonQuery();//只執行部查詢;
                    con.Close();
                    MessageBox.Show("店家資訊已新增完畢");
                }
                else
                {
                    MessageBox.Show("請輸入店家ID!!");
                }
            }
        
            else
            {
                
                店家ID = 0;
                MessageBox.Show("請輸入正確!!");
                tbID.Text = "";
                tbphone.Text = "";
                tb名稱.Text = "";
                tbadd.Text = "";
            }

            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
                if (tbID.Text.Length > 0)
                {
                    DialogResult drResult;//紀錄對話框選擇回傳訊息
                    drResult = MessageBox.Show("確定'"+tb名稱.Text+"' 要離開我們嗎?","刪除確認", 
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drResult == DialogResult.No)//區分YES.NO
                    {
                        //取消
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(scsb.ToString());
                        con.Open();
                        string strSQL = "delete from Store where Store_id =@SearchID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);

                        cmd.Parameters.AddWithValue("@SearchID", tbID.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("已刪除店家並刪除菜單! 再見了~~~");
                        tbID.Text = "";
                        tb名稱.Text = "";
                        tbphone.Text = "";
                        tbadd.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("請輸入ID!!");
                }
            
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
           
           
                if (tbID.Text.Length > 0)
                {
                    DialogResult drResult;//紀錄對話框選擇回傳訊息
                    drResult = MessageBox.Show("已確認更新資料無誤?", "更新確認",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drResult == DialogResult.No)//區分YES.NO
                    {
                    //取消
                    }
                    else
                    {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "update Store set  Store_name = @Name, Store_add = @NewAddress, Store_phone = @NewPhone  where Store_id = @SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", tbID.Text);
                    cmd.Parameters.AddWithValue("@Name", tb名稱.Text);
                    cmd.Parameters.AddWithValue("@NewAddress", tbadd.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", tbphone.Text);



                    cmd.ExecuteNonQuery();//只執行部分查詢;
                    con.Close();
                    MessageBox.Show("資訊更新完成");
                    }
                }
                else
                {
                    MessageBox.Show("請輸入ID!!");
                }
            
        }

        private void tbadd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn資料集_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from Store";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();//固定模式

            string str輸出 = "";
            int i = 0;
            //
            while (reader.Read())//讀到資料return true
            {
                str輸出 += string.Format("{0} ,{1} ,{2}, {3}\n", reader["Store_id"], reader["Store_name"], reader["Store_add"], reader["Store_phone"]);
                i += 1;
            }
            str輸出 += "資料輸出:" + i.ToString();
            reader.Close();
            con.Close();  //使用完 必須關閉 SQL才能釋放空間;

            MessageBox.Show(str輸出);
        }
    }
}
