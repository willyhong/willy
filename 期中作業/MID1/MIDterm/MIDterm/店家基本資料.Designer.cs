namespace MIDterm
{
    partial class 店家基本資料
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb名稱 = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btn返回 = new System.Windows.Forms.Button();
            this.btn查詢 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btn資料集 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "店家名稱: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "店家電話:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(21, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "店家地址:";
            // 
            // tb名稱
            // 
            this.tb名稱.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb名稱.Location = new System.Drawing.Point(156, 161);
            this.tb名稱.Multiline = true;
            this.tb名稱.Name = "tb名稱";
            this.tb名稱.Size = new System.Drawing.Size(171, 41);
            this.tb名稱.TabIndex = 15;
            // 
            // tbphone
            // 
            this.tbphone.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbphone.Location = new System.Drawing.Point(156, 322);
            this.tbphone.Multiline = true;
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(171, 29);
            this.tbphone.TabIndex = 16;
            // 
            // tbadd
            // 
            this.tbadd.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbadd.Location = new System.Drawing.Point(156, 236);
            this.tbadd.Multiline = true;
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(280, 41);
            this.tbadd.TabIndex = 17;
            this.tbadd.TextChanged += new System.EventHandler(this.tbadd_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnadd.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnadd.Location = new System.Drawing.Point(30, 380);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(86, 77);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "新增";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndelete.Location = new System.Drawing.Point(156, 380);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(86, 77);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "刪除";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnchange.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnchange.Location = new System.Drawing.Point(282, 380);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(86, 77);
            this.btnchange.TabIndex = 20;
            this.btnchange.Text = "修改";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btn返回
            // 
            this.btn返回.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn返回.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn返回.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn返回.Location = new System.Drawing.Point(455, 413);
            this.btn返回.Name = "btn返回";
            this.btn返回.Size = new System.Drawing.Size(133, 44);
            this.btn返回.TabIndex = 22;
            this.btn返回.Text = "返回";
            this.btn返回.UseVisualStyleBackColor = false;
            this.btn返回.Click += new System.EventHandler(this.btn返回_Click);
            // 
            // btn查詢
            // 
            this.btn查詢.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn查詢.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查詢.Location = new System.Drawing.Point(502, 297);
            this.btn查詢.Name = "btn查詢";
            this.btn查詢.Size = new System.Drawing.Size(86, 77);
            this.btn查詢.TabIndex = 23;
            this.btn查詢.Text = "查詢";
            this.btn查詢.UseVisualStyleBackColor = false;
            this.btn查詢.Click += new System.EventHandler(this.btn查詢_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "店家ID: ";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbID.Location = new System.Drawing.Point(156, 80);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(48, 41);
            this.tbID.TabIndex = 25;
            // 
            // btn資料集
            // 
            this.btn資料集.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn資料集.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料集.Location = new System.Drawing.Point(502, 188);
            this.btn資料集.Name = "btn資料集";
            this.btn資料集.Size = new System.Drawing.Size(86, 77);
            this.btn資料集.TabIndex = 26;
            this.btn資料集.Text = "資料集";
            this.btn資料集.UseVisualStyleBackColor = false;
            this.btn資料集.Click += new System.EventHandler(this.btn資料集_Click);
            // 
            // 店家基本資料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.btn資料集);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn查詢);
            this.Controls.Add(this.btn返回);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tbadd);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tb名稱);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "店家基本資料";
            this.Text = "店家基本資料";
            this.Load += new System.EventHandler(this.店家基本資料_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb名稱;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btn返回;
        private System.Windows.Forms.Button btn查詢;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btn資料集;
    }
}