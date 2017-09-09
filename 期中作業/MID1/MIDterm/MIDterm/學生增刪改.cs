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
    public partial class 學生增刪改 : Form
    {
        SqlConnectionStringBuilder scsb;
        public 學生增刪改()
        {
            InitializeComponent();
        }

        private void 學生增刪改_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();//DESKTOP-76UHSNG\WILLYJR
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";//ipaddress>>SQLsever的伺服器名稱"/"; "@"不考慮特殊符號
            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (tb學生ID.Text.Length > 0)
            {
                DialogResult drResult;//紀錄對話框選擇回傳訊息
                drResult = MessageBox.Show("第"+tb期數.Text+"期同學是個妹子嗎?", "新增確認",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "insert into student values(@SearchID,@Name,@Class)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Class", tb期數.Text);
                    cmd.Parameters.AddWithValue("@SearchID", tb學生ID.Text);
                    cmd.Parameters.AddWithValue("@Name", tb姓名.Text);





                     cmd.ExecuteNonQuery();//只執行部查詢;
                    con.Close();
                    MessageBox.Show(string.Format("歡迎!歡迎!歡迎!非常歡迎她的加入"));
                    tb期數.Text = "";
                    tb學生ID.Text = "";
                    tb姓名.Text = "";
                }
                else
                {
                    SqlConnection con1 = new SqlConnection(scsb.ToString());
                    con1.Open();
                    string strSQL = "insert into student values(@SearchID,@Name,@Class)";
                    SqlCommand cmd1 = new SqlCommand(strSQL, con1);
                    cmd1.Parameters.AddWithValue("@Class", tb期數.Text);
                    cmd1.Parameters.AddWithValue("@SearchID", tb學生ID.Text);
                    cmd1.Parameters.AddWithValue("@Name", tb姓名.Text);





                    int rows = cmd1.ExecuteNonQuery();//只執行部查詢;
                    con1.Close();
                    
                    MessageBox.Show(string.Format("班上男女比例又更加失衡了<已加入>", rows));
                    tb期數.Text = "";
                    tb學生ID.Text = "";
                    tb姓名.Text = "";
                }

            }
            else
            {
                MessageBox.Show("請輸入學生ID!!");
            }
        }




        private void 刪除_Click(object sender, EventArgs e)
        {
            if (tb學生ID.Text.Length > 0)
            {
                DialogResult drResult;//紀錄對話框選擇回傳訊息
                drResult = MessageBox.Show("這一位" + tb姓名.Text + "同學真的離開我們了?", "刪除確認",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = "delete from student where stu_id =@SearchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@SearchID", tb學生ID.Text);
                    cmd.ExecuteNonQuery();//只執行部查詢;
                    con.Close();
                    MessageBox.Show(string.Format("刪除完畢,祝福她/他在其他領域有好的發展"));
                    tb期數.Text = "";
                    tb學生ID.Text = "";
                    tb姓名.Text = "";
                }
                else
                {
                    MessageBox.Show("小心點不要亂刪學生，小心被吉");
                }


            }
            else
            {
                MessageBox.Show("請輸入ID!!");
            }
        }
    }
}
