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
    public partial class Form6 : Form
    {
        SqlConnectionStringBuilder scsb;
        int 店家ID = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            bool ifnum = Int32.TryParse(tb商品ID.Text, out 店家ID);
            bool ifnum2 = Int32.TryParse(tb商品價格.Text, out 店家ID);

            if (ifnum && ifnum2 && 店家ID > 0)
            {
                if (tb商品名稱.Text.Length > 0 && tb商品價格.Text.Length > 0)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();

                    SqlCommand cmd6 = new SqlCommand();
                    cmd6.CommandText = "Select Store_id from Store s where s.Store_name = '" + cb店家.Text + "'";
                    cmd6.CommandType = System.Data.CommandType.Text;
                    cmd6.Connection = con;
                    int storeid = Convert.ToInt32(cmd6.ExecuteScalar());

                    SqlCommand add商品 = new SqlCommand("Insert into product Values(@id,@Product_name,@Product_price,@Stroe_id )", con);
                    add商品.Parameters.AddWithValue("@id", tb商品ID.Text);
                    add商品.Parameters.AddWithValue("@Product_name", tb商品名稱.Text);
                    add商品.Parameters.AddWithValue("@Product_price", tb商品價格.Text);
                    add商品.Parameters.AddWithValue("@Stroe_id", storeid.ToString());
                    add商品.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("更新完成");
                    tb商品ID.Clear();
                    tb商品名稱.Clear();
                    tb商品價格.Clear();

                }
                else
                {
                    MessageBox.Show("有欄位沒有輸入 請再試一次!!!!", "提示視窗", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                店家ID = 0;
                MessageBox.Show("請輸入正確!!");
                tb商品ID.Text = "";
                tb商品價格.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool ifnum = Int32.TryParse(tb商品ID.Text, out 店家ID);
            bool ifnum2 = Int32.TryParse(tb商品價格.Text, out 店家ID);

            if (ifnum && ifnum2 && 店家ID > 0)
            {
                if (tb商品名稱.Text.Length > 0 && tb商品價格.Text.Length > 0)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();

                    SqlCommand cmd6 = new SqlCommand();
                    cmd6.CommandText = "Select Store_id from Store s where s.Store_name = '" + cb店家.Text + "'";
                    cmd6.CommandType = System.Data.CommandType.Text;
                    cmd6.Connection = con;
                    int storeid = Convert.ToInt32(cmd6.ExecuteScalar());




                    SqlCommand change商品 = new SqlCommand("update Product set  Product_name = @Newname, Product_price = @Newprice  where id = @SearchID", con);
                    change商品.Parameters.AddWithValue("@SearchID", tb商品ID.Text);
                    change商品.Parameters.AddWithValue("@Newname", tb商品名稱.Text);
                    change商品.Parameters.AddWithValue("@Newprice", tb商品價格.Text);
                    //change商品.Parameters.AddWithValue("@Stroe_id", storeid.ToString());

                    change商品.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("更新完成");
                    tb商品ID.Text = "";
                    tb商品名稱.Text = "";
                    tb商品價格.Text = "";


                }
                else
                {
                    MessageBox.Show("請輸入商品名稱!!");
                }
            }
            else
            {


                店家ID = 0;
                MessageBox.Show("請輸入正確!!");
                tb商品ID.Text = "";
                tb商品價格.Text = "";
            }
        }

        private void 刪除_Click(object sender, EventArgs e)
        {
            if (tb商品名稱.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();


                

                string strSQL = "delete from product where Product_name =@Searchname";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@Searchname", tb商品名稱.Text);
                int rows = cmd.ExecuteNonQuery();//只執行部查詢;
                con.Close();
                MessageBox.Show(string.Format("資料刪除完畢，共影響{0}筆資料", rows));
                tb商品ID.Text = "";
                tb商品名稱.Text = "";
                tb商品價格.Text = "";


            }
            else
            {
                MessageBox.Show("請輸入商品名稱!!");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();//DESKTOP-76UHSNG\WILLYJR
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";//ipaddress>>SQLsever的伺服器名稱"/"; "@"不考慮特殊符號
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            Store(); 
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

        private void tb商品ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
