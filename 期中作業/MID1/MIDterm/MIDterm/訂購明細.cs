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
    public partial class 訂購明細 : Form
    {
        public 訂購明細()
        {
            InitializeComponent();
        }

        private void orderlistBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderlistBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.midtermDataSet);

        }

        private void 訂購明細_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'midtermDataSet.Orderlist' 資料表。您可以視需要進行移動或移除。
            this.orderlistTableAdapter.Fill(this.midtermDataSet.Orderlist);

        }
    }
}
