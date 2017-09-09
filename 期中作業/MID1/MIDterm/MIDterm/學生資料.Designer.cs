namespace MIDterm
{
    partial class 學生資料
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
            this.cbclass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn增刪減 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btn返回 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbclass
            // 
            this.cbclass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbclass.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbclass.FormattingEnabled = true;
            this.cbclass.Location = new System.Drawing.Point(274, 53);
            this.cbclass.Name = "cbclass";
            this.cbclass.Size = new System.Drawing.Size(149, 24);
            this.cbclass.TabIndex = 0;
            this.cbclass.SelectedIndexChanged += new System.EventHandler(this.cbclass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(166, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "期數:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 239);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn增刪減
            // 
            this.btn增刪減.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn增刪減.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn增刪減.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn增刪減.Location = new System.Drawing.Point(42, 260);
            this.btn增刪減.Name = "btn增刪減";
            this.btn增刪減.Size = new System.Drawing.Size(92, 62);
            this.btn增刪減.TabIndex = 3;
            this.btn增刪減.Text = "新增刪除資料";
            this.btn增刪減.UseVisualStyleBackColor = false;
            this.btn增刪減.Click += new System.EventHandler(this.btn增刪減_Click);
            // 
            // btn新增
            // 
            this.btn新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn新增.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn新增.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(42, 335);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(92, 56);
            this.btn新增.TabIndex = 18;
            this.btn新增.Text = "修改";
            this.btn新增.UseVisualStyleBackColor = false;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // btn返回
            // 
            this.btn返回.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn返回.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn返回.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn返回.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn返回.Location = new System.Drawing.Point(561, 347);
            this.btn返回.Name = "btn返回";
            this.btn返回.Size = new System.Drawing.Size(133, 44);
            this.btn返回.TabIndex = 23;
            this.btn返回.Text = "返回";
            this.btn返回.UseVisualStyleBackColor = false;
            this.btn返回.Click += new System.EventHandler(this.btn返回_Click);
            // 
            // 學生資料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(706, 403);
            this.Controls.Add(this.btn返回);
            this.Controls.Add(this.btn新增);
            this.Controls.Add(this.btn增刪減);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbclass);
            this.Name = "學生資料";
            this.Text = "學生資料";
            this.Load += new System.EventHandler(this.學生資料_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbclass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn增刪減;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn返回;
    }
}