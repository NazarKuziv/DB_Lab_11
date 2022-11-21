using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Lab_11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Form1.id = null;
            Form1.form2 = null;
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Update_ListView("SELECT Books.id,Title,Authors.Name FROM Books INNER JOIN Authors ON Books.Author = Authors.id");
        }

        public string id = null;

        private void Form2_Load(object sender, EventArgs e)
        {
            
            Update_Combo_Box();

            if (Form1.id != null)
            {
                id = Form1.id;
                string author_id = null;

                SQLiteConnection con = new SQLiteConnection("Data Source=New.db");
                con.Open();
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT * FROM Books WHERE id = " + id, con);
                da.Fill(ds);
                DataTableReader rd = ds.Tables[0].CreateDataReader();

                while (rd.Read())
                {
                    Title_tBox.Text = rd["Title"].ToString();
                    author_id = rd["Author"].ToString();
                }


                for (int i = 0; i < Author_cBox.Items.Count; i++)
                {
                    string[] author = Author_cBox.Items[i].ToString().Split('-');
                    string id_cBox = author[0];

                    if (author_id == id_cBox)
                    {
                        Author_cBox.SelectedIndex = i;
                        break;

                    }
                }
            }
        }


        public void Update_Combo_Box()
        {
            Author_cBox.Items.Clear();

            SQLiteConnection con = new SQLiteConnection("Data Source=New.db");
            con.Open();
            DataSet ds = new DataSet();
            var da = new SQLiteDataAdapter("SELECT * FROM Authors;", con);
            da.Fill(ds);
            DataTableReader rd = ds.Tables[0].CreateDataReader();
            while (rd.Read())
            {
                Author_cBox.Items.Add(rd["id"].ToString() + "-" + rd["Name"].ToString());
            }
            rd.Close();

            con.Close();

            
        }

        private void Add_Author_button_Click(object sender, EventArgs e)
        {
            string message, title;
            string author;

            message = "Author Name";
            title = "Add Author";

            author = Interaction.InputBox(message, title);

            if (author == "")
                return;

            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=New.db");

                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.InsertCommand = new SQLiteCommand("INSERT INTO Authors(Name) VALUES(@Name)", con);
                da.InsertCommand.Parameters.Add("@Name", (DbType)SqlDbType.VarChar).Value = author;

                con.Open();
                da.InsertCommand.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Update_Combo_Box();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            if (Title_tBox.Text == "")
            {
                MessageBox.Show("Enter Title!");
                return;
            }

            if (Author_cBox.Text == "")
            {
                MessageBox.Show("Choose Author!");
                return;
            }

            if (id == null)
            {
                string[] author = Author_cBox.Text.Split('-');
                try
                {
                    SQLiteConnection con = new SQLiteConnection("Data Source=New.db");

                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da.InsertCommand = new SQLiteCommand("INSERT INTO Books (Title,Author) VALUES (@Title,@Author)", con);
                    da.InsertCommand.Parameters.Add("@Title", (DbType)SqlDbType.VarChar).Value = Title_tBox.Text;
                    da.InsertCommand.Parameters.Add("@Author", (DbType)SqlDbType.Int).Value = author[0];
                    con.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
            else
            {

                string[] author = Author_cBox.Text.Split('-');
                try
                {
                    SQLiteConnection con = new SQLiteConnection("Data Source=New.db");

                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da.UpdateCommand = new SQLiteCommand("UPDATE Books SET Title = @Title, Author = @Author WHERE id = @id", con);
                    da.UpdateCommand.Parameters.Add("@Title", (DbType)SqlDbType.VarChar).Value = Title_tBox.Text;
                    da.UpdateCommand.Parameters.Add("@Author", (DbType)SqlDbType.Int).Value = author[0];
                    da.UpdateCommand.Parameters.Add("@id", (DbType)SqlDbType.Int).Value = id;
                    con.Open();
                    da.UpdateCommand.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
        }
    }

}
