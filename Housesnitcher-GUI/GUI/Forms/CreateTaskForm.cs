using Housesnitcher_GUI.Models;
using Housesnitcher_GUI.StateManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class CreateTaskForm : Form
    {
        private static readonly string _connection = "data source = MSI\\SQLEXPRESS; database=Group Project; integrated security=True";

        public CreateTaskForm()
        {
            InitializeComponent();
        }


        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            foreach (var task in State.complaintTypes) {
                cmbTasks.Items.Add(task);
            }

            List<string> usernames = new List<string>();

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT username FROM users", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usernames.Add(reader["username"].ToString());
                        }
                    }
                }
            }

            foreach (var username in usernames) { 
                cmbUsers.Items.Add(username);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
           TennantTask newTask = new TennantTask(txtBoxTaskTitle.Text,txtBoxTaskDescription.Text,cmbUsers.Text,cmbTasks.Text, null ,dateTimePicker1.Value);

            try
            {
                using (SqlConnection connection = new SqlConnection(_connection))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO tasks (title, task_description, username, task_type, task_status, dateDue, dateCreated) VALUES (@title, @description, @username, @type, @status, @dateDue, @dateCreated)", connection))
                    {
                        command.Parameters.AddWithValue("@title", newTask.Title);
                        command.Parameters.AddWithValue("@description", newTask.Description);
                        command.Parameters.AddWithValue("@username", newTask.Username);
                        command.Parameters.AddWithValue("@type", newTask.Type);
                        command.Parameters.AddWithValue("@status", newTask.Status);
                        command.Parameters.AddWithValue("@dateDue", newTask.DateDue);
                        command.Parameters.AddWithValue("@dateCreated", newTask.DateCreated);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally {
                MessageBox.Show("Task Created!", "Success");
            }
        }
    }
}
