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
    public partial class 店家資訊 : Form
    {
        public 店家資訊()
        {
            InitializeComponent();
        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            訂購單 myform訂購 = new 訂購單();
            myform訂購.Show();
            this.Hide();
        }
    }
}
