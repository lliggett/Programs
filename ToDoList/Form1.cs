using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;


namespace ToDoList
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommand rowCount;
        List<string> tasks = new List<string> { };
        int taskCounter;
        public Form1()
        {
            
            InitializeComponent();
            //shows data on listbox when program starts

            List<string> tasks = new List<string> { };
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ligge\source\repos\ToDoList\ToDoList\ToDoListReal.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand();
            //sets taskCounter to the number of rows in table
            con.Open();
            rowCount = new SqlCommand();
            rowCount.Connection = con;
            rowCount.CommandText = "SELECT COUNT (task) FROM ToDo";
            int taskCounter = (Int32)rowCount.ExecuteScalar();
            con.Close();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ToDo";
            dr = cmd.ExecuteReader();
            //adds all rows
            while (dr.Read())
            {
                
                lbx_list.Items.Add(dr["task"]);
                taskCounter--;
                

                if (taskCounter == 0) break;
            }
            con.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //adds textbox text to database
            
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ligge\source\repos\ToDoList\ToDoList\ToDoListReal.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand();
            con.Open();
            cmd = new SqlCommand("INSERT INTO ToDo (task) VALUES (@task)", con);
            cmd.Parameters.Add(new SqlParameter("@task", txb_newItem.Text));
            tasks.Add(txb_newItem.Text);
            txb_newItem.Clear();
            cmd.ExecuteNonQuery();
            
            //adds data from database to list
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ToDo";
            dr = cmd.ExecuteReader();
            int taskCounter = 0;
            while (dr.Read())
            {
                if (!lbx_list.Items.Contains(dr["task"]))
                {
                    lbx_list.Items.Add(dr["task"]);
                    taskCounter++;
                }

                if (taskCounter > tasks.Count) break;
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

               

        }

        
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.toDoTableAdapter.Fill(this.toDoListRealDataSet.ToDo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ligge\source\repos\ToDoList\ToDoList\ToDoListReal.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand();
            con.Open();
            //clears all entries in database and list
            SqlCommand clear = new SqlCommand("DELETE FROM ToDo WHERE Id = Id", con);
            clear.ExecuteNonQuery();
            lbx_list.Items.Clear();
            
            con.Close();
        }

        //remove button
        private void btn_complete_Click(object sender, EventArgs e)
        {
            List<string> tasks = new List<string> { };
            
            
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ligge\source\repos\ToDoList\ToDoList\ToDoListReal.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand remove = new SqlCommand();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            for (int i = 0; i < lbx_list.SelectedItems.Count; i++)
            {
                lbx_list.Items.Remove(lbx_list.SelectedItems[i]);
                string listSelected = lbx_list.SelectedItems.ToString();
                cmd.CommandText = "SELECT * FROM ToDo";
                remove = new SqlCommand("DELETE FROM ToDo WHERE task = '" + listSelected + "'", con);
                cmd.ExecuteNonQuery();
                //if the list box is empty the database is cleared
                if (lbx_list.Items.Count == 0)
                {
                    SqlCommand clear = new SqlCommand("DELETE FROM ToDo WHERE Id = Id", con);
                    clear.ExecuteNonQuery();
                }
            }
            con.Close();



        }
    }
}
