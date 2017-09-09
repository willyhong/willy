namespace 期中專題_資策會南區_便當訂購系統
{
    partial class Form7
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
            this.lb1 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbclass = new System.Windows.Forms.TextBox();
            this.新增 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb1.Location = new System.Drawing.Point(12, 127);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(54, 16);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Name:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(90, 127);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 22);
            this.tbname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(90, 69);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 22);
            this.tbid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class:";
            // 
            // tbclass
            // 
            this.tbclass.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbclass.Location = new System.Drawing.Point(90, 207);
            this.tbclass.Name = "tbclass";
            this.tbclass.Size = new System.Drawing.Size(100, 27);
            this.tbclass.TabIndex = 5;
            // 
            // 新增
            // 
            this.新增.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.新增.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.新增.Location = new System.Drawing.Point(188, 298);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(126, 47);
            this.新增.TabIndex = 6;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = false;
            this.新增.Click += new System.EventHandler(this.新增_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 367);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.tbclass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lb1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbclass;
        private System.Windows.Forms.Button 新增;
    }
}