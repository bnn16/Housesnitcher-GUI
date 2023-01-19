using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls.Tasks
{
    public partial class UserTaskControl : UserControl
    {
        private string _user;

        public TennantTask UpdateUsingObject
        {
            set
            {
                TaskControlView.UpdateUsingObject = value;
                ActivateButtonTask();
            }
        }
        public UserTaskControl(string user)
        {
            InitializeComponent();
            this._user = user;
        }
        public UserTaskControl(TennantTask task)
        {
            InitializeComponent();
            UpdateUsingObject = task;
        }

        private void ActivateButtonTask()
        {
            if (_user == "Admin")
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
                if (TaskControlView.StoredTask.Status == TennantTaskStatus.Failed)
                {
                    btnComplete.Enabled = false;
                }
            }
            else
            {
                if (TaskControlView.StoredTask.Username == _user)
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
                else
                {
                    btnComplete.Enabled = false;
                }
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
