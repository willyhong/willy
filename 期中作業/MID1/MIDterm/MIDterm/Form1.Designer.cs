namespace MIDterm
{
    partial class 訂購單
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl日期 = new System.Windows.Forms.Label();
            this.tb數量 = new System.Windows.Forms.TextBox();
            this.btn減 = new System.Windows.Forms.Button();
            this.btn加 = new System.Windows.Forms.Button();
            this.btn送出訂單 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cb姓名 = new System.Windows.Forms.ComboBox();
            this.cb期數 = new System.Windows.Forms.ComboBox();
            this.tbstoID = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb店家名稱 = new System.Windows.Forms.TextBox();
            this.cb商品名稱 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "期數:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(289, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "日期:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "學生姓名:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "店家代號:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "商品名稱:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "商品價格:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(12, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "訂購個數:";
            // 
            // lbl日期
            // 
            this.lbl日期.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl日期.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl日期.Location = new System.Drawing.Point(362, 19);
            this.lbl日期.Name = "lbl日期";
            this.lbl日期.Size = new System.Drawing.Size(218, 31);
            this.lbl日期.TabIndex = 9;
            this.lbl日期.Click += new System.EventHandler(this.lbl日期_Click);
            // 
            // tb數量
            // 
            this.tb數量.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb數量.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb數量.Location = new System.Drawing.Point(243, 486);
            this.tb數量.Multiline = true;
            this.tb數量.Name = "tb數量";
            this.tb數量.Size = new System.Drawing.Size(57, 38);
            this.tb數量.TabIndex = 15;
            this.tb數量.TextChanged += new System.EventHandler(this.tb數量_TextChanged);
            // 
            // btn減
            // 
            this.btn減.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn減.Location = new System.Drawing.Point(167, 486);
            this.btn減.Name = "btn減";
            this.btn減.Size = new System.Drawing.Size(50, 42);
            this.btn減.TabIndex = 16;
            this.btn減.Text = "-";
            this.btn減.UseVisualStyleBackColor = false;
            this.btn減.Click += new System.EventHandler(this.btn減_Click);
            // 
            // btn加
            // 
            this.btn加.BackColor = System.Drawing.Color.Red;
            this.btn加.Location = new System.Drawing.Point(326, 486);
            this.btn加.Name = "btn加";
            this.btn加.Size = new System.Drawing.Size(50, 42);
            this.btn加.TabIndex = 17;
            this.btn加.Text = "+";
            this.btn加.UseVisualStyleBackColor = false;
            this.btn加.Click += new System.EventHandler(this.btn加_Click);
            // 
            // btn送出訂單
            // 
            this.btn送出訂單.BackColor = System.Drawing.Color.Navy;
            this.btn送出訂單.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn送出訂單.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn送出訂單.Location = new System.Drawing.Point(432, 525);
            this.btn送出訂單.Name = "btn送出訂單";
            this.btn送出訂單.Size = new System.Drawing.Size(149, 42);
            this.btn送出訂單.TabIndex = 18;
            this.btn送出訂單.Text = "送出訂單";
            this.btn送出訂單.UseVisualStyleBackColor = false;
            this.btn送出訂單.Click += new System.EventHandler(this.btn送出訂單_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("標楷體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(415, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 173);
            this.button4.TabIndex = 19;
            this.button4.Text = "查看商品";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cb姓名
            // 
            this.cb姓名.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb姓名.FormattingEnabled = true;
            this.cb姓名.Location = new System.Drawing.Point(169, 221);
            this.cb姓名.Name = "cb姓名";
            this.cb姓名.Size = new System.Drawing.Size(131, 24);
            this.cb姓名.TabIndex = 24;
            this.cb姓名.SelectedIndexChanged += new System.EventHandler(this.cb姓名_SelectedIndexChanged);
            // 
            // cb期數
            // 
            this.cb期數.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb期數.FormattingEnabled = true;
            this.cb期數.Location = new System.Drawing.Point(125, 22);
            this.cb期數.Name = "cb期數";
            this.cb期數.Size = new System.Drawing.Size(68, 24);
            this.cb期數.TabIndex = 25;
            this.cb期數.SelectedIndexChanged += new System.EventHandler(this.cb期數_SelectedIndexChanged);
            // 
            // tbstoID
            // 
            this.tbstoID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbstoID.Location = new System.Drawing.Point(167, 269);
            this.tbstoID.Name = "tbstoID";
            this.tbstoID.Size = new System.Drawing.Size(68, 27);
            this.tbstoID.TabIndex = 26;
            this.tbstoID.TextChanged += new System.EventHandler(this.tbstoID_TextChanged);
            // 
            // tbprice
            // 
            this.tbprice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbprice.Location = new System.Drawing.Point(167, 417);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(50, 27);
            this.tbprice.TabIndex = 27;
            this.tbprice.TextChanged += new System.EventHandler(this.tbprice_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "店家名稱:";
            // 
            // tb店家名稱
            // 
            this.tb店家名稱.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb店家名稱.Location = new System.Drawing.Point(167, 320);
            this.tb店家名稱.Name = "tb店家名稱";
            this.tb店家名稱.Size = new System.Drawing.Size(133, 27);
            this.tb店家名稱.TabIndex = 28;
            this.tb店家名稱.TextChanged += new System.EventHandler(this.tb店家名稱_TextChanged);
            // 
            // cb商品名稱
            // 
            this.cb商品名稱.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb商品名稱.FormattingEnabled = true;
            this.cb商品名稱.Location = new System.Drawing.Point(167, 374);
            this.cb商品名稱.Name = "cb商品名稱";
            this.cb商品名稱.Size = new System.Drawing.Size(158, 24);
            this.cb商品名稱.TabIndex = 29;
            this.cb商品名稱.SelectedIndexChanged += new System.EventHandler(this.cb商品名稱_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 訂購單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(593, 692);
            this.Controls.Add(this.cb商品名稱);
            this.Controls.Add(this.tb店家名稱);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.tbstoID);
            this.Controls.Add(this.cb期數);
            this.Controls.Add(this.cb姓名);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn送出訂單);
            this.Controls.Add(this.btn加);
            this.Controls.Add(this.btn減);
            this.Controls.Add(this.tb數量);
            this.Controls.Add(this.lbl日期);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "訂購單";
            this.Text = "訂購便當";
            this.Load += new System.EventHandler(this.訂購單_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl日期;
        private System.Windows.Forms.TextBox tb數量;
        private System.Windows.Forms.Button btn減;
        private System.Windows.Forms.Button btn加;
        private System.Windows.Forms.Button btn送出訂單;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cb姓名;
        private System.Windows.Forms.ComboBox cb期數;
        private System.Windows.Forms.TextBox tbstoID;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb店家名稱;
        private System.Windows.Forms.ComboBox cb商品名稱;
        private System.Windows.Forms.Timer timer1;
    }
}

