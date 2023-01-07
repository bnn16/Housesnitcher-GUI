using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    public partial class CompactComplaintControl : UserControl
    {
        Complaint? _complaint;
        public Complaint UpdateUsingObject
        {
            set
            {
                _complaint = value;
                lblDate.Text = value.DateCreated.ToString();
                lblDateReference.Text = value.DateHappened.ToString();
                lblStatus.Text = value.Status.ToString();
                lblTitle.Text = value.Title;
                PaintColor(value.Status);
            }
        }

        // remember to give data to the control using the UpdateUsingObject property.
        public CompactComplaintControl()
        {
            InitializeComponent();
        }

        public CompactComplaintControl(Complaint complaint)
        {
            InitializeComponent();
            UpdateUsingObject = complaint;
        }
        private void PaintColor(ComplaintStatus status)
        {
            lblStatus.ForeColor = status switch
            {
                ComplaintStatus.Failed => Color.Red,
                ComplaintStatus.Created => Color.Black,
                ComplaintStatus.Acknowledged => Color.Orange,
                ComplaintStatus.Reviewed => Color.YellowGreen,
                ComplaintStatus.Resolved => Color.Green,
                _ => Color.Aqua,
            };
        }
    }
}
