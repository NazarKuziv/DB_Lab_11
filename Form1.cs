using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Update_ListView("SELECT Books.id,Title,Authors.Name FROM Books INNER JOIN Authors ON Books.Author = Authors.id");

        }
        public void Update_ListView(string queryString)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=New.db");
           
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(queryString,con);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        static public Form2 form2 = null;
        private void Add_button_Click(object sender, EventArgs e)
        {

            if (form2 == null)
                form2 = new Form2();
            form2.Show();
            form2.Activate();


        }

        public static string id = null;
        private void Edit_button_Click(object sender, EventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (id ==null)
            {
                MessageBox.Show("Select row to edit!");
            }
            else
            {
                if (form2 == null)
                    form2 = new Form2();
                form2.Show();
                form2.Activate();


            }
        }

        private void Find_Add_button_Click(object sender, EventArgs e)
        {
            Update_ListView("SELECT Books.id,Title,Authors.Name FROM Books INNER JOIN Authors ON Books.Author = Authors.id");
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=New.db");
            try
            {

                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.DeleteCommand = new SQLiteCommand("DELETE FROM Books WHERE id = @id;", con);
                da.DeleteCommand.Parameters.Add("@id", (DbType)SqlDbType.Int).Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                con.Open();
                da.DeleteCommand.ExecuteNonQuery();
                con.Close();
                Update_ListView("SELECT Books.id,Title,Authors.Name FROM Books INNER JOIN Authors ON Books.Author = Authors.id");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (Search_tBox.Text == "")
                return;

            Update_ListView("SELECT Books.id,Title,Authors.Name FROM Books INNER JOIN Authors ON Books.Author = Authors.id WHERE Title =\""+Search_tBox.Text+"\"");

        }
    }
}
