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

namespace WindowsFormsApplication21
{
    public partial class ADONET與SQL : Form
    {
        SqlConnectionStringBuilder scsb;//建立資料庫 類別變數;

        public ADONET與SQL()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ADONET與SQL_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";//ipaddress>>SQLsever的伺服器名稱"/"; "@"不考慮特殊符號
            scsb.InitialCatalog = "C#1";
            scsb.IntegratedSecurity = true;
        }

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "select * from persons";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();//固定模式

            string str輸出 = "";
            int i = 0;
            //
            while (reader.Read())//獨到資料return true
            {
                str輸出 += string.Format("{0} ,{1} ,{2}\n", reader["id"], reader["姓名"], reader["電話"]);
                i += 1;
            }
            str輸出 += "資料輸出:" + i.ToString();
            reader.Close();
            con.Close();  //使用完 必須關閉 SQL才能釋放空間;

            MessageBox.Show(str輸出);
        }

        private void btn搜尋資料_Click(object sender, EventArgs e)
        {
            if (tb姓名.Text.Length >0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "Select * from persons where 姓名 like @searchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + tb姓名.Text + "%");//SQL 模糊查詢 任意字元
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    tb姓名.Text = string.Format("{0}",reader["姓名"]);
                    tb電話.Text = string.Format("{0}", reader["電話"]);
                    tb地址.Text = string.Format("{0}", reader["地址"]);
                    tb信箱.Text = string.Format("{0}", reader["Email"]);
                    dtp生日.Value = (DateTime)reader["生日"];//隱含轉換
                    chk婚姻.Checked = (bool)reader["婚姻狀態"];

                }
                else
                {
                    MessageBox.Show("查無此人");
                    tb姓名.Text = "";
                    tb電話.Text = "";
                    tb地址.Text = "";
                    tb信箱.Text = "";
                    dtp生日.Value = DateTime.Now;
                    chk婚姻.Checked = false;
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名");
            }
        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {
            if (tb姓名.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update persons set 電話 = @NewPhone , 地址 = @NewAddress, Email =@NewEmail,生日 = @NewBirthday,婚姻狀態 = @NewMarriage where 姓名 = @SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", tb姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", tb電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", tb地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", tb信箱.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", (DateTime)dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", (bool)chk婚姻.Checked);

                int rows = cmd.ExecuteNonQuery();//只執行部查詢;
                con.Close();
                MessageBox.Show(string.Format("資料更新完畢，共影響{0}筆資料", rows));
            }
            else
            {
                MessageBox.Show("請輸入姓名!!");
            }
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if (tb姓名.Text.Length >0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into persons values(@SearchName,@Newphone,@NewAddress,@NewEmail,@NewBirthday,@NewMarriage)";
                 
                cmd.Parameters.AddWithValue("@SearchName", tb姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", tb電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", tb地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", tb信箱.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", (DateTime)dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", (bool)chk婚姻.Checked);

                int rows = cmd.ExecuteNonQuery();//只執行部查詢;
                con.Close();
                MessageBox.Show(string.Format("資料新增完畢，共影響{0}筆資料", rows));
            }        
            else
            {
                MessageBox.Show("請輸入姓名!!");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            if (tb姓名.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "delete from persons where 姓名 =@SearchName";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@SearchName", tb姓名.Text);
                int rows = cmd.ExecuteNonQuery();//只執行部查詢;
                con.Close();
                MessageBox.Show(string.Format("資料刪除完畢，共影響{0}筆資料", rows));
                tb姓名.Text = "";
                tb電話.Text = "";
                tb地址.Text = "";
                tb信箱.Text = "";
                dtp生日.Value = DateTime.Now;
                chk婚姻.Checked = false;
            }
            else
            {
                MessageBox.Show("請輸入姓名!!");
            }
            //(1) ID查詢 (2)值取代 string.replace(string,string) >null 值 用 if (tb姓名.Text.Length > 0) 字串搜尋 String IndexOf (string,int32) 檢查排除特殊符號  ex : !@#$%^&*
        }
    }
}
