namespace MIDterm
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb訂購總數 = new System.Windows.Forms.TextBox();
            this.tb總價 = new System.Windows.Forms.TextBox();
            this.tb店家地址 = new System.Windows.Forms.TextBox();
            this.tb店家名稱 = new System.Windows.Forms.TextBox();
            this.tb店家電話 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btn確認 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbclass = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.tb值日生 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "期數:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "訂購日期:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(284, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "店家電話:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "店家名稱:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(13, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "總價:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "訂購總數:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(2, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "訂購商品:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(2, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 28);
            this.label10.TabIndex = 10;
            this.label10.Text = "店家地址:";
            // 
            // tb訂購總數
            // 
            this.tb訂購總數.Enabled = false;
            this.tb訂購總數.Location = new System.Drawing.Point(129, 488);
            this.tb訂購總數.Name = "tb訂購總數";
            this.tb訂購總數.Size = new System.Drawing.Size(126, 30);
            this.tb訂購總數.TabIndex = 12;
            // 
            // tb總價
            // 
            this.tb總價.Enabled = false;
            this.tb總價.Location = new System.Drawing.Point(129, 535);
            this.tb總價.Name = "tb總價";
            this.tb總價.Size = new System.Drawing.Size(126, 30);
            this.tb總價.TabIndex = 13;
            this.tb總價.TextChanged += new System.EventHandler(this.tb總價_TextChanged);
            // 
            // tb店家地址
            // 
            this.tb店家地址.Enabled = false;
            this.tb店家地址.Location = new System.Drawing.Point(125, 136);
            this.tb店家地址.Name = "tb店家地址";
            this.tb店家地址.Size = new System.Drawing.Size(513, 30);
            this.tb店家地址.TabIndex = 14;
            // 
            // tb店家名稱
            // 
            this.tb店家名稱.Enabled = false;
            this.tb店家名稱.Location = new System.Drawing.Point(125, 91);
            this.tb店家名稱.Name = "tb店家名稱";
            this.tb店家名稱.Size = new System.Drawing.Size(126, 30);
            this.tb店家名稱.TabIndex = 15;
            // 
            // tb店家電話
            // 
            this.tb店家電話.Enabled = false;
            this.tb店家電話.Location = new System.Drawing.Point(407, 91);
            this.tb店家電話.Name = "tb店家電話";
            this.tb店家電話.Size = new System.Drawing.Size(172, 30);
            this.tb店家電話.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(407, 7);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(172, 30);
            this.textBox7.TabIndex = 18;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btn確認
            // 
            this.btn確認.BackColor = System.Drawing.Color.Navy;
            this.btn確認.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn確認.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn確認.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn確認.Location = new System.Drawing.Point(602, 512);
            this.btn確認.Name = "btn確認";
            this.btn確認.Size = new System.Drawing.Size(151, 41);
            this.btn確認.TabIndex = 19;
            this.btn確認.Text = "確認";
            this.btn確認.UseVisualStyleBackColor = false;
            this.btn確認.Click += new System.EventHandler(this.btn確認_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 259);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbclass
            // 
            this.cbclass.BackColor = System.Drawing.Color.White;
            this.cbclass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbclass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbclass.FormattingEnabled = true;
            this.cbclass.Location = new System.Drawing.Point(125, 9);
            this.cbclass.Name = "cbclass";
            this.cbclass.Size = new System.Drawing.Size(121, 27);
            this.cbclass.TabIndex = 23;
            this.cbclass.SelectedIndexChanged += new System.EventHandler(this.cbclass_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(3, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "值日生:";
            // 
            // tb值日生
            // 
            this.tb值日生.Enabled = false;
            this.tb值日生.Location = new System.Drawing.Point(125, 47);
            this.tb值日生.Name = "tb值日生";
            this.tb值日生.Size = new System.Drawing.Size(126, 30);
            this.tb值日生.TabIndex = 25;
            this.tb值日生.TextChanged += new System.EventHandler(this.tb值日生_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(765, 565);
            this.Controls.Add(this.tb值日生);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbclass);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn確認);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tb店家電話);
            this.Controls.Add(this.tb店家名稱);
            this.Controls.Add(this.tb店家地址);
            this.Controls.Add(this.tb總價);
            this.Controls.Add(this.tb訂購總數);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.Text = "櫃台";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb訂購總數;
        private System.Windows.Forms.TextBox tb總價;
        private System.Windows.Forms.TextBox tb店家地址;
        private System.Windows.Forms.TextBox tb店家名稱;
        private System.Windows.Forms.TextBox tb店家電話;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btn確認;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbclass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb值日生;
    }
}