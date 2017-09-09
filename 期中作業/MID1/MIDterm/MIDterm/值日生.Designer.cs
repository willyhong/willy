namespace MIDterm
{
    partial class 值日生
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn未付款 = new System.Windows.Forms.Button();
            this.cbclass = new System.Windows.Forms.ComboBox();
            this.btn清除 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(482, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn未付款
            // 
            this.btn未付款.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn未付款.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn未付款.Location = new System.Drawing.Point(366, 357);
            this.btn未付款.Name = "btn未付款";
            this.btn未付款.Size = new System.Drawing.Size(114, 48);
            this.btn未付款.TabIndex = 1;
            this.btn未付款.Text = "未付款";
            this.btn未付款.UseVisualStyleBackColor = false;
            this.btn未付款.Click += new System.EventHandler(this.btn未付款_Click);
            // 
            // cbclass
            // 
            this.cbclass.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbclass.FormattingEnabled = true;
            this.cbclass.Location = new System.Drawing.Point(37, 25);
            this.cbclass.Name = "cbclass";
            this.cbclass.Size = new System.Drawing.Size(50, 24);
            this.cbclass.TabIndex = 2;
            this.cbclass.SelectedIndexChanged += new System.EventHandler(this.cbclass_SelectedIndexChanged);
            // 
            // btn清除
            // 
            this.btn清除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn清除.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除.Location = new System.Drawing.Point(23, 357);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(114, 48);
            this.btn清除.TabIndex = 3;
            this.btn清除.Text = "刪除今日訂單";
            this.btn清除.UseVisualStyleBackColor = false;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // 值日生
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(532, 432);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.cbclass);
            this.Controls.Add(this.btn未付款);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "值日生";
            this.Text = "值日生";
            this.Load += new System.EventHandler(this.值日生_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn未付款;
        private System.Windows.Forms.ComboBox cbclass;
        private System.Windows.Forms.Button btn清除;
    }
}