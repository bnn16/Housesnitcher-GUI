using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls.Tasks
{
    public partial class AdminTaskControl : UserControl
    {
        public TennantTask UpdateUsingObject
        {
            set
            {
                taskControl1.UpdateUsingObject = value;
                enableButtons();
            }
        }
        public AdminTaskControl()
        {
            InitializeComponent();
        }
        private void enableButtons()
        {
            btnComplete.Enabled = true;
            btnFail.Enabled = true;
            if (taskControl1.StoredTask.Status == TennantTaskStatus.Completed)
            {
                btnFail.Enabled = false;
            }
            else if (taskControl1.StoredTask.Status == TennantTaskStatus.Failed)
            {
                btnComplete.Enabled = false;
            }
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            TennantTaskHandler.CompleteTask(taskControl1.StoredTask);
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            TennantTaskHandler.FailTask(taskControl1.StoredTask);
        }
    }
}
