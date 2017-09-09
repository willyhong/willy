namespace 期中專題_資策會南區_便當訂購系統
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
            this.cbcompanylist = new System.Windows.Forms.ComboBox();
            this.tbproductname = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.tbother = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbcompanylist
            // 
            this.cbcompanylist.FormattingEnabled = true;
            this.cbcompanylist.Location = new System.Drawing.Point(52, 53);
            this.cbcompanylist.Name = "cbcompanylist";
            this.cbcompanylist.Size = new System.Drawing.Size(121, 20);
            this.cbcompanylist.TabIndex = 0;
            // 
            // tbproductname
            // 
            this.tbproductname.Location = new System.Drawing.Point(52, 133);
            this.tbproductname.Name = "tbproductname";
            this.tbproductname.Size = new System.Drawing.Size(100, 22);
            this.tbproductname.TabIndex = 1;
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(210, 133);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(100, 22);
            this.tbprice.TabIndex = 2;
            // 
            // tbother
            // 
            this.tbother.Location = new System.Drawing.Point(366, 133);
            this.tbother.Name = "tbother";
            this.tbother.Size = new System.Drawing.Size(173, 22);
            this.tbother.TabIndex = 3;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 434);
            this.Controls.Add(this.tbother);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.tbproductname);
            this.Controls.Add(this.cbcompanylist);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbcompanylist;
        private System.Windows.Forms.TextBox tbproductname;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.TextBox tbother;
    }
}