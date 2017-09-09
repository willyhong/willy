using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDterm
{
    public partial class 維護選項 : Form
    {
        public 維護選項()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           店家基本資料  myform基本 = new 店家基本資料();
            myform基本.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            店家商品新增 myform新增 = new 店家商品新增();
            myform新增.Show();
            this.Hide();
        }
    }
}
