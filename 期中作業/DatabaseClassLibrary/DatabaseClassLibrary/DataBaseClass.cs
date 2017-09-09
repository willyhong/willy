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
    class DataBaseClass
    {
        //計算Table的欄位
        public static int datax(SqlConnection 資料庫, string SQL指令, string 資料表名稱)
        {
            int a = 0;
            資料庫.Open();
            SqlCommand com1 = new SqlCommand(SQL指令, 資料庫);
            SqlDataReader rd0 = com1.ExecuteReader();
            while (rd0.Read())
            {
                if (a == 0)
                {
                    for (;;)
                    {
                        try
                        {
                            if (rd0[a].Equals(DBNull.Value))
                            {
                                break;
                            }
                            a++;
                        }
                        catch (Exception e)
                        {
                            break;
                        }
                    }
                }
            }
            rd0.Close();
            資料庫.Close();
            return a;
        }

        //計算Table的資料數
        public static int datay(SqlConnection 資料庫, string SQL指令, string 資料表名稱)
        {
            int a = 0;
            資料庫.Open();
            SqlCommand com1 = new SqlCommand(SQL指令, 資料庫);
            SqlDataReader rd0 = com1.ExecuteReader();
            while (rd0.Read())
            {
                a++;
            }
            rd0.Close();
            資料庫.Close();
            return a;
        }

        //設定database
        public static SqlConnection DataBase (string 伺服器,string 資料庫名稱,bool 認證win選true,string userID_非win認證才給值,string pwd_非win認證才給值)
        {
            SqlConnectionStringBuilder DB = new SqlConnectionStringBuilder();
            DB.DataSource = 伺服器;
            DB.InitialCatalog = 資料庫名稱;
            if(認證win選true==true)
            {
                DB.IntegratedSecurity = 認證win選true;
            }
            else
            {
                DB.IntegratedSecurity = 認證win選true;
                DB.UserID = userID_非win認證才給值;
                DB.Password = pwd_非win認證才給值;
            }
            SqlConnection cn = new SqlConnection(DB.ToString());
            return cn;
        }

        public DataBaseClass()
        {
            //預設建構子
        }

        //查詢用建構子
        public static string[,] search (SqlConnection 資料庫,string SQL指令,string 資料表名稱)
        {
            string qs = "select * from "+資料表名稱;
            資料庫.Open();
            
            SqlCommand com1 = new SqlCommand(qs, 資料庫);
            SqlDataReader rd0 = com1.ExecuteReader();
            int a = 0, b = 0;
            while (rd0.Read())
            {
                if(a==0)
                {
                    for (;;)
                    {
                        try
                        {
                            if (rd0[a].Equals(DBNull.Value))
                            {
                            }
                            a++;
                        }
                        catch (Exception e)
                        {
                            break;
                        }
                    }
                }
                b++;
            }
            rd0.Close();
            
            SqlCommand command = new SqlCommand(SQL指令, 資料庫);
            string[,] res = new string[b, a];
            SqlDataReader rd = command.ExecuteReader();
            int i = 0;
            while (rd.Read())
            {
                if (!rd[0].Equals(DBNull.Value))
                {
                    for (int j = 0; j < a; j++)
                    {
                        res[i, j] = rd[j].ToString();
                    }
                    i++;
                }
            }
            rd.Close();
            資料庫.Close();
            return res;
        }

        //變更用建構子
        public static void INSERT_delete_update(SqlConnection 資料庫, string SQL指令)
        {
            SqlCommand command = new SqlCommand(SQL指令, 資料庫);
            資料庫.Open();
            command.ExecuteNonQuery();
            資料庫.Close();
        }

    }
}
