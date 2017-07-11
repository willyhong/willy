using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訂購單0323
{
    public partial class Form1 : Form
    {
        //Calss 類別變數;
        int 杯數1 = 0, 杯數2 = 0, 杯數3 = 0, 杯數4 = 0, 杯數5 = 0;
        int 總杯數 = 0;
        int 折扣杯數 = 0;
        float 售價1 = 0.0f, 售價2 = 0.0f, 售價3 = 0.0f, 售價4 = 0.0f, 售價5 = 0.0f;
        float 品項1總價 = 0.0f, 品項2總價 = 0.0f, 品項3總價 = 0.0f, 品項4總價 = 0.0f, 品項5總價 = 0.0f;
        float 折數 = 0.0f;
        float 總價 = 0.0f;
        float 折扣後總價 = 0.0f;

        float 買二送一1 = 0.0f;
        float 買二送一2 = 0.0f;
        float 買二送一3 = 0.0f;
        float 買二送一4 = 0.0f;
        float 買二送一5 = 0.0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl品項1.Text = "麥香紅茶";
            lbl品項2.Text = "茉莉綠茶";
            lbl品項3.Text = "珍珠奶茶";
            lbl品項4.Text = "玫瑰花茶";
            lbl品項5.Text = "現打西瓜汁";

            售價1 = 35.0f;
            售價2 = 40.0f;
            售價3 = 45.0f;
            售價4 = 50.0f;
            售價5 = 55.0f;


            lbl售價1.Text = 售價1.ToString();
            lbl售價2.Text = 售價2.ToString();
            lbl售價3.Text = 售價3.ToString();
            lbl售價4.Text = 售價4.ToString();
            lbl售價5.Text = 售價5.ToString();

            折數 = 10.0f; // 買二送一用於數 //買一送一 //不同價送便宜
            btn訂單.BackColor = Color.Pink;
        }

        private void btn杯數1減_Click(object sender, EventArgs e)
        {
            杯數1 -= 1;
            if (杯數1 < 0)
            {
                杯數1 = 0;
                btn杯數1減.Enabled = false;
                //設定按鈕到0 就不能再按
            }

            tb杯數1.Text = 杯數1.ToString();
        }

        private void btn杯數1加_Click(object sender, EventArgs e)
        {
            杯數1 += 1;
            btn杯數1加.Enabled = true;
            tb杯數1.Text = 杯數1.ToString();
        }

        private void tb杯數1_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數1.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tb杯數1.Text, out 杯數1);
                if (ifNum && 杯數1 >= 0)
                {
                    //正確輸入;
                    btn杯數1減.Enabled = true;//可以有0杯
                    btn買一送一.Enabled = true;
                    btn買二送一.Enabled = true;

                }
                else
                {
                    //錯誤輸入//只能有整數0 不能有小數點OR其他文字;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb杯數1.Text = "0";
                    杯數1 = 0;
                }

            }
            else
            {
                杯數1 = 0;
            }
            計算總價();
            
        }

        private void btn杯數2減_Click(object sender, EventArgs e)
        {
            杯數2 -= 1;
            if (杯數2 < 0)
            {
                杯數2 = 0;
                btn杯數2減.Enabled = false;//設定按鈕到0 就不能再按
            }
            tb杯數2.Text = 杯數2.ToString();
        }

        private void btn杯數2加_Click(object sender, EventArgs e)
        {
            杯數2 += 1;
            btn杯數2加.Enabled = true;
            tb杯數2.Text = 杯數2.ToString();
        }

        private void tb杯數2_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數2.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tb杯數2.Text, out 杯數2);
                if (ifNum && 杯數2 >= 0)
                {
                    //正確輸入;
                    btn杯數2減.Enabled = true;//可以有0杯
                    btn買一送一.Enabled = true;
                    btn買二送一.Enabled = true;

                }
                else
                {
                    //錯誤輸入//只能有整數0 不能有小數點OR其他文字;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb杯數2.Text = "0";
                    杯數2 = 0;
                }

            }
            else
            {
                杯數2 = 0;
            }
            計算總價();
        }


        private void btn杯數3減_Click(object sender, EventArgs e)
        {
            杯數3 -= 1;
            if (杯數3 < 0)
            {
                杯數3 = 0;
                btn杯數3減.Enabled = false;//設定按鈕到0 就不能再按
            }
            tb杯數3.Text = 杯數3.ToString();
        }


        private void btn杯數3加_Click(object sender, EventArgs e)
        {
            杯數3 += 1;
            btn杯數3加.Enabled = true;
            tb杯數3.Text = 杯數3.ToString();
        }

        private void tb杯數3_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數3.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tb杯數3.Text, out 杯數3);
                if (ifNum && 杯數3 >= 0)
                {
                    //正確輸入;
                    btn杯數3減.Enabled = true;//可以有0杯
                    btn買一送一.Enabled = true;
                    btn買二送一.Enabled = true;

                }
                else
                {
                    //錯誤輸入//只能有整數0 不能有小數點OR其他文字;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb杯數3.Text = "0";
                    杯數3 = 0;
                }

            }
            else
            {
                杯數3 = 0;
            }
            計算總價();
        }

        private void btn買二送一_Click(object sender, EventArgs e)
        {
            btn買一送一.Enabled = false;

            買二送一();





        }

        private void btn買一送一_Click_1(object sender, EventArgs e)
        {
            btn買二送一.Enabled = false;
            if ((tb杯數1.Text.Length > 0) || (tb杯數2.Text.Length > 0) || (tb杯數3.Text.Length > 0) ||
                (tb杯數4.Text.Length > 0) || (tb杯數5.Text.Length > 0))
            {
                if ((tb杯數1.Text.Length > 0) && (tb杯數2.Text.Length == 0) && (tb杯數3.Text.Length == 0) &&
                    (tb杯數4.Text.Length == 0) && (tb杯數5.Text.Length == 0))
                {
                    計算總價();
                }
                if ((tb杯數1.Text.Length == 0) && (tb杯數2.Text.Length > 0) && (tb杯數3.Text.Length == 0) &&
                    (tb杯數4.Text.Length == 0) && (tb杯數5.Text.Length == 0))
                {
                    計算總價();
                }
                if ((tb杯數1.Text.Length == 0) && (tb杯數2.Text.Length == 0) && (tb杯數3.Text.Length > 0) &&
                   (tb杯數4.Text.Length == 0) && (tb杯數5.Text.Length == 0))
                {
                    計算總價();
                }
                if ((tb杯數1.Text.Length == 0) && (tb杯數2.Text.Length == 0) && (tb杯數3.Text.Length == 0) &&
                   (tb杯數4.Text.Length > 0) && (tb杯數5.Text.Length == 0))
                {
                    計算總價();
                }
                if ((tb杯數1.Text.Length == 0) && (tb杯數2.Text.Length == 0) && (tb杯數3.Text.Length == 0) &&
                   (tb杯數4.Text.Length == 0) && (tb杯數5.Text.Length > 0))
                {
                    計算總價();
                }
            }
            else
            {

                不同品項買一送一();
            }
        }
        private void btn杯數4減_Click(object sender, EventArgs e)
        {
            杯數4 -= 1;
            if (杯數4 < 0)
            {
                杯數4 = 0;
                btn杯數4減.Enabled = false;//設定按鈕到0 就不能再按
            }

            tb杯數4.Text = 杯數4.ToString();
        }





        private void btn杯數4加_Click(object sender, EventArgs e)
        {
            杯數4 += 1;
            btn杯數4加.Enabled = true;
            tb杯數4.Text = 杯數4.ToString();




        }

        private void tb杯數4_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數4.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tb杯數4.Text, out 杯數4);
                if (ifNum && 杯數4 >= 0)
                {
                    //正確輸入;
                    btn杯數4減.Enabled = true;
                    btn買一送一.Enabled = true;
                    btn買二送一.Enabled = true;//可以有0杯

                }
                else
                {
                    //錯誤輸入//只能有整數0 不能有小數點OR其他文字;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb杯數4.Text = "0";
                    杯數4 = 0;
                }

            }
            else
            {
                杯數4 = 0;
            }
            計算總價();
        }

        private void btn杯數5減_Click(object sender, EventArgs e)
        {
            杯數5 -= 1;
            if (杯數5 < 0)
            {
                杯數5 = 0;
                btn杯數5減.Enabled = false;//設定按鈕到0 就不能再按
            }
            tb杯數5.Text = 杯數5.ToString();
        }

        private void btn杯數5加_Click(object sender, EventArgs e)
        {
            杯數5 += 1;
            btn杯數5加.Enabled = true;
            tb杯數5.Text = 杯數5.ToString();
        }

        private void tb杯數5_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數5.Text.Length > 0)
            {
                bool ifNum = Int32.TryParse(tb杯數5.Text, out 杯數5);
                if (ifNum && 杯數5 >= 0)
                {
                    //正確輸入;
                    btn杯數5減.Enabled = true;//可以有0杯
                    btn買一送一.Enabled = true;
                    btn買二送一.Enabled = true;

                }
                else
                {
                    //錯誤輸入//只能有整數0 不能有小數點OR其他文字;
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb杯數5.Text = "0";
                    杯數5 = 0;
                }

            }
            else
            {
                杯數5 = 0;
            }
            計算總價();
        }

        private void tb折數_TextChanged(object sender, EventArgs e)
        {
            if (tb折數.Text.Length > 0)
            {
                bool ifNum = float.TryParse(tb折數.Text, out 折數);
                if (ifNum == true)
                {
                    if ((折數 >= 0.0f) && (折數 <= 10.0f))
                    {
                        btn買一送一.Enabled = false;
                        btn買二送一.Enabled = false;//合理折數
                    }
                    else
                    {
                        MessageBox.Show("折數輸入錯誤(0.0~10.0)");
                        tb折數.Text = "";
                        折數 = 10.0f;
                    }
                }
                else
                {
                    MessageBox.Show("折數輸入錯誤(0.0~10.0)");
                    tb折數.Text = "";
                    折數 = 10.0f;
                }
            }
            else
            {
                折數 = 10.0f;
            }
            計算總價();
        }



        private void btn訂單_Click(object sender, EventArgs e)
        {
            //對話框 messagebox 會對話
            DialogResult drResult;//紀錄對話框選擇回傳訊息
            drResult = MessageBox.Show("您確認送出訂單嗎?", "訂單確認",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drResult == DialogResult.No)//區分YES.NO
            {
                //取消
            }
            else
            {
                //確認;
                string strOrderList = "********* III冷飲店訂購單 *********";
                strOrderList += "-------------------------------------------\n";
                if (杯數1 > 0)
                {
                    strOrderList += lbl品項1.Text + ":" + lbl售價1.Text + "x" +
                    tb杯數1.Text + "=" + 品項1總價.ToString() + "\n";
                }





                if (杯數2 > 0)
                {
                    strOrderList += lbl品項2.Text + ":" + lbl售價2.Text + "x" +
                    tb杯數2.Text + "=" + 品項2總價.ToString() + "\n";
                }
                if (杯數3 > 0)
                {
                    strOrderList += lbl品項3.Text + ":" + lbl售價3.Text + "x" +
                    tb杯數3.Text + "=" + 品項3總價.ToString() + "\n";
                }
                if (杯數4 > 0)
                {
                    strOrderList += lbl品項4.Text + ":" + lbl售價4.Text + "x" +
                    tb杯數4.Text + "=" + 品項4總價.ToString() + "\n";
                }
                if (杯數5 > 0)
                {
                    strOrderList += lbl品項5.Text + ":" + lbl售價5.Text + "x" +
                    tb杯數5.Text + "=" + 品項5總價.ToString() + "\n";
                }

                strOrderList += "-----------------------------------------\n";
                if (折數 < 10.0f)
                {
                    strOrderList += "折數" + string.Format("{0:F2}", 折數 + "\n");

                }

                strOrderList += "訂單總價:" + string.Format("{0:C}", 總價 + "\n");
                strOrderList += "折扣後總數:" + string.Format("{0:C}", 折扣後總價 + "\n");
                strOrderList += string.Format("{0:D}", DateTime.Now + "\n");
                strOrderList += string.Format("{0:T}", DateTime.Now + "\n");
                MessageBox.Show(strOrderList, "訂單明細", MessageBoxButtons.OK);
            }

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        void 計算總價()
        {
            品項1總價 = 售價1 * 杯數1;
            品項2總價 = 售價2 * 杯數2;
            品項3總價 = 售價3 * 杯數3;
            品項4總價 = 售價4 * 杯數4;
            品項5總價 = 售價5 * 杯數5;

            總價 = 品項1總價 + 品項2總價 + 品項3總價 + 品項4總價 + 品項5總價;
            折扣後總價 = 總價 * 折數 / 10.0f;

            lbl總價.Text = lbl總價.Text = string.Format("{0:C}", 買二送一1);
            lbl總價.Text = string.Format("{0:C}", 總價);
            lbl折扣後總價.Text = string.Format("{0:C}", 折扣後總價);

        }
        void 買二送一()
        {
            品項1總價 = 售價1 * 杯數1;
            品項2總價 = 售價2 * 杯數2;
            品項3總價 = 售價3 * 杯數3;
            品項4總價 = 售價4 * 杯數4;
            品項5總價 = 售價5 * 杯數5;

            買二送一1 = 品項1總價 - ((杯數1 / 3) * 售價1);
            買二送一2 = 品項2總價 - ((杯數2 / 3) * 售價2);
            買二送一3 = 品項3總價 - ((杯數3 / 3) * 售價3);
            買二送一4 = 品項4總價 - ((杯數4 / 3) * 售價4);
            買二送一5 = 品項5總價 - ((杯數5 / 3) * 售價5);

            折扣後總價 = 買二送一1 + 買二送一2 + 買二送一3 + 買二送一4 + 買二送一5;


            lbl折扣後總價.Text = string.Format("{0:C}", 折扣後總價);

        }


        void 不同品項買一送一()
        {
            品項1總價 = 售價1 * 杯數1;
            品項2總價 = 售價2 * 杯數2;
            品項3總價 = 售價3 * 杯數3;
            品項4總價 = 售價4 * 杯數4;
            品項5總價 = 售價5 * 杯數5;
            總價 = 品項1總價 + 品項2總價 + 品項3總價 + 品項4總價 + 品項5總價;

            總杯數 = 杯數1 + 杯數2 + 杯數3 + 杯數4 + 杯數5;
            折扣杯數 = 總杯數 / 2;
            
            if (杯數1 > 0)
            {
                if (折扣杯數 >= 杯數1)
                {

                    折扣杯數 -= 杯數1;
                    杯數1 = 0;
                }
                else
                {
                    杯數1 -= 折扣杯數;
                    折扣杯數 = 0;
                }
                
            }
            if ((杯數2 > 0) && (折扣杯數 > 0))
            {

                if (杯數2 > 折扣杯數)
                {
                    杯數2 -= 折扣杯數;
                    杯數2 = 0;
                }
                else
                {
                    折扣杯數 -= 杯數2;
                    折扣杯數 = 0;
                }
                
            }
            if ((杯數3 > 0) && (折扣杯數 > 0))
            {

                if (杯數3 > 折扣杯數)
                {
                    杯數3 -= 折扣杯數;
                    杯數3 = 0;
                }
                else
                {
                    折扣杯數 -= 杯數3;
                    折扣杯數 = 0;
                }
                
            }
            if ((杯數4 > 0) && (折扣杯數 > 0))
            {

                if (杯數4 > 折扣杯數)
                {
                    杯數4 -= 折扣杯數;
                    杯數4 = 0;
                }
                else
                {
                    折扣杯數 -= 杯數4;
                    折扣杯數 = 0;
                }
               
            }
            if ((杯數5 > 0) && (折扣杯數 > 0))
            {

                if (杯數5 > 折扣杯數)
                {
                    杯數5 -= 折扣杯數;
                    杯數5 = 0;
                }
                else
                {
                    折扣杯數 -= 杯數5;
                    折扣杯數 = 0;
                }
                
            }

            lbl折扣後總價.Text = string.Format("{0:C}", 折扣後總價);



        }         
    }
}
