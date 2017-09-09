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
    public partial class Form1 : Form
    {
        string type = "95";
        int companyid = 0; //廠商ID
        string Comphone = "";//廠商電話
        int count = 0; //便當總數量
        string compan = "";//廠商名字
        int i; // 訂購數量的變數
        int blocktime = 1259;//截止時間變數 10:45
        string orderno = "95";
        string stroutput1 = "";
        string type2 = "95"; string companyy;
        string editno = "";
        string dailystudent = "";
        SqlConnectionStringBuilder scsb;
        SqlDataAdapter adap;
        SqlCommandBuilder cmdbl;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
        }

        private void showdailystu()
        {



            SqlConnection cc = new SqlConnection(scsb.ToString());
            cc.Open();


            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandText = "select s.stu_name from Order_detail o inner join student s on o.Stu_id=s.stu_id where Order_num='" + cbclassdetil.Text + "'";
            cmd4.CommandType = System.Data.CommandType.Text;
            cmd4.Connection = cc;
            dailystudent = Convert.ToString(cmd4.ExecuteScalar());
            cc.Close();

            label12.Text = dailystudent;

        }
        private void dailystu()
        {


            SqlConnection con = new SqlConnection(scsb.ToString());

            con.Open();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "select stu_id from student s where s.stu_name ='" + cbname.Text + "'";
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.Connection = con;
            int stuid = Convert.ToInt32(cmd3.ExecuteScalar());


            SqlCommand daily = new SqlCommand("UPDATE Order_Master SET stu_id = @stu_id where Order_num='" + cbclass.Text + "'", con);
            daily.Parameters.AddWithValue("@stu_id", stuid);
            daily.ExecuteNonQuery();
            con.Close();



        }

        private void decide()
        {



            SqlConnection cc = new SqlConnection(scsb.ToString());
            cc.Open();


            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandText = "select Store_name from Store s where s.Store_id in (select Store_id from Order_Master where class='" + type2 + "')";
            cmd4.CommandType = System.Data.CommandType.Text;
            cmd4.Connection = cc;
            string a = Convert.ToString(cmd4.ExecuteScalar());

            if (a == "")
            {
                cbcompany.Enabled = true;
            }
            else
            {

                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandText = "select Store_name from Store s where s.Store_id in (select Store_id from Order_Master where class='" + type2 + "')";
                cmd3.CommandType = System.Data.CommandType.Text;
                cmd3.Connection = cc;
                companyy = Convert.ToString(cmd3.ExecuteScalar());



                cbcompany.Text = companyy;
                cbcompany.Enabled = false;

            }

            cc.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //less.Enabled = false;
            timer1.Enabled = true;
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-76UHSNG\WILLYJR";
            //scsb.DataSource = @"CHENG-PC\SQLEXPRESS";

            scsb.InitialCatalog = "midterm";
            scsb.IntegratedSecurity = true;
            bindMyGridView();
            ComboCompany();
            ComboClass();
            orderClass();




        }
        private void orderClass()
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
        private void ComboClass()
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
        private void ComboCompany()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand("select Store_name from Store", con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cbcompany.DataSource = mydatatable;
            cbcompany.DisplayMember = "Store_name";
            reader.Close();
            con.Close();

        }


        public void bindMyGridView()
        {



            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();

            adap = new SqlDataAdapter("select s.stu_name 訂購人,p.Product_name 品名,o.Orde_qty 數量 ,o.Product_price 單價,o.Orde_qty*o.Product_price 單一商品總價 from student s ,Order_detail o,Order_master om,product p where s.stu_id=o.Stu_id and p.Product_name=o.Product_name and om.class='" + type + "'", con);


            ds = new System.Data.DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 60;

            bool blnColorCahnge = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                blnColorCahnge = !blnColorCahnge;
                if (blnColorCahnge)
                    r.DefaultCellStyle.BackColor = Color.LightBlue;
                else
                    r.DefaultCellStyle.BackColor = Color.White;
            }



        }

        private void cbcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = ("select Product_name from product p,Store s where p.Store_id=s.Store_id and s.Store_name ='" + cbcompany.Text + "'");
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand(a, con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cbproductname.DataSource = mydatatable;
            cbproductname.DisplayMember = "Product_name";
            reader.Close();
            con.Close();


            tbunit.Text = "";
            tbunit.Text = "";
        }

        private void cbclass_SelectedIndexChanged(object sender, EventArgs e)
        {


            int res = 0;
            if (int.TryParse(cbclass.Text, out res))
            {
                type2 = cbclass.Text;
                //orderno = cbclassdetil.Text;

            }

            string a = ("select stu_name from student where class='" + cbclass.Text + "'");
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand(a, con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            cbname.DataSource = mydatatable;
            cbname.DisplayMember = "stu_name";
            reader.Close();
            con.Close();
            decide();
        }

        private void unit_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbproductname_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = 0;
            tbunit.Text = "0";
            tbunit.Text = "";

            string a = ("select Product_price from product p where Product_name ='" + cbproductname.Text + "'");
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand(a, con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            tbunit.Text = Convert.ToString(cod.ExecuteScalar());
            reader.Close();
            con.Close();

        }


        private void btnsumbit_Click(object sender, EventArgs e)
        {


            orderno = cbclass.Text;
            if (tbunit.Text.Length > 0 && Convert.ToInt32(tbunit.Text) > 0)
            {


                DialogResult a;

                if (cbcompany.Enabled == true)
                {
                    a = MessageBox.Show(cbclass.Text + "期別的同學你好，決定好此店家了嗎？", "提示視窗", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    dailystu();

                }
                else
                {
                    a = MessageBox.Show(cbname.Text + "同學你好，你要訂購的是「" + cbproductname.Text + "」 數量" + tbunit.Text + "份嗎？", "提示視窗", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }


                if (a == DialogResult.Yes)
                {


                    SqlConnection con = new SqlConnection(scsb.ToString());

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = " select id from product p where p.Product_name ='" + cbproductname.Text + "'";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    int productid = Convert.ToInt32(cmd.ExecuteScalar());

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "select Product_price from product p where p.Product_name ='" + cbproductname.Text + "'";
                    cmd2.CommandType = System.Data.CommandType.Text;
                    cmd2.Connection = con;
                    int price = Convert.ToInt32(cmd2.ExecuteScalar());

                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.CommandText = "select stu_id from student s where s.stu_name ='" + cbname.Text + "'";
                    cmd3.CommandType = System.Data.CommandType.Text;
                    cmd3.Connection = con;
                    int stuid = Convert.ToInt32(cmd3.ExecuteScalar());

                    SqlCommand cmd6 = new SqlCommand();
                    cmd6.CommandText = "select Store_id from Store s where s.Store_name ='" + cbcompany.Text + "'";
                    cmd6.CommandType = System.Data.CommandType.Text;
                    cmd6.Connection = con;
                    companyid = Convert.ToInt32(cmd6.ExecuteScalar());



                    SqlCommand cmda1 = new SqlCommand("UPDATE Order_Master SET Store_id = @Store_id where class='" + cbclass.Text + "'", con);
                    cmda1.Parameters.AddWithValue("@Store_id", companyid);
                    cmda1.ExecuteNonQuery(); ////執行SQL語法

                    SqlCommand cmda2 = new SqlCommand("Insert into Order_detail Values(@Order_num,@Product_id,@Product_price,@Orde_qty,@Stu_id)", con);
                    cmda2.Parameters.AddWithValue("@Order_num", orderno);
                    cmda2.Parameters.AddWithValue("@Product_id", productid);
                    cmda2.Parameters.AddWithValue("@Product_price", price);
                    cmda2.Parameters.AddWithValue("@Orde_qty", tbunit.Text);
                    cmda2.Parameters.AddWithValue("@Stu_id", stuid);
                    cmda2.ExecuteNonQuery(); ////執行SQL語法

                    con.Close();
                    bindMyGridView();
                    decide();
                    counttotal();
                    cbclassdetil.Text = cbclass.Text;


                    if (cbclass.Text == "95")
                        showdailystu();


                    MessageBox.Show("資料送出完成 !!!!!!!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


                //if (tbquan.Text.Length == 0)
                //{
                //    MessageBox.Show("請填寫要訂購的數量", "提示", MessageBoxButtons.OK,MessageBoxIcon.Question);
                //}
                //else
                //{

                //    SqlConnection con = new SqlConnection(scsb.ToString());
                //    con.Open();
                //    SqlCommand cmd = new SqlCommand("Insert into orders Values(@name,@class,@productname,@quan,@price,@companyname)", con);

                //    cmd.Parameters.AddWithValue("@name", cbname.Text);
                //    cmd.Parameters.AddWithValue("@class", cbclass.Text);
                //    cmd.Parameters.AddWithValue("@productname", cbproductname.Text);
                //    cmd.Parameters.AddWithValue("@quan", tbquan.Text);
                //    cmd.Parameters.AddWithValue("@price", tbunit.Text);
                //    cmd.Parameters.AddWithValue("@companyname", cbcompany.Text);

                //    cmd.ExecuteNonQuery(); ////執行SQL語法
                //    con.Close();
                //    bindMyGridView();
                //    MessageBox.Show("資料送出完成 !!!!!!!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            else
            {
                MessageBox.Show("請選擇數量 !!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string a = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("delete from Order_detail where Order_num ='" + a + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                bindMyGridView();
                MessageBox.Show("資料刪除完成 !!!!!!!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show("請選擇一筆資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void add_Click(object sender, EventArgs e)
        {

            i++;
            tbunit.Text = Convert.ToString(i);
            //less.Enabled = true;
        }


        private void less_Click(object sender, EventArgs e)
        {
            i--;

            if (i == 0)
            {
                //less.Enabled = false;
            }

            tbunit.Text = Convert.ToString(i);

        }

        private void datarowvalidated(object sender, DataGridViewCellEventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds);
        }



        private void btnupdate_Click(object sender, EventArgs e)
        {
            int qq = Convert.ToInt32(textBox2.Text);
            if (qq > 0 && qq < 100)
            {
                edit();
                MessageBox.Show("資料已更新完成!!!", "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("數量有錯誤!!!", "提示視窗", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //cmdbl = new SqlCommandBuilder(adap);
            //adap.Update(ds);
            //MessageBox.Show("資料已更新完成!!!", "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncompny_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            label8.Text = DateTime.Now.ToString();

            if (Convert.ToInt32(DateTime.Now.ToString("HHmm")) == 1045)
            {
                btnsumbit.Enabled = false;

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
                btnsumbit.Enabled = true;
                drop();
            }



        }

        private void btncomplete_Click(object sender, EventArgs e)
        {

            try
            {
                //找出廠商電話companyid
                SqlConnection con2 = new SqlConnection(scsb.ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select Store_phone from Store s where s.Store_id in (select Store_id from Order_Master where class='" + type + "')";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con2;
                con2.Open();
                Comphone = Convert.ToString(cmd.ExecuteScalar());

                //con2.Close();
                // 計算總數量
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = " select sum(Orde_qty) from Order_detail where Order_num='" + orderno + "'";
                cmd2.CommandType = System.Data.CommandType.Text;
                cmd2.Connection = con2;
                //con2.Open();
                count = Convert.ToInt32(cmd2.ExecuteScalar());

                // 找出廠商
                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandText = "select Store_name from Store s where s.Store_id in (select Store_id from Order_Master where class='" + type + "')";
                cmd3.CommandType = System.Data.CommandType.Text;
                cmd3.Connection = con2;
                compan = Convert.ToString(cmd3.ExecuteScalar());

                //找出期別
                //SqlCommand cmd4 = new SqlCommand();
                //cmd4.CommandText = "select distinct class from order_master o,order_detail m where o.order_no=m.order_no";
                //cmd4.CommandType = System.Data.CommandType.Text;
                //cmd4.Connection = con2;
                //String Sclass = Convert.ToString(cmd4.ExecuteScalar());

                con2.Close();


                //String Sclass = ds.Tables[0].Rows[0][2].ToString(); //期別
                //String compan = ds.Tables[0].Rows[0][6].ToString(); //廠商名
                string b = "select s.stu_name,s.class,p.Product_name,o.Orde_qty,o.Product_price from student s ,Order_detail o,product p,Order_Master om where s.stu_id=o.Stu_id and p.id=o.Product_id and om.order_num=o.Order_num and om.class='" + type + "'";
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cod = new SqlCommand(b, con);
                SqlDataReader reader = cod.ExecuteReader();

                String stroutput = "";
                int total = 0;
                int totalquan = 0;
                int c = 0;
                stroutput = type + "期　" + compan + "　電話號碼" + Comphone + "　時間" + blocktime + "\n\n" +
                    "品名\t數量\t單價\t總價\t訂購人\n";
                while (reader.Read())
                {
                    stroutput += String.Format("{0}\t{1}\t{2}\t{3}\t{4}",
                        reader["Product_name"], reader["Orde_qty"], reader["Product_price"], Convert.ToInt32(reader["Orde_qty"]) * Convert.ToInt32(reader["Product_price"]), reader["Product_name"] + "\n");
                    totalquan += Convert.ToInt32(reader["Orde_qty"]);
                    total += Convert.ToInt32(reader["Orde_qty"]) * Convert.ToInt32(reader["Product_price"]);

                    c++;
                }
                stroutput += "-----------------------------------------------------\n" +
                             "\t" + totalquan.ToString() + "\t\t" + total.ToString() + "$\n" +
                             "\t\t\t總計收費" + Convert.ToString(total) + "$\n" +
                             "\t\t\t共" + c.ToString() + "筆";

                reader.Close();
                SqlCommand UPtotal = new SqlCommand("UPDATE Order_Master SET total_amt = @total where order_num='" + orderno + "'", con);
                UPtotal.Parameters.AddWithValue("@total", total);
                UPtotal.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(stroutput, "訂購明細");


            }
            catch (Exception ex)
            {
                MessageBox.Show("沒有訂單資料！請再試一次", "錯誤訊息");
            }
        }

        private void drop()
        {


            SqlConnection cc = new SqlConnection(scsb.ToString());
            cc.Open();
            SqlCommand UPtotal = new SqlCommand("UPDATE Order_Master SET total_amt = NULL where order_num='" + type + "'", cc);
            UPtotal.ExecuteNonQuery();

            SqlCommand UPtotal2 = new SqlCommand("UPDATE Order_Master SET Store_id = NULL where order_num='" + type + "'", cc);
            UPtotal2.ExecuteNonQuery();

            SqlCommand UPtotal3 = new SqlCommand("UPDATE Order_Master SET Stu_id = NULL where order_num='" + type + "'", cc);
            UPtotal3.ExecuteNonQuery();

            SqlCommand dropdetail = new SqlCommand("DELETE FROM Order_detail WHERE Order_num ='" + type + "'", cc);
            dropdetail.ExecuteNonQuery();




            cc.Close();

            decide();
            bindMyGridView();
            showdailystu();
        }


        private void counttotal()
        {

            string b = "select s.stu_name,s.class,p.Product_name,o.Orde_qty,o.Product_price from student s ,Order_detail o,product p,Order_Master om where s.stu_id=o.Stu_id and p.id=o.Product_id and om.order_num=o.Order_num and om.class='" + type2 + "'";
            SqlConnection cc = new SqlConnection(scsb.ToString());
            cc.Open();
            SqlCommand cod = new SqlCommand(b, cc);
            SqlDataReader reader = cod.ExecuteReader();


            int totalprice = 0;

            while (reader.Read())
            {

                totalprice += Convert.ToInt32(reader["Orde_qty"]) * Convert.ToInt32(reader["Product_price"]);


            }


            reader.Close();

            SqlCommand UPtotal = new SqlCommand("UPDATE Order_Master SET total_amt = @total where order_num='" + orderno + "'", cc);
            UPtotal.Parameters.AddWithValue("@total", totalprice);
            UPtotal.ExecuteNonQuery();
            cc.Close();

        }


        private void button3_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                MessageBox.Show("select rows:" + item.Cells[0].RowIndex.ToString());
                //SqlCommand cmd = new SqlCommand("delete from order_detil where "
            }
        }


        private void tbquan_TextChanged(object sender, EventArgs e)
        {
            string a = ("select Product_price from product p where Product_name ='" + cbproductname.Text + "'");
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cod = new SqlCommand(a, con);
            SqlDataReader reader = cod.ExecuteReader();
            DataTable mydatatable = new DataTable();
            mydatatable.Load(reader);
            tbunit.Text = Convert.ToString(cod.ExecuteScalar());
            reader.Close();
            con.Close();
        }

        private void btn明細_Click(object sender, EventArgs e)
        {
            stroutput1 = "";
            int no = 95;
            int total = 0;
            int c = 0;
            int record = 0;


            SqlConnection con2 = new SqlConnection(scsb.ToString());
            con2.Open();


            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "select count(*) from Order_Master where total_amt is not null and Store_id is not null";
            cmd3.CommandType = System.Data.CommandType.Text;
            cmd3.Connection = con2;
            record = Convert.ToInt32(cmd3.ExecuteScalar());
            con2.Close();

            //while(a!="")
            for (int i = 1; i <= record; i++)
            {

                total = 0;
                c = 0;
                string b = "select om.total_amt,ss.Store_phone,ss.Store_name,om.class,om.order_num,om.total_amt,p.id,p.Product_name,p.Product_price,od.Orde_qty,s.stu_id,s.stu_name from Order_Master om ,Order_detail od,student s,product p ,Store ss where om.order_num=od.Order_num and od.Stu_id=s.stu_id and od.Product_id=p.id and ss.Store_id=om.Store_id and om.order_num='" + no.ToString() + "'";
                con2.Open();
                SqlCommand cod = new SqlCommand(b, con2);
                SqlDataReader reader = cod.ExecuteReader();
                reader.Read();

                stroutput1 += "" + reader["class"] + "期　" + reader["Store_name"] + "　電話號碼" + reader["Store_phone"] + "　金額" + reader["total_amt"] + "$\n\n" +
                              "品名\t數量\t單價\t總價\t訂購人\n";

                reader.Close();

                SqlDataReader reader2 = cod.ExecuteReader();
                while (reader2.Read())
                {


                    stroutput1 += String.Format("{0}\t{1}\t{2}\t{3}\t{4}",
                        reader2["Product_name"], reader2["Ordde_qty"], reader2["Product_price"], Convert.ToInt32(reader2["Orde_qty"]) * Convert.ToInt32(reader2["Product_price"]), reader2["stu_name"] + "\n");

                    //total += Convert.ToInt32(reader["quan"]) * Convert.ToInt32(reader["price"]);
                    c++;
                }


                stroutput1 += "-----------------------------------------------------------------------------------\n\n";

                //    +
                //"\t" + count.ToString() + "\t\t" + total.ToString() + "$\n" +
                //"\t\t\t總計收費" + total.ToString() + "$\n" +
                //"\t\t\t共" + c.ToString() + "筆\n\n";

                reader2.Close();
                con2.Close();
                no++;


            }
            if (record == 0)
            {
                stroutput1 = "沒有訂單資料！請再試一次";
            }
            MessageBox.Show(stroutput1, "訂購彙總");

        }

        private void cbclassdetil_SelectedIndexChanged(object sender, EventArgs e)
        {

            int res = 0;
            if (int.TryParse(cbclassdetil.Text, out res))
            {
                type = cbclassdetil.Text;
                //orderno = cbclassdetil.Text;
                bindMyGridView();
                showdailystu();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       

 

       

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int cid;
                SqlConnection cc = new SqlConnection(scsb.ToString());
                cc.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " select Store_id  from Order_Master where class ='" + type + "'";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = cc;
                cid = Convert.ToInt32(cmd.ExecuteScalar());


                cc.Close();



                string a = ("select Product_name from product p,Store s where p.Store_id=s.Store_id and s.Store_id ='" + cid.ToString() + "'");
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cod = new SqlCommand(a, con);
                SqlDataReader reader = cod.ExecuteReader();
                DataTable mydatatable = new DataTable();
                mydatatable.Load(reader);
                cbname.DataSource = mydatatable;
                cbname.DisplayMember = "Product_name";
                reader.Close();
                con.Close();

                moveto(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("沒有資料！請再試一次", "錯誤訊息");
            }
        }

        internal void moveto(int p)
        {
            try
            {
                //textBox1.Text = dataGridView1.SelectedCells[p].ColumnIndex.ToString();
                string a = dataGridView1.Rows[p].Cells[2].Value.ToString();
                cbname.Text = a;
                string b = dataGridView1.Rows[p].Cells[3].Value.ToString();
                textBox2.Text = b;
                editno = dataGridView1.Rows[p].Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("請選擇一筆資料！", "錯誤訊息");
            }
        }

        public void edit()
        {


            SqlConnection cc = new SqlConnection(scsb.ToString());
            cc.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " select id from product p where p.Product_name ='" + cbname.Text + "'";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = cc;
            int pid = Convert.ToInt32(cmd.ExecuteScalar());



            SqlCommand dataedit = new SqlCommand("UPDATE Order_detail SET Product_id = @newproduct_id where Order_item='" + editno + "'", cc);
            dataedit.Parameters.AddWithValue("@newproduct_id", pid);
            dataedit.ExecuteNonQuery();

            SqlCommand dataedit2 = new SqlCommand("UPDATE Order_detail SET Orde_qty = @newqty where Order_item='" + editno + "'", cc);
            dataedit2.Parameters.AddWithValue("@newqty", textBox2.Text);
            dataedit2.ExecuteNonQuery();


            cc.Close();
            bindMyGridView();


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;



            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnupdate_Click(this, null);
            }
        }

       

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.E)
            {
                系統維護ToolStripMenuItem.ShowDropDown();
            }
            else if (e.Alt && e.KeyCode == Keys.R)
            {
                this.離開ToolStripMenuItem_Click_1(this, e);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            bindMyGridView();

        }

        private void 系統維護ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 離開ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 更換店家toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult a;

            a = MessageBox.Show("提醒您：更換店家將清除該期別之訂單資料，\n請問要更換" + type + "期別的店家嗎？", "提示視窗", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (a == DialogResult.Yes)
            {

                drop();
                MessageBox.Show("更換成功！", "提示視窗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 菜單資料維護toolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void 廠商資料維護ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void 學員資料維護ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void cbname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int c = cbclassdetil.Items.Count;


            if (cbclassdetil.SelectedIndex < c - 1)
            {
                cbclassdetil.SelectedIndex += 1;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (cbclassdetil.SelectedIndex > 0)
            {
                cbclassdetil.SelectedIndex -= 1;
            }
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbunit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}