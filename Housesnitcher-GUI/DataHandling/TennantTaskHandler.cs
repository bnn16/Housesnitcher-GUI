using Housesnitcher_GUI.DataStorageAbstractions;
using Housesnitcher_GUI.Models;
using System.Data.SqlClient;

namespace Housesnitcher_GUI.DataHandling
{
    public static class TennantTaskHandler
    {
        public static TennantTask? AssignTask(TennantTask task)
        {
            if (TennantTaskStore.tasks.Contains(task))
            {
                return null;
            }
            TennantTaskStore.tasks.Add(task);
            return task;
        }
        private static readonly string _connection = $"data source = {StateManagement.State.DataSource}; database={StateManagement.State.ConnectionString}; integrated security=SSPI";
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
            if (task.Status == Models.TennantTaskStatus.Failed)
            {
                return null;
            }
            var idx = TennantTaskStore.tasks.FindIndex(x => x == task);
            TennantTaskStore.tasks[idx].Status = Models.TennantTaskStatus.Failed;
            return TennantTaskStore.tasks[idx];
        }
        private static TennantTask? BumpStatus(Models.TennantTask task)
        {
            var idx = TennantTaskStore.tasks.FindIndex(x => x == task);
            TennantTaskStore.tasks[idx].Status++;
            return TennantTaskStore.tasks[idx];
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
                        TennantTaskStatus taskStatus = Enum.Parse<TennantTaskStatus>(reader["task_status"] is DBNull ? null : reader["task_status"].ToString());
                        DateTime dateDue = (DateTime)reader["dateDue"];
                        DateTime dateCreated = (DateTime)reader["dateCreated"];
                        TennantTask t = new TennantTask(title, task_desc, user, taskType, taskStatus, dateDue, dateCreated);

                        if (reader.IsDBNull(reader.GetOrdinal("task_status")))
                        {
                            t.Status = TennantTaskStatus.Assigned;
                        }
                        t.Status = reader.GetInt32(reader.GetOrdinal("task_status")) switch
                        {
                            0 => TennantTaskStatus.Assigned,
                            2 => TennantTaskStatus.Completed,
                            3 => TennantTaskStatus.Failed,
                            _ => TennantTaskStatus.Assigned
                        };
                        allTasks.Add(t);
                    }
                    return allTasks;
                }
            }
        }
    }
}