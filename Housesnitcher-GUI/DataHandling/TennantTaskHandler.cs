using Housesnitcher_GUI.DataStorageAbstractions;

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
    }
}
