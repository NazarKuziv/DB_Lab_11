using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DB_Lab_11
{
    public class db
    {
        //public static SQLiteConnection con = new SQLiteConnection("Data Source=New.db");
        //public static SQLiteCommand cmd = new SQLiteCommand("", con);

        //public static void openConnection()
        //{
        //    try
        //    {
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //            MessageBox.Show("The connection is " + con.State.ToString());

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Connection Failed:" + ex.Message);
        //    }
        //}
        //public static void closeConnection()
        //{
        //    try
        //    {
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //            MessageBox.Show("The connection is " + con.State.ToString());

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Close connection error:" + ex.Message);
        //    }
        //}


    }
}
