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
    public partial class 訂購單 : Form
    {
        SqlConnectionStringBuilder scsb;
        public string type = "";
        public string type3 = "";
        int blocktime = 1259;                       //DESKTOP-76UHSNG\WILLYJR //.
        public string type4 = "";
        int 數量 = 0;
        
        //List<string> price = new List<string>();

        public 訂購單()
        {
            InitializeComponent();
        }

        private void 訂購單_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            scsb = new SqlConnectionStringBuilder();      //DESKTOP-76UHSNG\WILLYJR  //  .
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";//ipaddress>>SQLsever的伺服器名稱"/"; "@"不考慮特殊符號
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            tbstoID.ReadOnly = true;
            

            tbprice.ReadOnly = true;

            stuclass();
            stuname();
            storename();
            storeid();


            proname();
            proprice();

           


        }
        private void storeid()
        {


                SqlConnection con = DataBaseClass.DataBase(@"DESKTOP-76UHSNG\WILLYJR", "midterm", true, "", "");

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select  Store_id From Order_Master where class = '" + cb期數.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tbstoID.Text = (dr["Store_id"].ToString());

                }

                con.Close();
            
        }

        private void storename()
        {
            
                SqlConnection con = DataBaseClass.DataBase(@"DESKTOP-76UHSNG\WILLYJR", "midterm", true, "", "");

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select  Store_name From Order_Master where class ='" + cb期數.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb店家名稱.Text = (dr["Store_name"].ToString());

                }

                con.Close();
            
        }

        /*
               string strSQL = "select * from Store ";
               int x = DataBaseClass.datax(con, strSQL);
               int y = DataBaseClass.datay(con, strSQL);
               string[,] database = new string[x, y];
               database = DataBaseClass.search(con, strSQL);
               strSQL = "Select distinct Product_name From Product  where Store_id = (select Store_id from Order_Master where order_num=" + database[database.GetLength(0) - 1, 0] + ")";
               x = DataBaseClass.datax(con, strSQL);
               y = DataBaseClass.datay(con, strSQL);
               database = new string[x, y];
               database = DataBaseClass.search(con, strSQL);
               for (int i = 0; i < database.GetLength(0); i++)
               {
               cb商品名稱.Items.Add(database["Product_name"].ToString());

               }*/


        private void proname()
        {
            cb商品名稱.Items.Clear();
            SqlConnection con = DataBaseClass.DataBase(@"DESKTOP-76UHSNG\WILLYJR", "midterm", true, "", "");
                
               
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                
                cmd.CommandText = "Select distinct Product_name From Product  where Store_id = '"+ tbstoID.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                
                foreach (DataRow dr in dt.Rows)
                {
                    cb商品名稱.Items.Add(dr["Product_name"].ToString());
                    

                }

                con.Close();
            
        }
        private void proprice()
        {


                 
                 SqlConnection con = DataBaseClass.DataBase(@"DESKTOP-76UHSNG\WILLYJR", "midterm", true, "", "");
                 con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select distinct Product_price From product  where Product_name = '" + cb商品名稱.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                     tbprice.Text=(dr["Product_price"].ToString());
                     //price.Add(dr["Product_price"].ToString());
                }
                

                con.Close();
           
        }

        private void stuname()
        {

            cb姓名.Items.Clear();
            SqlConnection con = DataBaseClass.DataBase(@"DESKTOP-76UHSNG\WILLYJR", "midterm", true, "", "");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select stu_name From student where class ='" + type + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cb姓名.Items.Add(dr["stu_name"].ToString());

            }

            con.Close();


        }

        private void stuclass()
        {
            cb期數.Items.Clear();
            SqlConnection con = DataBaseClass.DataBase(@"DESKTOP-76UHSNG\WILLYJR", "midterm", true, "", "");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select distinct class From student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cb期數.Items.Add(dr["class"].ToString());

            }

            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            商品詳細資料 myform資訊 = new 商品詳細資料();
            myform資訊.ShowDialog();
            
        }

        private void btn送出訂單_Click(object sender, EventArgs e)
        {
            DialogResult drResult;//紀錄對話框選擇回傳訊息
            drResult = MessageBox.Show("您決定好要吃什麼了嗎?", "訂單確認",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResult == DialogResult.No)//區分YES.NO
            {
                MessageBox.Show("看來你不是很滿意你選的餐點!要趕快囉! 時間不等人","訂單確認", MessageBoxButtons.OK);
            }
            else
            {
                drResult = MessageBox.Show(cb姓名.Text + "今天選擇的是「" +cb商品名稱.Text + "」" + tb數量.Text + "份", "提示視窗", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            }
            if (drResult == DialogResult.Yes)
            {


                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();

                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandText = "select stu_id from student s where s.stu_name ='" + cb姓名.Text + "'";
                cmd3.CommandType = System.Data.CommandType.Text;
                cmd3.Connection = con;

                int stuid = Convert.ToInt32(cmd3.ExecuteScalar());

                SqlCommand cmda2 = new SqlCommand("Insert into Order_detail Values(@Stu_id,@Stu_name,@Product_name,@Product_price,@Orde_qty,@class)", con);

                cmda2.Parameters.AddWithValue("@Stu_id", stuid);
                cmda2.Parameters.AddWithValue("@Stu_name", cb姓名.Text);
                cmda2.Parameters.AddWithValue("@Product_name", cb商品名稱.Text);
                cmda2.Parameters.AddWithValue("@Product_price", Convert.ToInt32(tbprice.Text));
                cmda2.Parameters.AddWithValue("@Orde_qty",Convert.ToInt32 (tb數量.Text));
                cmda2.Parameters.AddWithValue("@class", Convert.ToInt32 (cb期數.Text));
                int rows = cmda2.ExecuteNonQuery();//只執行部查詢;
                con.Close();
                MessageBox.Show(string.Format("你選擇了一份很美味的餐點，已經為你點餐完畢", rows));
            }
            
            
        }

        private void cb期數_SelectedIndexChanged(object sender, EventArgs e)
        {
            int res = 0;
            if (int.TryParse(cb期數.Text, out res))
            {
                type = cb期數.Text;
                
                stuname();
                storeid();
                storename();
                proname();
                proprice();
            }
        }

        private void tbstoID_TextChanged(object sender, EventArgs e)
        {
           /* int res = 0;
            if(int.TryParse(tbstoID.Text,out res))
            {
                type3 = tbstoID.Text;
                proname();
                proprice();
                
            }*/
        }

        private void tb數量_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn加_Click(object sender, EventArgs e)
        {
            數量 += 1;
            btn加.Enabled = true;
            tb數量.Text = 數量.ToString();
        }

        private void btn減_Click(object sender, EventArgs e)
        {
            數量 -= 1;
            if (數量 < 1)
            {
                數量 = 1;
                btn減.Enabled = false;
                //設定按鈕到1 就不能再按
            }

            tb數量.Text = 數量.ToString();
        }

       

        private void cb商品名稱_SelectedIndexChanged(object sender, EventArgs e)
        {
            proprice();

        }

        private void cb姓名_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl日期.Text = DateTime.Now.ToString("");
            

           /* if (Convert.ToInt32(DateTime.Now.ToString("HHmm")) == 1045)
            {
                btn送出訂單.Enabled = false;

            }


            int x;

            x = blocktime - Convert.ToInt32(DateTime.Now.ToString("HHmm"));

            if (x <= 0)
            {

                label9.Visible = false;

            }
            else if (x <= 60)
            {

                label9.Text = "截止時間 剩餘 " + x.ToString() + " 分";

            }

            if (Convert.ToInt32(DateTime.Now.ToString("HHmm")) == 1200)
            {
                btn送出訂單.Enabled = true;
                //drop();
            }*/
        }

        private void lbl日期_Click(object sender, EventArgs e)
        {
            lbl日期.Text = type4;
            
        }

        private void tb店家名稱_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
