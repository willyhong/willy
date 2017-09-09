namespace MIDterm
{
    partial class 店家商品新增
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
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn結束 = new System.Windows.Forms.Button();
            this.cb店家 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnadd.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnadd.Location = new System.Drawing.Point(45, 416);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(86, 77);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "新增與刪除";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "店家:";
            // 
            // btn結束
            // 
            this.btn結束.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn結束.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結束.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn結束.Location = new System.Drawing.Point(490, 499);
            this.btn結束.Name = "btn結束";
            this.btn結束.Size = new System.Drawing.Size(133, 44);
            this.btn結束.TabIndex = 11;
            this.btn結束.Text = "結束程式";
            this.btn結束.UseVisualStyleBackColor = false;
            this.btn結束.Click += new System.EventHandler(this.btn結束_Click);
            // 
            // cb店家
            // 
            this.cb店家.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cb店家.FormattingEnabled = true;
            this.cb店家.Location = new System.Drawing.Point(187, 51);
            this.cb店家.Name = "cb店家";
            this.cb店家.Size = new System.Drawing.Size(144, 20);
            this.cb店家.TabIndex = 13;
            this.cb店家.SelectedIndexChanged += new System.EventHandler(this.cb店家_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(321, 235);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // 店家商品新增
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(635, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb店家);
            this.Controls.Add(this.btn結束);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "店家商品新增";
            this.Text = "店家商品新增";
            this.Load += new System.EventHandler(this.店家商品新增_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn結束;
        private System.Windows.Forms.ComboBox cb店家;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}