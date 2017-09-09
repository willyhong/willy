namespace MIDterm
{
    partial class 學生增刪改
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
            this.新增 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.刪除 = new System.Windows.Forms.Button();
            this.tb姓名 = new System.Windows.Forms.TextBox();
            this.tb學生ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb期數 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // 新增
            // 
            this.新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.新增.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.新增.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.新增.Location = new System.Drawing.Point(239, 350);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(143, 69);
            this.新增.TabIndex = 27;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = false;
            this.新增.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(40, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "期數:";
            // 
            // 刪除
            // 
            this.刪除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.刪除.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.刪除.Location = new System.Drawing.Point(239, 263);
            this.刪除.Name = "刪除";
            this.刪除.Size = new System.Drawing.Size(143, 69);
            this.刪除.TabIndex = 25;
            this.刪除.Text = "刪除";
            this.刪除.UseVisualStyleBackColor = false;
            this.刪除.Click += new System.EventHandler(this.刪除_Click);
            // 
            // tb姓名
            // 
            this.tb姓名.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb姓名.Location = new System.Drawing.Point(176, 189);
            this.tb姓名.Multiline = true;
            this.tb姓名.Name = "tb姓名";
            this.tb姓名.Size = new System.Drawing.Size(139, 36);
            this.tb姓名.TabIndex = 22;
            // 
            // tb學生ID
            // 
            this.tb學生ID.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb學生ID.Location = new System.Drawing.Point(176, 85);
            this.tb學生ID.Multiline = true;
            this.tb學生ID.Name = "tb學生ID";
            this.tb學生ID.Size = new System.Drawing.Size(54, 36);
            this.tb學生ID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(39, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "姓名:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(40, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "學生ID:";
            // 
            // tb期數
            // 
            this.tb期數.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb期數.Location = new System.Drawing.Point(176, 19);
            this.tb期數.Multiline = true;
            this.tb期數.Name = "tb期數";
            this.tb期數.Size = new System.Drawing.Size(54, 36);
            this.tb期數.TabIndex = 28;
            // 
            // 學生增刪改
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(408, 438);
            this.Controls.Add(this.tb期數);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.刪除);
            this.Controls.Add(this.tb姓名);
            this.Controls.Add(this.tb學生ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "學生增刪改";
            this.Text = "學生增刪改";
            this.Load += new System.EventHandler(this.學生增刪改_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 刪除;
        private System.Windows.Forms.TextBox tb姓名;
        private System.Windows.Forms.TextBox tb學生ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb期數;
    }
}