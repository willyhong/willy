namespace 期中專題_資策會南區_便當訂購系統
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
            this.components = new System.ComponentModel.Container();
            this.label12 = new System.Windows.Forms.Label();
            this.cbclassdetil = new System.Windows.Forms.ComboBox();
            this.cbname = new System.Windows.Forms.ComboBox();
            this.cbclass = new System.Windows.Forms.ComboBox();
            this.cbcompany = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbproductname = new System.Windows.Forms.ComboBox();
            this.tbunit = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsumbit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.系統維護 = new System.Windows.Forms.MenuStrip();
            this.系統維護ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更換店家toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜單資料維護toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.廠商資料維護ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.學員資料維護ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.less = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btncompny = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btncomplete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbquan = new System.Windows.Forms.TextBox();
            this.btn明細 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.系統維護.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(22, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 39);
            this.label12.TabIndex = 0;
            // 
            // cbclassdetil
            // 
            this.cbclassdetil.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbclassdetil.FormattingEnabled = true;
            this.cbclassdetil.Location = new System.Drawing.Point(93, 82);
            this.cbclassdetil.Name = "cbclassdetil";
            this.cbclassdetil.Size = new System.Drawing.Size(124, 27);
            this.cbclassdetil.TabIndex = 1;
            this.cbclassdetil.SelectedIndexChanged += new System.EventHandler(this.cbclassdetil_SelectedIndexChanged);
            // 
            // cbname
            // 
            this.cbname.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbname.FormattingEnabled = true;
            this.cbname.Location = new System.Drawing.Point(93, 115);
            this.cbname.Name = "cbname";
            this.cbname.Size = new System.Drawing.Size(124, 27);
            this.cbname.TabIndex = 2;
            this.cbname.SelectedIndexChanged += new System.EventHandler(this.cbname_SelectedIndexChanged);
            // 
            // cbclass
            // 
            this.cbclass.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbclass.FormattingEnabled = true;
            this.cbclass.Location = new System.Drawing.Point(741, 63);
            this.cbclass.Name = "cbclass";
            this.cbclass.Size = new System.Drawing.Size(124, 27);
            this.cbclass.TabIndex = 3;
            // 
            // cbcompany
            // 
            this.cbcompany.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbcompany.FormattingEnabled = true;
            this.cbcompany.Location = new System.Drawing.Point(93, 146);
            this.cbcompany.Name = "cbcompany";
            this.cbcompany.Size = new System.Drawing.Size(124, 27);
            this.cbcompany.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 239);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbproductname
            // 
            this.cbproductname.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbproductname.FormattingEnabled = true;
            this.cbproductname.Location = new System.Drawing.Point(290, 95);
            this.cbproductname.Name = "cbproductname";
            this.cbproductname.Size = new System.Drawing.Size(124, 27);
            this.cbproductname.TabIndex = 6;
            this.cbproductname.SelectedIndexChanged += new System.EventHandler(this.cbproductname_SelectedIndexChanged);
            // 
            // tbunit
            // 
            this.tbunit.Location = new System.Drawing.Point(430, 100);
            this.tbunit.Name = "tbunit";
            this.tbunit.Size = new System.Drawing.Size(92, 22);
            this.tbunit.TabIndex = 7;
            this.tbunit.TextChanged += new System.EventHandler(this.tbunit_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(528, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(22, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 39);
            this.label9.TabIndex = 9;
            // 
            // btnsumbit
            // 
            this.btnsumbit.Location = new System.Drawing.Point(824, 383);
            this.btnsumbit.Name = "btnsumbit";
            this.btnsumbit.Size = new System.Drawing.Size(109, 29);
            this.btnsumbit.TabIndex = 10;
            this.btnsumbit.Text = "sumbit";
            this.btnsumbit.UseVisualStyleBackColor = true;
            this.btnsumbit.Click += new System.EventHandler(this.btnsumbit_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(22, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 39);
            this.label8.TabIndex = 11;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // 系統維護
            // 
            this.系統維護.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系統維護ToolStripMenuItem,
            this.離開ToolStripMenuItem,
            this.更換店家toolStripMenuItem,
            this.菜單資料維護toolStripMenuItem,
            this.廠商資料維護ToolStripMenuItem,
            this.學員資料維護ToolStripMenuItem});
            this.系統維護.Location = new System.Drawing.Point(0, 0);
            this.系統維護.Name = "系統維護";
            this.系統維護.Size = new System.Drawing.Size(1001, 24);
            this.系統維護.TabIndex = 12;
            this.系統維護.Text = "menuStrip1";
            // 
            // 系統維護ToolStripMenuItem
            // 
            this.系統維護ToolStripMenuItem.Name = "系統維護ToolStripMenuItem";
            this.系統維護ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.系統維護ToolStripMenuItem.Text = "系統維護";
            this.系統維護ToolStripMenuItem.Click += new System.EventHandler(this.系統維護ToolStripMenuItem_Click);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.離開ToolStripMenuItem.Text = "離開";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click_1);
            // 
            // 更換店家toolStripMenuItem
            // 
            this.更換店家toolStripMenuItem.Name = "更換店家toolStripMenuItem";
            this.更換店家toolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.更換店家toolStripMenuItem.Text = "更換店家";
            this.更換店家toolStripMenuItem.Click += new System.EventHandler(this.更換店家toolStripMenuItem_Click_1);
            // 
            // 菜單資料維護toolStripMenuItem
            // 
            this.菜單資料維護toolStripMenuItem.Name = "菜單資料維護toolStripMenuItem";
            this.菜單資料維護toolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.菜單資料維護toolStripMenuItem.Text = "菜單資料維護";
            this.菜單資料維護toolStripMenuItem.Click += new System.EventHandler(this.菜單資料維護toolStripMenuItem_Click_1);
            // 
            // 廠商資料維護ToolStripMenuItem
            // 
            this.廠商資料維護ToolStripMenuItem.Name = "廠商資料維護ToolStripMenuItem";
            this.廠商資料維護ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.廠商資料維護ToolStripMenuItem.Text = "廠商資料維護";
            this.廠商資料維護ToolStripMenuItem.Click += new System.EventHandler(this.廠商資料維護ToolStripMenuItem_Click_1);
            // 
            // 學員資料維護ToolStripMenuItem
            // 
            this.學員資料維護ToolStripMenuItem.Name = "學員資料維護ToolStripMenuItem";
            this.學員資料維護ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.學員資料維護ToolStripMenuItem.Text = "學員資料維護";
            this.學員資料維護ToolStripMenuItem.Click += new System.EventHandler(this.學員資料維護ToolStripMenuItem_Click_1);
            // 
            // less
            // 
            this.less.Location = new System.Drawing.Point(824, 322);
            this.less.Name = "less";
            this.less.Size = new System.Drawing.Size(109, 29);
            this.less.TabIndex = 13;
            this.less.Text = "-";
            this.less.UseVisualStyleBackColor = true;
            this.less.Click += new System.EventHandler(this.less_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(824, 263);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(109, 29);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(661, 383);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(109, 29);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "btnupdate";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 29);
            this.button4.TabIndex = 16;
            this.button4.Text = "Form5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncompny
            // 
            this.btncompny.Location = new System.Drawing.Point(134, 451);
            this.btncompny.Name = "btncompny";
            this.btncompny.Size = new System.Drawing.Size(102, 29);
            this.btncompny.TabIndex = 18;
            this.btncompny.Text = "company";
            this.btncompny.UseVisualStyleBackColor = true;
            this.btncompny.Click += new System.EventHandler(this.btncompny_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.Location = new System.Drawing.Point(12, 451);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(102, 29);
            this.btnstudent.TabIndex = 19;
            this.btnstudent.Text = "student";
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btncomplete
            // 
            this.btncomplete.Location = new System.Drawing.Point(485, 383);
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.Size = new System.Drawing.Size(102, 29);
            this.btncomplete.TabIndex = 20;
            this.btncomplete.Text = "complete";
            this.btncomplete.UseVisualStyleBackColor = true;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(290, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "select rows";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbquan
            // 
            this.tbquan.Location = new System.Drawing.Point(626, 100);
            this.tbquan.Name = "tbquan";
            this.tbquan.Size = new System.Drawing.Size(92, 22);
            this.tbquan.TabIndex = 22;
            // 
            // btn明細
            // 
            this.btn明細.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn明細.Location = new System.Drawing.Point(134, 411);
            this.btn明細.Name = "btn明細";
            this.btn明細.Size = new System.Drawing.Size(102, 29);
            this.btn明細.TabIndex = 23;
            this.btn明細.Text = "明細";
            this.btn明細.UseVisualStyleBackColor = true;
            this.btn明細.Click += new System.EventHandler(this.btn明細_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "classdetil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(287, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "productname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(738, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(427, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "unit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn明細);
            this.Controls.Add(this.tbquan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btncomplete);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.btncompny);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.add);
            this.Controls.Add(this.less);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsumbit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbunit);
            this.Controls.Add(this.cbproductname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbcompany);
            this.Controls.Add(this.cbclass);
            this.Controls.Add(this.cbname);
            this.Controls.Add(this.cbclassdetil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.系統維護);
            this.MainMenuStrip = this.系統維護;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.系統維護.ResumeLayout(false);
            this.系統維護.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbclassdetil;
        private System.Windows.Forms.ComboBox cbname;
        private System.Windows.Forms.ComboBox cbclass;
        private System.Windows.Forms.ComboBox cbcompany;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbproductname;
        private System.Windows.Forms.TextBox tbunit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnsumbit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip 系統維護;
        private System.Windows.Forms.ToolStripMenuItem 系統維護ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.Button less;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ToolStripMenuItem 更換店家toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜單資料維護toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 廠商資料維護ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 學員資料維護ToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncompny;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btncomplete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbquan;
        private System.Windows.Forms.Button btn明細;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

