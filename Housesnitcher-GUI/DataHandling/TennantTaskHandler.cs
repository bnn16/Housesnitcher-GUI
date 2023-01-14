using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.Models;
using System.Data.SqlClient;

namespace Housesnitcher_GUI.DataHandling
{

    public static class TennantTaskHandler
    {
        public static bool AssignTask(Models.TennantTask task)
        {
            if (TennantTaskStore.tasks.Contains(task))
            {
                return false;
            }
            TennantTaskStore.tasks.Add(task);
            return true;
        }
        private static readonly string _connection = "data source = MSI\\SQLEXPRESS; database=Group Project; integrated security=True";
        public static bool CompleteTask(Models.TennantTask task)
        {
            if (task.Status != Models.TennantTaskStatus.Assigned)
            {
                return false;
            }
            BumpStatus(task);
            return true;
        }
        public static bool FailTask(Models.TennantTask task)
        {
            if (task.Status == Models.TennantTaskStatus.Failed)
            {
                return false;
            }
            var idx = TennantTaskStore.tasks.FindIndex(x => x == task);
            TennantTaskStore.tasks[idx].Status = Models.TennantTaskStatus.Failed;
            return true;
        }
        private static void BumpStatus(Models.TennantTask task)
        {
            var idx = TennantTaskStore.tasks.FindIndex(x => x == task);
            TennantTaskStore.tasks[idx].Status++;
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
                        string task_type = (string)reader["task_type"];
                        string task_feedback = reader["task_status"] is DBNull ? null : reader["task_status"].ToString();
                        DateTime date_due = (DateTime)reader["dateDue"];
                        TennantTask t = new TennantTask(title, task_desc, user, task_type, task_feedback, date_due);
                        TennantTaskStatus Status;

                        if (reader.IsDBNull(reader.GetOrdinal("task_status")))
                        {
                            Status = TennantTaskStatus.Assigned;
                        }
                        else if (reader.GetInt32(reader.GetOrdinal("task_status")) == 0)
                        {
                            Status = TennantTaskStatus.Assigned;
                        }
                        else if (reader.GetInt32(reader.GetOrdinal("task_status")) == 1)
                        {
                            Status = TennantTaskStatus.Completed;
                        }
                        else if (reader.GetInt32(reader.GetOrdinal("task_status")) == 2)
                        {
                            Status = TennantTaskStatus.Failed;
                        }
                        else
                        {
                            Status = TennantTaskStatus.Failed;
                        }
                        t.Status = Status;
                        allTasks.Add(t);


                       
                    }
                    return allTasks;
                }
            }
        }
    }
} 