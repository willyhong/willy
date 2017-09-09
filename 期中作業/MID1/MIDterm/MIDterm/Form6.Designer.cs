namespace MIDterm
{
    partial class Form6
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
            this.btn新增 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb商品ID = new System.Windows.Forms.TextBox();
            this.tb商品名稱 = new System.Windows.Forms.TextBox();
            this.tb商品價格 = new System.Windows.Forms.TextBox();
            this.cb店家 = new System.Windows.Forms.ComboBox();
            this.刪除 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn新增
            // 
            this.btn新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn新增.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn新增.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(4, 420);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(112, 34);
            this.btn新增.TabIndex = 0;
            this.btn新增.Text = "新增";
            this.btn新增.UseVisualStyleBackColor = false;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "商品ID:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(25, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "商品名稱:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(25, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "商品價格:";
            // 
            // tb商品ID
            // 
            this.tb商品ID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb商品ID.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb商品ID.Location = new System.Drawing.Point(161, 129);
            this.tb商品ID.Multiline = true;
            this.tb商品ID.Name = "tb商品ID";
            this.tb商品ID.Size = new System.Drawing.Size(54, 36);
            this.tb商品ID.TabIndex = 10;
            this.tb商品ID.TextChanged += new System.EventHandler(this.tb商品ID_TextChanged);
            // 
            // tb商品名稱
            // 
            this.tb商品名稱.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb商品名稱.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb商品名稱.Location = new System.Drawing.Point(161, 195);
            this.tb商品名稱.Multiline = true;
            this.tb商品名稱.Name = "tb商品名稱";
            this.tb商品名稱.Size = new System.Drawing.Size(139, 36);
            this.tb商品名稱.TabIndex = 11;
            // 
            // tb商品價格
            // 
            this.tb商品價格.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb商品價格.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb商品價格.Location = new System.Drawing.Point(161, 253);
            this.tb商品價格.Multiline = true;
            this.tb商品價格.Name = "tb商品價格";
            this.tb商品價格.Size = new System.Drawing.Size(54, 36);
            this.tb商品價格.TabIndex = 12;
            // 
            // cb店家
            // 
            this.cb店家.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb店家.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb店家.FormattingEnabled = true;
            this.cb店家.Location = new System.Drawing.Point(161, 63);
            this.cb店家.Name = "cb店家";
            this.cb店家.Size = new System.Drawing.Size(121, 20);
            this.cb店家.TabIndex = 13;
            // 
            // 刪除
            // 
            this.刪除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.刪除.Cursor = System.Windows.Forms.Cursors.Hand;
            this.刪除.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.刪除.Location = new System.Drawing.Point(288, 419);
            this.刪除.Name = "刪除";
            this.刪除.Size = new System.Drawing.Size(110, 35);
            this.刪除.TabIndex = 14;
            this.刪除.Text = "刪除";
            this.刪除.UseVisualStyleBackColor = false;
            this.刪除.Click += new System.EventHandler(this.刪除_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "店家名稱:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(148, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(410, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.刪除);
            this.Controls.Add(this.cb店家);
            this.Controls.Add(this.tb商品價格);
            this.Controls.Add(this.tb商品名稱);
            this.Controls.Add(this.tb商品ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn新增);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb商品ID;
        private System.Windows.Forms.TextBox tb商品名稱;
        private System.Windows.Forms.TextBox tb商品價格;
        private System.Windows.Forms.ComboBox cb店家;
        private System.Windows.Forms.Button 刪除;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}