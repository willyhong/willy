namespace 期中專題_資策會南區_便當訂購系統
{
    partial class Form4
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
            this.tbcname = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbphone2 = new System.Windows.Forms.TextBox();
            this.tbother = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbcname
            // 
            this.tbcname.Location = new System.Drawing.Point(76, 80);
            this.tbcname.Name = "tbcname";
            this.tbcname.Size = new System.Drawing.Size(129, 22);
            this.tbcname.TabIndex = 0;
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(262, 80);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(144, 22);
            this.tbaddress.TabIndex = 1;
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(450, 80);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(148, 22);
            this.tbphone.TabIndex = 2;
            // 
            // tbphone2
            // 
            this.tbphone2.Location = new System.Drawing.Point(76, 165);
            this.tbphone2.Name = "tbphone2";
            this.tbphone2.Size = new System.Drawing.Size(148, 22);
            this.tbphone2.TabIndex = 3;
            // 
            // tbother
            // 
            this.tbother.Location = new System.Drawing.Point(76, 229);
            this.tbother.Name = "tbother";
            this.tbother.Size = new System.Drawing.Size(148, 22);
            this.tbother.TabIndex = 4;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 446);
            this.Controls.Add(this.tbother);
            this.Controls.Add(this.tbphone2);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.tbcname);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcname;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbphone2;
        private System.Windows.Forms.TextBox tbother;
    }
}