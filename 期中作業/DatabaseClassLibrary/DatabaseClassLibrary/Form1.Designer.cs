namespace DatabaseClassLibrary
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxjob_id = new System.Windows.Forms.ComboBox();
            this.tbjob_descadd = new System.Windows.Forms.TextBox();
            this.tbjob_idadd = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmin_lvl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmax_lvl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "job_id";
            // 
            // cboxjob_id
            // 
            this.cboxjob_id.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxjob_id.FormattingEnabled = true;
            this.cboxjob_id.Location = new System.Drawing.Point(30, 62);
            this.cboxjob_id.Name = "cboxjob_id";
            this.cboxjob_id.Size = new System.Drawing.Size(114, 39);
            this.cboxjob_id.TabIndex = 3;
            this.cboxjob_id.SelectedIndexChanged += new System.EventHandler(this.cboxjob_id_SelectedIndexChanged);
            // 
            // tbjob_descadd
            // 
            this.tbjob_descadd.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbjob_descadd.Location = new System.Drawing.Point(206, 164);
            this.tbjob_descadd.Name = "tbjob_descadd";
            this.tbjob_descadd.Size = new System.Drawing.Size(107, 39);
            this.tbjob_descadd.TabIndex = 2;
            // 
            // tbjob_idadd
            // 
            this.tbjob_idadd.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbjob_idadd.Location = new System.Drawing.Point(206, 62);
            this.tbjob_idadd.Name = "tbjob_idadd";
            this.tbjob_idadd.Size = new System.Drawing.Size(107, 39);
            this.tbjob_idadd.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(21, 229);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 48);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "新增";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(21, 298);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 48);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "刪除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(200, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "min_lvl";
            // 
            // tbmin_lvl
            // 
            this.tbmin_lvl.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbmin_lvl.Location = new System.Drawing.Point(206, 284);
            this.tbmin_lvl.Name = "tbmin_lvl";
            this.tbmin_lvl.Size = new System.Drawing.Size(107, 39);
            this.tbmin_lvl.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(200, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "max_lvl";
            // 
            // tbmax_lvl
            // 
            this.tbmax_lvl.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbmax_lvl.Location = new System.Drawing.Point(206, 408);
            this.tbmax_lvl.Name = "tbmax_lvl";
            this.tbmax_lvl.Size = new System.Drawing.Size(107, 39);
            this.tbmax_lvl.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(197, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "job_desc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(200, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "job_id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(374, 506);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cboxjob_id);
            this.Controls.Add(this.tbjob_idadd);
            this.Controls.Add(this.tbmax_lvl);
            this.Controls.Add(this.tbmin_lvl);
            this.Controls.Add(this.tbjob_descadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxjob_id;
        private System.Windows.Forms.TextBox tbjob_descadd;
        private System.Windows.Forms.TextBox tbjob_idadd;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmin_lvl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbmax_lvl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

