using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls.Tasks
{
    public partial class UserTaskControl : UserControl
    {
        public TennantTask UpdateUsingObject
        {
            set
            {
                TaskControlView.UpdateUsingObject = value;
                ActivateButtonTask();
            }
        }
        public UserTaskControl()
        {
            InitializeComponent();
        }

        private void ActivateButtonTask()
        {
            btnComplete.Enabled = true;
            switch (TaskControlView.StoredTask.Status)
            {
                case TennantTaskStatus.Assigned:
                    btnComplete.Enabled = true;
                    break;
                case TennantTaskStatus.Completed:
                    btnComplete.Enabled = false;
                    break;
            }
        }

            private void btnComplete_Click(object sender, EventArgs e)
        {
            var ret = TennantTaskHandler.CompleteTask(TaskControlView.StoredTask);

            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
    }
}
