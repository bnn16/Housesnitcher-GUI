using Housesnitcher_GUI.DataStorageAbstractions;

namespace Housesnitcher_GUI.DataHandling
{
    public class TaskHandler
    {
        public bool AssignTask(Models.Task task)
        {
            if(TaskStore.tasks.Contains(task))
            {
                return false;
            }
            TaskStore.tasks.Add(task);
            return true;
        }
        public static bool CompleteTask(Models.Task task)
        {
            if(task.Status != Models.TaskStatus.Assigned)
            {
                return false;
            }
            BumpStatus(task);
            return true;
        }
        public static bool FailTask(Models.Task task)
        {
            if (task.Status == Models.TaskStatus.Failed)
            {
                return false;
            }
            var idx = TaskStore.tasks.FindIndex(x => x == task);
            TaskStore.tasks[idx].Status = Models.TaskStatus.Failed;
            return true;
        }
        private static void BumpStatus(Models.Task task)
        {
            var idx = TaskStore.tasks.FindIndex(x => x == task);
            TaskStore.tasks[idx].Status++;
        }
    }
}
