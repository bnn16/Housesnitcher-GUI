using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls
{
    public partial class TaskControl : UserControl
    {
        private TennantTask _task;
        public TennantTask StoredTask
        {
            get
            {
                return _task;
            }
        }
        
        public TennantTask UpdateUsingObject
        {
            set
            {
                _task = value;
                lblDate.Text = value.DateCreated.ToString();
                lblDateReference.Text = value.DateDue.ToString();
                lblStatus.Text = value.Status.ToString();
                lblTitle.Text = value.Title;
                lblAssign.Text = value.Username;
                rtbDescription.Text = value.Description;
                PaintColor(value.Status);
            }
        }
        // remember to give data using the UpdateUsingObject property
        public TaskControl()
        {
            InitializeComponent();
        }
        public TaskControl(TennantTask task)
        {
            InitializeComponent();
            lblDate.Text = task.DateCreated.ToString();
            lblDateReference.Text = task.DateDue.ToString();
            lblStatus.Text = task.Status.ToString();
            lblTitle.Text = task.Title;
            lblAssign.Text = task.Username;
            rtbDescription.Text = task.Description;
            PaintColor(task.Status);
        }
        private void PaintColor(TennantTaskStatus status)
        {
            lblStatus.ForeColor = status switch
            {
                TennantTaskStatus.Failed => Color.Red,
                TennantTaskStatus.Assigned => Color.Black,
                TennantTaskStatus.Completed => Color.Green,
                _ => Color.Aqua,
            };
        }
    }
}
