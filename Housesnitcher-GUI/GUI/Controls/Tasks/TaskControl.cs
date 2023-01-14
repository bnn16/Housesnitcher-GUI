using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls
{
    public partial class TaskControl : UserControl
    {
        public DateTime Date
        {
            get
            {
                return DateTime.Parse(lblDate.Text);
            }
        }
        public DateTime DateReference
        {
            get
            {
                return DateTime.Parse(lblDateReference.Text);
            }
        }
        public TennantTaskStatus Status
        {
            get
            {
                return Enum.Parse<TennantTaskStatus>(lblStatus.Text);
            }
            set
            {
                lblStatus.Text = value.ToString();
            }
        }
        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
        }
        public string Description
        {
            get
            {
                return rtbDescription.Text;
            }
        }
        public string Username
        {
            get
            {
                return lblAssign.Text;
            }
        }
        public TennantTask UpdateUsingObject
        {
            set
            {
                lblDate.Text = value.DateCreated.ToString();
                lblDateReference.Text = value.DateDue.ToString();
                lblStatus.Text = value.Status.ToString();
                lblTitle.Text = value.Title;
                lblAssign.Text = value.Username;
                rtbDescription.Text = value.Description;
                PaintColor(value.Status);
            }
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
