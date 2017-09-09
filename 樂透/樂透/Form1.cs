using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 樂透
{
    public partial class 樂透開獎 : Form
    {
        //威力彩
        List<Button> myButtonList1 = new List<Button>();
        List<Button> myButtonList2 = new List<Button>();
        //539
        List<Button> myButtonList3 = new List<Button>();
       
        int[] willy1num = new int[6];
        int[] willy2num = new int[1];
        int[] user1num = new int[6] { 0, 0, 0, 0, 0, 0 };
        int[] user2num = new int[1];
        int[] num539 = new int[5];
        int[] user539num = new int[5] { 0, 0, 0, 0, 0 };

        public 樂透開獎()
        {
            InitializeComponent();

        }
        private void 樂透開獎_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'willyDataSet._539' 資料表。您可以視需要進行移動或移除。
            this._539TableAdapter.Fill(this.willyDataSet._539);
            // TODO: 這行程式碼會將資料載入 'willyDataSet.willy' 資料表。您可以視需要進行移動或移除。
            this.willyTableAdapter.Fill(this.willyDataSet.willy);
            btn539ball(9, 3);
            btn2ball(7, 0);
            btnBall(9, 3);
            timer1.Enabled = true;
            timer1.Interval = 60;
        }
        private void tp威力彩_Click(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbltime.Text = string.Format("{0}", DateTime.Now);
        }

        private void gbfirststage_Enter(object sender, EventArgs e)
        {


        }
        private void gbsecstage_Enter(object sender, EventArgs e)
        {

        }
        void btnNumBall_Click(object sender, EventArgs e)//第一區BTN
        {


            Button myButton = (Button)sender;


            int A1 = int.Parse(myButton.Text);

            if (user1num[0] == 0 && (myButton.BackColor == Color.Yellow))
            {
                user1num[0] = A1;
                lblyournum.Text += myButton.Text + ",";
                myButton.BackColor = Color.Red;
            }
            else if (user1num[0] != 0 && user1num[1] == 0 && (myButton.BackColor == Color.Yellow))
            {
                user1num[1] = A1;
                lblyournum.Text += myButton.Text + ",";
                myButton.BackColor = Color.Red;
            }
            else if (user1num[0] != 0 && user1num[1] != 0 && user1num[2] == 0 && (myButton.BackColor == Color.Yellow))
            {
                user1num[2] = A1;
                lblyournum.Text += myButton.Text + ",";
                myButton.BackColor = Color.Red;
            }
            else if (user1num[0] != 0 && user1num[1] != 0 && user1num[2] != 0 && user1num[3] == 0 && (myButton.BackColor == Color.Yellow))
            {
                user1num[3] = A1;
                lblyournum.Text += myButton.Text + ",";
                myButton.BackColor = Color.Red;
            }
            else if (user1num[0] != 0 && user1num[1] != 0 && user1num[2] != 0 && user1num[3] != 0 && user1num[4] == 0 && (myButton.BackColor == Color.Yellow))
            {
                user1num[4] = A1;
                lblyournum.Text += myButton.Text + ",";
                myButton.BackColor = Color.Red;
            }
            else if (user1num[0] != 0 && user1num[1] != 0 && user1num[2] != 0 && user1num[3] != 0 && user1num[4] != 0 && user1num[5] == 0 && (myButton.BackColor == Color.Yellow))
            {
                user1num[5] = A1;
                lblyournum.Text += myButton.Text;
                myButton.BackColor = Color.Red;

            }


        }
        void btnBall(int counst, int counst2)//動態產生第一區btn
        {

            int x = 0;
            for (int i = 0; i <= counst2; i++)
            {
                for (int j = 0; j <= counst; j += 1)
                {
                    x += 1;
                    if (x < 39)
                    {
                        Button btnNumBall = new Button();
                        btnNumBall.BackColor = Color.Yellow;
                        btnNumBall.ForeColor = Color.Black;
                        btnNumBall.Location = new Point(19 + 29 * j, 19 + 29 * i);
                        btnNumBall.Size = new Size(30, 20);
                        btnNumBall.Font = new Font("微軟正黑體", 8);
                        btnNumBall.Text = string.Format("{0}", x);
                        btnNumBall.Visible = true;
                        btnNumBall.TextAlign = ContentAlignment.MiddleCenter;
                        btnNumBall.Name = "btn" + i.ToString();
                        btnNumBall.Click += new EventHandler(btnNumBall_Click);
                        gbfirststage.Controls.Add(btnNumBall);
                        myButtonList1.Add(btnNumBall);
                    }

                }

            }
        }
        void dbutton_click(object sender, EventArgs e) //第二區btn
        {


            Button mybtn2 = (Button)sender;

            int btn2 = int.Parse(mybtn2.Text);

            for (int i = 0; i < myButtonList2.Count; i++)
            {
                if (i == (btn2 - 1))
                {
                    mybtn2.BackColor = Color.Red;
                    lblyournum2.Text = mybtn2.Text;
                    user2num[0] = btn2;
                }
                else
                {
                    Button mybtn12 = (Button)myButtonList2[i];
                    mybtn12.BackColor = Color.Yellow;
                }
            }

        }
        void btn2ball(int count, int count2)//第二區BTN
        {
            int s = 0;

            for (int i = 0; i <= count2; i++)
            {
                for (int j = 0; j <= count; j += 1)
                {
                    s += 1;
                    if (s < 9)
                    {
                        Button dbutton = new Button();
                        dbutton.BackColor = Color.Yellow;
                        dbutton.ForeColor = Color.Black;
                        dbutton.Location = new Point(19 + 29 * j, 19 + 29 * i);
                        dbutton.Size = new Size(30, 20);
                        dbutton.Font = new Font("微軟正黑體", 8);
                        dbutton.Text = string.Format("{0}", s);
                        dbutton.Visible = true;
                        dbutton.TextAlign = ContentAlignment.MiddleCenter;
                        dbutton.Name = "btn" + i.ToString();
                        dbutton.Click += new EventHandler(dbutton_click);
                        gbsecstage.Controls.Add(dbutton);
                        myButtonList2.Add(dbutton);
                    }
                }

            }

        }

        private void gb開獎區_Enter(object sender, EventArgs e)
        {

        }

        private void btn開獎_Click(object sender, EventArgs e)
        {
            第一區開獎();
            第二區開獎();
            DataTable myDb威力彩 = willyDataSet.Tables["willy"];
            DataRow myDb威力彩Row = myDb威力彩.NewRow();
            myDb威力彩Row["第一區號碼"] = textBox1.Text + " , " + textBox3.Text + " , " + textBox4.Text + " , "
                                          + textBox5.Text + " , " + textBox6.Text + " , " + textBox7.Text;
            myDb威力彩Row["第二區號碼"] = textBox2.Text;
            myDb威力彩.Rows.Add(myDb威力彩Row);

        }

        void 第一區開獎()
        {
           

            int[] loto = new int[39];
            for (int i = 0; i <= 38; i++)
            {
                loto[i] = i;
            }
            //宣告要取多少個數字
            Random r = new Random();//Random隨機取值

            for (int j = 0; j <= willy1num.Length - 1; j++)
            {
                int temp = r.Next(1, 39);//產生不同的範圍內的隨機數字，請使用 Random.Next(Int32, Int32) 方法多載。
                if (loto[temp] == 0) { j--; }
                else
                {
                    willy1num[j] = loto[temp];

                    loto[temp] = 0; //將以使用之數字以零取代


                }
            }
            Array.Sort(willy1num);
            textBox1.Text = string.Format("{0:D2}", willy1num[0]);
            textBox3.Text = string.Format("{0:D2}", willy1num[1]);
            textBox4.Text = string.Format("{0:D2}", willy1num[2]);
            textBox5.Text = string.Format("{0:D2}", willy1num[3]);
            textBox6.Text = string.Format("{0:D2}", willy1num[4]);
            textBox7.Text = string.Format("{0:D2}", willy1num[5]);
           
        }
        void 第二區開獎()
        {
           

            int[] loto2 = new int[9];
            for (int i = 0; i <= 8; i++)
            {
                loto2[i] = i;
            }

            Random two = new Random();
            for (int j = 0; j < willy2num.Length; j++)
            {
                int temp = two.Next(1, 9);
                if (loto2[temp] == 0) { j--; }
                else
                {
                    willy2num[j] = loto2[temp];

                    loto2[temp] = 0;


                }
            }

            textBox2.Text = string.Format("{0:D2}", willy2num[0]);
           
        }

        private void btnreset_Click(object sender, EventArgs e)//威力彩
        {
            lblyournum.Text = "";
            lblyournum2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            lblmessage.Text = "";
            user1num = new int[6] { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < myButtonList1.Count; i++)
            {
                Button btnNumBall = (Button)myButtonList1[i];
                btnNumBall.BackColor = Color.Yellow;
            }

            for (int j = 0; j < myButtonList2.Count; j++)
            {
                Button dbutton = (Button)myButtonList2[j];
                dbutton.BackColor = Color.Yellow;
            }

        }

        private void lblyournum_Click(object sender, EventArgs e)
        {

        }

        private void btn對獎_Click(object sender, EventArgs e)//威力彩
        {
            int checknum1 = 0;
            int willyOne = 0; //第一區中獎數
            int willyTwo = 0; //2第二區中獎數

            if (textBox1.Text != "")
            {
                for (int i = 0; i < user1num.Count(); i++)
                {

                    if (user1num[i] == 0)
                        checknum1 = 1;
                }
                    if (checknum1 == 0)
                    {
                        if (lblyournum2.Text != "")
                        {
                            for (int x = 0; x < willy1num.Length; x++)
                            {
                                for (int y = 0; y < user1num.Length; y++)
                                {
                                    if (willy1num[x] == user1num[y])
                                    {
                                        willyOne += 1;
                                    }
                                }
                            }
                    
                            if (willy2num[0] == user2num[0])
                            {
                             willyTwo += 1;
                            }
                            if ((willyOne == 6) && (willyTwo == 1))
                            {
                                lblmessage.Text = "恭喜您!中了頭獎!";
                            }
                            if ((willyOne == 6) && (willyTwo == 0))
                            {
                                lblmessage.Text = "恭喜您!中了貳獎!";
                            }
                            if ((willyOne == 5) && (willyTwo == 1))
                            {
                                lblmessage.Text = "恭喜您!中了參獎!";
                            }
                            if ((willyOne == 5) && (willyTwo == 0))
                            {
                                lblmessage.Text = "恭喜您!中了肆獎!";
                            }
                            if ((willyOne == 4) && (willyTwo == 1))
                            {
                                lblmessage.Text = "恭喜您!中了伍獎!";
                            }
                            if ((willyOne == 4) && (willyTwo == 0))
                            {
                                lblmessage.Text = "恭喜您!中了陸獎!";
                            }
                            if ((willyOne == 3) && (willyTwo == 1))
                            {
                                lblmessage.Text = "恭喜您!中了柒獎!";
                            }

                            if ((willyOne == 2) && (willyTwo == 1))
                            {
                                lblmessage.Text = "恭喜您!中了捌獎!";
                            }

                            if ((willyOne == 3) && (willyTwo == 0))
                            {
                                lblmessage.Text = "恭喜您!中了玖獎!";
                            }

                            if ((willyOne == 1) && (willyTwo == 1))
                            {
                                lblmessage.Text = "恭喜您!中了普獎!";
                            }
                            if ((willyOne == 2) && (willyTwo == 0))
                            {
                                lblmessage.Text = "不好意思!沒有中獎!";
                            }
                            if ((willyOne == 1) && (willyTwo == 0))
                            {
                                lblmessage.Text = "不好意思!沒有中獎!";
                            }
                            if ((willyOne == 0) && (willyTwo == 0))
                            {
                                lblmessage.Text = "不好意思!沒有中獎!";
                            }
                            if ((willyOne == 0) && (willyTwo == 1))
                            {
                                lblmessage.Text = "不好意思!沒有中獎!";
                            }

                        }   
                        else
                        {
                            lblmessage.Text = "請選擇第二區號碼~才能對獎!";
                        }
                    }
                    else
                    {//1 表示有0  陣列沒放滿6個
                        lblmessage.Text = "第一區要6個號碼~才能對獎!";
                    }
            }
            else
            {
                lblmessage.Text = "請先產生威力彩號碼~才能對獎!";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn539開獎_Click(object sender, EventArgs e)
        {
            今彩539開獎();
            DataTable myDb539 = willyDataSet.Tables["539"];
            DataRow myDb539Row = myDb539.NewRow();
            myDb539Row["今彩539號碼"] = tb53901.Text + " , " + tb53902.Text + " , " + tb53903.Text + " , "+
                                            tb53904.Text + " , " + tb53905.Text;

            myDb539.Rows.Add(myDb539Row);
        }

        private void btn539重新_Click(object sender, EventArgs e)
        {
            lbl539選號.Text = "";
            
            tb53901.Text = "";
            tb53902.Text = "";
            tb53903.Text = "";
            tb53904.Text = "";
            tb53905.Text = "";
            
            lbl539訊息.Text = "";
            user539num = new int[5] { 0, 0, 0, 0, 0};

            for (int i = 0; i < myButtonList3.Count; i++)
            {
                Button btn539Ball = (Button)myButtonList3[i];
                btn539Ball.BackColor = Color.Yellow;
            }

           
        }

        private void btn539兌獎_Click(object sender, EventArgs e)
        {
            int checknum2 = 0;
            int Happy539 = 0; 


            if (tb53901.Text != "")
            {
                for (int i = 0; i < user539num.Count(); i++)
                {

                    if (user539num[i] == 0)
                        checknum2 = 1;
                }
                if (checknum2 == 0)
                {                   
                   for (int x = 0; x < num539.Length; x++)
                   {
                      for (int y = 0; y < user539num.Length; y++)
                      {
                          if (num539[x] == user539num[y])
                          {
                                    Happy539 += 1;
                          }
                      }
                   }
                    
                    if (Happy539 == 5)
                        lbl539訊息.Text = "恭喜您!中了頭獎!";
                    if (Happy539 == 4)
                        lbl539訊息.Text = "恭喜您!中了貳獎!";
                    if (Happy539 == 3)
                        lbl539訊息.Text = "恭喜您!中了參獎!";
                    if (Happy539 == 2)
                        lbl539訊息.Text = "恭喜您!中了肆獎!";
                    if (Happy539 == 1 || Happy539 == 0)
                        lbl539訊息.Text = "不好意思!沒有中獎!";                    

                }
                else
                {
                    lbl539訊息.Text = "必須選5個號碼，才能對獎!";
                }
            }
                else
                {
                    lbl539訊息.Text = "請先產生539號碼~才能對獎!";
                }

        }

        private void gb539號碼_Enter(object sender, EventArgs e)
        {

        }
        void btn539_click(object sender, EventArgs e)
        {
            Button my539Button = (Button)sender;


            int A3 = int.Parse(my539Button.Text);

            if (user539num[0] == 0 && (my539Button.BackColor == Color.Yellow))
            {
                user539num[0] = A3;
                lbl539選號.Text += my539Button.Text + ",";
                my539Button.BackColor = Color.Red;
            }
            else if (user539num[0] != 0 && user539num[1] == 0 && (my539Button.BackColor == Color.Yellow))
            {
                user539num[1] = A3;
                lbl539選號.Text += my539Button.Text + ",";
                my539Button.BackColor = Color.Red;
            }
            else if (user539num[0] != 0 && user539num[1] != 0 && user539num[2] == 0 && (my539Button.BackColor == Color.Yellow))
            {
                user539num[2] = A3;
                lbl539選號.Text += my539Button.Text + ",";
                my539Button.BackColor = Color.Red;
            }
            else if (user539num[0] != 0 && user539num[1] != 0 && user539num[2] != 0 && user539num[3] == 0 && my539Button.BackColor == Color.Yellow)
            {
                user539num[3] = A3;
                lbl539選號.Text += my539Button.Text + ",";
                my539Button.BackColor = Color.Red;
            }
            else if (user539num[0] != 0 && user539num[1] != 0 && user539num[2] != 0 && user539num[3] != 0 && user539num[4] == 0 && (my539Button.BackColor == Color.Yellow))
            {
                user539num[4] = A3;
                lbl539選號.Text += my539Button.Text + ",";
                my539Button.BackColor = Color.Red;
            }
           
        }
        void btn539ball(int counst, int counst2)//動態產生第一區btn
        {

            int f = 0;
            for (int i = 0; i <= counst2; i++)
            {
                for (int j = 0; j <= counst; j += 1)
                {
                    f += 1;
                    if (f < 40)
                    {
                        Button btn539Ball = new Button();
                        btn539Ball.BackColor = Color.Yellow;
                        btn539Ball.ForeColor = Color.Black;
                        btn539Ball.Location = new Point(19 + 29 * j, 19 + 29 * i);
                        btn539Ball.Size = new Size(30, 20);
                        btn539Ball.Font = new Font("微軟正黑體", 8);
                        btn539Ball.Text = string.Format("{0}", f);
                        btn539Ball.Visible = true;
                        btn539Ball.TextAlign = ContentAlignment.MiddleCenter;
                        btn539Ball.Name = "btn" + i.ToString();
                        btn539Ball.Click += new EventHandler(btn539_click);
                        gb539號碼.Controls.Add(btn539Ball);
                        myButtonList3.Add(btn539Ball);
                    }

                }

            }
        }
        void 今彩539開獎()
        {
            
            int[] 今彩539 = new int[40];
            for (int i = 0; i <= 39; i++)
            {
                今彩539[i] = i;
            }
            //宣告要取多少個數字
            Random r = new Random();//Random隨機取值

            for (int j = 0; j <= num539.Length - 1; j++)
            {
                int temp = r.Next(1, 40);//產生不同的範圍內的隨機數字，請使用 Random.Next(Int32, Int32) 方法多載。
                if (今彩539[temp] == 0) { j--; }
                else
                {
                    num539[j] = 今彩539[temp];

                    今彩539[temp] = 0; //將以使用之數字以零取代


                }
            }
            Array.Sort(num539);
            tb53901.Text = string.Format("{0:D2}", num539[0]);
            tb53902.Text = string.Format("{0:D2}", num539[1]);
            tb53903.Text = string.Format("{0:D2}", num539[2]);
            tb53904.Text = string.Format("{0:D2}", num539[3]);
            tb53905.Text = string.Format("{0:D2}", num539[4]);
            
        }

        private void willyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.willyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.willyDataSet);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void willyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void willyBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
