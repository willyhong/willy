using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseClassLibrary
{
    public partial class Form1 : Form
    {
        string[,] databasedata;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection cn = DataBaseClass.DataBase("JIUNNAN-PC\\SQLEXPRESS", "CG", true, "", "");
            SqlConnection cn = DataBaseClass.DataBase(".", "pubs", true, "", "");
            string qs = "select * from jobs";
            int x = DataBaseClass.datax(cn, qs, "jobs");
            int y = DataBaseClass.datay(cn, qs, "jobs");
            databasedata = new string[x, y];
            databasedata = DataBaseClass.search(cn, qs, "jobs");
            for (int i=0;i<databasedata.GetLength(0);i++)
            {
                cboxjob_id.Items.Add(databasedata[i, 0]);
            }
        }
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            cboxjob_id.Items.Clear();
            SqlConnection cn = DataBaseClass.DataBase(".", "pubs", true, "", "");
            string qs = "insert into jobs values ('" + tbjob_descadd.Text + "'," + tbmin_lvl.Text + "," + tbmax_lvl.Text + ")";
            DataBaseClass.INSERT_delete_update(cn, qs);
            qs = "select * from jobs";
            int x = DataBaseClass.datax(cn, qs, "jobs");
            int y = DataBaseClass.datay(cn, qs, "jobs");
            databasedata = new string[x, y];
            databasedata = DataBaseClass.search(cn, qs, "jobs");
            for (int i = 0; i < databasedata.GetLength(0); i++)
            {
                cboxjob_id.Items.Add(databasedata[i, 0]);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cboxjob_id.Items.Clear();
            SqlConnection cn = DataBaseClass.DataBase(".", "pubs", true, "", "");
            string qs = "delete from jobs where job_id = " + tbjob_idadd.Text;
            DataBaseClass.INSERT_delete_update(cn, qs);
            qs = "select * from jobs";
            int x = DataBaseClass.datax(cn, qs, "jobs");
            int y = DataBaseClass.datay(cn, qs, "jobs");
            databasedata = new string[x, y];
            databasedata = DataBaseClass.search(cn, qs, "jobs");
            for (int i = 0; i < databasedata.GetLength(0); i++)
            {
                cboxjob_id.Items.Add(databasedata[i, 0]);
            }
        }

        private void cboxjob_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < databasedata.GetLength(0); i++)
            {
                if (int.Parse(databasedata[i, 0]) == int.Parse(cboxjob_id.SelectedItem.ToString()))
                {
                    tbjob_idadd.Text = databasedata[i, 0];
                    tbjob_descadd.Text = databasedata[i, 1];
                    tbmin_lvl.Text = databasedata[i, 2];
                    tbmax_lvl.Text = databasedata[i, 3];
                    break;
                }
            }
        }
    }
}
