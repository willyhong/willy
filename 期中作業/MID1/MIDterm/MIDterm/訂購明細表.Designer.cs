namespace MIDterm
{
    partial class 訂購明細表
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordernumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordeqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.midtermDataSet1 = new MIDterm.midtermDataSet();
            this.orderdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midtermDataSet = new MIDterm.midtermDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_MasterTableAdapter = new MIDterm.midtermDataSetTableAdapters.Order_MasterTableAdapter();
            this.order_detailTableAdapter = new MIDterm.midtermDataSetTableAdapters.Order_detailTableAdapter();
            this.ordernumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordernumDataGridViewTextBoxColumn,
            this.orderitemDataGridViewTextBoxColumn,
            this.stuidDataGridViewTextBoxColumn,
            this.stunameDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.ordeqtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderdetailBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordernumDataGridViewTextBoxColumn
            // 
            this.ordernumDataGridViewTextBoxColumn.DataPropertyName = "Order_num";
            this.ordernumDataGridViewTextBoxColumn.HeaderText = "Order_num";
            this.ordernumDataGridViewTextBoxColumn.Name = "ordernumDataGridViewTextBoxColumn";
            // 
            // orderitemDataGridViewTextBoxColumn
            // 
            this.orderitemDataGridViewTextBoxColumn.DataPropertyName = "Order_item";
            this.orderitemDataGridViewTextBoxColumn.HeaderText = "Order_item";
            this.orderitemDataGridViewTextBoxColumn.Name = "orderitemDataGridViewTextBoxColumn";
            // 
            // stuidDataGridViewTextBoxColumn
            // 
            this.stuidDataGridViewTextBoxColumn.DataPropertyName = "Stu_id";
            this.stuidDataGridViewTextBoxColumn.HeaderText = "Stu_id";
            this.stuidDataGridViewTextBoxColumn.Name = "stuidDataGridViewTextBoxColumn";
            // 
            // stunameDataGridViewTextBoxColumn
            // 
            this.stunameDataGridViewTextBoxColumn.DataPropertyName = "Stu_name";
            this.stunameDataGridViewTextBoxColumn.HeaderText = "Stu_name";
            this.stunameDataGridViewTextBoxColumn.Name = "stunameDataGridViewTextBoxColumn";
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "Product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "Product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "Product_price";
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            // 
            // ordeqtyDataGridViewTextBoxColumn
            // 
            this.ordeqtyDataGridViewTextBoxColumn.DataPropertyName = "Orde_qty";
            this.ordeqtyDataGridViewTextBoxColumn.HeaderText = "Orde_qty";
            this.ordeqtyDataGridViewTextBoxColumn.Name = "ordeqtyDataGridViewTextBoxColumn";
            // 
            // orderdetailBindingSource1
            // 
            this.orderdetailBindingSource1.DataMember = "Order_detail";
            this.orderdetailBindingSource1.DataSource = this.midtermDataSet1;
            // 
            // midtermDataSet1
            // 
            this.midtermDataSet1.DataSetName = "midtermDataSet";
            this.midtermDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderdetailBindingSource
            // 
            this.orderdetailBindingSource.DataMember = "Order_detail";
            this.orderdetailBindingSource.DataSource = this.midtermDataSet;
            // 
            // midtermDataSet
            // 
            this.midtermDataSet.DataSetName = "midtermDataSet";
            this.midtermDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordernumDataGridViewTextBoxColumn1,
            this.storeidDataGridViewTextBoxColumn,
            this.storenameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.totalamtDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderMasterBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 255);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(634, 166);
            this.dataGridView2.TabIndex = 1;
            // 
            // orderMasterBindingSource
            // 
            this.orderMasterBindingSource.DataMember = "Order_Master";
            this.orderMasterBindingSource.DataSource = this.midtermDataSet;
            // 
            // order_MasterTableAdapter
            // 
            this.order_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // order_detailTableAdapter
            // 
            this.order_detailTableAdapter.ClearBeforeFill = true;
            // 
            // ordernumDataGridViewTextBoxColumn1
            // 
            this.ordernumDataGridViewTextBoxColumn1.DataPropertyName = "order_num";
            this.ordernumDataGridViewTextBoxColumn1.HeaderText = "order_num";
            this.ordernumDataGridViewTextBoxColumn1.Name = "ordernumDataGridViewTextBoxColumn1";
            // 
            // storeidDataGridViewTextBoxColumn
            // 
            this.storeidDataGridViewTextBoxColumn.DataPropertyName = "Store_id";
            this.storeidDataGridViewTextBoxColumn.HeaderText = "Store_id";
            this.storeidDataGridViewTextBoxColumn.Name = "storeidDataGridViewTextBoxColumn";
            // 
            // storenameDataGridViewTextBoxColumn
            // 
            this.storenameDataGridViewTextBoxColumn.DataPropertyName = "Store_name";
            this.storenameDataGridViewTextBoxColumn.HeaderText = "Store_name";
            this.storenameDataGridViewTextBoxColumn.Name = "storenameDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // totalamtDataGridViewTextBoxColumn
            // 
            this.totalamtDataGridViewTextBoxColumn.DataPropertyName = "total_amt";
            this.totalamtDataGridViewTextBoxColumn.HeaderText = "total_amt";
            this.totalamtDataGridViewTextBoxColumn.Name = "totalamtDataGridViewTextBoxColumn";
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            // 
            // 訂購明細表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(832, 571);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "訂購明細表";
            this.Text = "訂購明細表";
            this.Load += new System.EventHandler(this.訂購明細表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private midtermDataSet midtermDataSet;
        private System.Windows.Forms.BindingSource orderdetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordeqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource orderMasterBindingSource;
        private midtermDataSetTableAdapters.Order_MasterTableAdapter order_MasterTableAdapter;
        private midtermDataSet midtermDataSet1;
        private System.Windows.Forms.BindingSource orderdetailBindingSource1;
        private midtermDataSetTableAdapters.Order_detailTableAdapter order_detailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
    }
}