namespace MIDterm
{
    partial class 訂購明細
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
            this.midtermDataSet = new MIDterm.midtermDataSet();
            this.orderlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderlistTableAdapter = new MIDterm.midtermDataSetTableAdapters.OrderlistTableAdapter();
            this.tableAdapterManager = new MIDterm.midtermDataSetTableAdapters.TableAdapterManager();
            this.orderlistDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.midtermDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // midtermDataSet
            // 
            this.midtermDataSet.DataSetName = "midtermDataSet";
            this.midtermDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderlistBindingSource
            // 
            this.orderlistBindingSource.DataMember = "Orderlist";
            this.orderlistBindingSource.DataSource = this.midtermDataSet;
            // 
            // orderlistTableAdapter
            // 
            this.orderlistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderlistTableAdapter = this.orderlistTableAdapter;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MIDterm.midtermDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.悟饕StoreComTableAdapter = null;
            this.tableAdapterManager.正宗StoreComTableAdapter = null;
            // 
            // orderlistDataGridView
            // 
            this.orderlistDataGridView.AutoGenerateColumns = false;
            this.orderlistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderlistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.orderlistDataGridView.DataSource = this.orderlistBindingSource;
            this.orderlistDataGridView.Location = new System.Drawing.Point(12, 12);
            this.orderlistDataGridView.Name = "orderlistDataGridView";
            this.orderlistDataGridView.RowTemplate.Height = 24;
            this.orderlistDataGridView.Size = new System.Drawing.Size(942, 205);
            this.orderlistDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Order_num";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order_num";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Order_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order_date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Class_np";
            this.dataGridViewTextBoxColumn3.HeaderText = "Class_np";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Store_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Store_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Stu_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Stu_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Com_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Com_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Com_Nam";
            this.dataGridViewTextBoxColumn7.HeaderText = "Com_Nam";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Com_price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Com_price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Order_Qty";
            this.dataGridViewTextBoxColumn9.HeaderText = "Order_Qty";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // 訂購明細
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(977, 294);
            this.Controls.Add(this.orderlistDataGridView);
            this.Name = "訂購明細";
            this.Text = "訂購明細";
            this.Load += new System.EventHandler(this.訂購明細_Load);
            ((System.ComponentModel.ISupportInitialize)(this.midtermDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private midtermDataSet midtermDataSet;
        private System.Windows.Forms.BindingSource orderlistBindingSource;
        private midtermDataSetTableAdapters.OrderlistTableAdapter orderlistTableAdapter;
        private midtermDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView orderlistDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}