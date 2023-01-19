using Housesnitcher_GUI.Models;
using System.Data.SqlClient;

namespace Housesnitcher_GUI.DataHandling
{
    public static class TennantTaskHandler
    {
        private static readonly string _connection = $"data source = {StateManagement.State.DataSource}; database={StateManagement.State.ConnectionString}; integrated security=SSPI";
        public static TennantTask? AssignTask(TennantTask task)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select count(*) from tasks where title = @title and task_description = @task_description and username = @username and task_type = @task_type", connection))
                {
                    command.Parameters.AddWithValue("@title", task.Title);
                    command.Parameters.AddWithValue("@task_description", task.Description);
                    command.Parameters.AddWithValue("@username", task.Username);
                    command.Parameters.AddWithValue("@task_type", task.Type);
                    int TaskExists = (int)command.ExecuteScalar();

                    if (TaskExists > 0)
                    {
                        MessageBox.Show("Complaint Already Exists");
                        return null;

                    }
                }
                connection.Close();
            }
            try
            {
                string query = "Insert into tasks (title, task_description, username, task_type, task_status, dateDue, dateCreated) values (@title, @task_description, @username, @task_type, @task_status, @dateDue, @dateCreated)";
                using (SqlConnection connection = new SqlConnection(_connection))
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@title", task.Title);
                        command.Parameters.AddWithValue("@task_description", task.Description);
                        command.Parameters.AddWithValue("@username", task.Username);
                        command.Parameters.AddWithValue("@task_type", task.Type);
                        command.Parameters.AddWithValue("@dateDue", task.DateDue);
                        command.Parameters.AddWithValue("@dateCreated", task.DateCreated);
                        command.Parameters.AddWithValue("@task_status", task.Status);
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return task;
        }

        public static TennantTask? CompleteTask(TennantTask task)
        {
            if (task.Status != TennantTaskStatus.Assigned)
            {
                return null;
            }
            return BumpStatus(task);
        }
        public static TennantTask? FailTask(TennantTask task)
        {
            using (var connection = new SqlConnection(_connection))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "Update tasks set task_status = 2 where title = @Title and task_description = @Description and username = @Username and task_type = @Type";
                command.Parameters.AddWithValue("@Title", task.Title);
                command.Parameters.AddWithValue("@Description", task.Description);
                command.Parameters.AddWithValue("@Username", task.Username);
                command.Parameters.AddWithValue("@Type", task.Type);
                var rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    command.CommandText = "SELECT * FROM tasks WHERE title = @Title AND task_description = @Description " +
                                          "AND username = @Username AND task_type = @Type";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Title = reader["title"].ToString();
                            string ComplaintDescription = reader["task_description"].ToString();
                            string Username = reader["username"].ToString();
                            string ComplaintType = reader["task_type"].ToString();
                            TennantTaskStatus Status;
                            if (reader.IsDBNull(reader.GetOrdinal("task_status")))
                            {
                                Status = TennantTaskStatus.Assigned;
                            }
                            else if ((int)reader["task_status"] == 0)
                            {
                                Status = TennantTaskStatus.Assigned;
                            }
                            else if ((int)reader["task_status"] == 1)
                            {
                                Status = TennantTaskStatus.Completed;
                            }
                            else if ((int)reader["task_status"] == 2)
                            {
                                Status = TennantTaskStatus.Failed;
                            }
                            else
                            {
                                Status = TennantTaskStatus.Failed;
                            }
                            DateTime DateHappened = DateTime.Parse(reader["dateCreated"].ToString());
                            DateTime dateDue = DateTime.Parse(reader["dateDue"].ToString());
                            return new TennantTask(Title, ComplaintDescription, Username, ComplaintType, Status, dateDue, DateHappened);
                        }
                    }
                }
                return null;
            }
        }
        private static TennantTask? BumpStatus(Models.TennantTask task)
        {
            using (var connection = new SqlConnection(_connection))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "Update tasks set task_status = task_status + 1 where title = @Title and task_description = @Description and username = @Username and task_type = @Type";
                command.Parameters.AddWithValue("@Title", task.Title);
                command.Parameters.AddWithValue("@Description", task.Description);
                command.Parameters.AddWithValue("@Username", task.Username);
                command.Parameters.AddWithValue("@Type", task.Type);
                var rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    command.CommandText = "SELECT * FROM tasks WHERE title = @Title AND task_description = @Description " +
                                          "AND username = @Username AND task_type = @Type";
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Title = reader["title"].ToString();
                            string ComplaintDescription = reader["task_description"].ToString();
                            string Username = reader["username"].ToString();
                            string ComplaintType = reader["task_type"].ToString();
                            TennantTaskStatus Status;
                            if (reader.IsDBNull(reader.GetOrdinal("task_status")))
                            {
                                Status = TennantTaskStatus.Assigned;
                            }
                            else if ((int)reader["task_status"] == 0)
                            {
                                Status = TennantTaskStatus.Assigned;
                            }
                            else if ((int)reader["task_status"] == 1)
                            {
                                Status = TennantTaskStatus.Completed;
                            }
                            else if ((int)reader["task_status"] == 2)
                            {
                                Status = TennantTaskStatus.Failed;
                            }
                            else
                            {
                                Status = TennantTaskStatus.Failed;
                            }
                            DateTime DateHappened = (DateTime)reader["dateCreated"];
                            DateTime dateDue = (DateTime)reader["dateDue"];
                            return new TennantTask(Title, ComplaintDescription, Username, ComplaintType, Status, dateDue, DateHappened);
                        }
                    }

                    //var idx = TennantTaskStore.tasks.FindIndex(x => x == task);
                    //TennantTaskStore.tasks[idx].Status++;
                    //return TennantTaskStore.tasks[idx];
                }
            }
            return null;
        }

        public static List<TennantTask> AllTasks()
        {
            List<TennantTask> allTasks = new List<TennantTask>();
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM tasks ORDER BY id DESC", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string title = (string)reader["title"];
                        string task_desc = (string)reader["task_description"];
                        string user = (string)reader["username"];
                        string taskType = (string)reader["task_type"];
                        DateTime dateDue = Convert.ToDateTime(reader["DateDue"]);
                        DateTime dateCreated = Convert.ToDateTime(reader["dateCreated"]);
                        TennantTask t = new TennantTask(title, task_desc, user, taskType, dateDue);

                        if (reader.IsDBNull(reader.GetOrdinal("task_status")))
                        {
                            t.Status = TennantTaskStatus.Assigned;
                        }
                        t.Status = reader.GetInt32(reader.GetOrdinal("task_status")) switch
                        {
                            0 => TennantTaskStatus.Assigned,
                            1 => TennantTaskStatus.Completed,
                            2 => TennantTaskStatus.Failed,
                            _ => TennantTaskStatus.Assigned
                        };
                        allTasks.Add(t);
                    }
                    return allTasks;
                }
            }
        }
        public static List<TennantTask> SpecificUserTask(User user)
        {
            return Filter(user.Username);
        }
        private static List<TennantTask> Filter(string username)
        {
            return AllTasks().FindAll(x => x.Username == username);
        }
    }
}