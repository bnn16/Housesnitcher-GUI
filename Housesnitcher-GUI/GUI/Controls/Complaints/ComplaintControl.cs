using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls
{
    public partial class ComplaintControl : UserControl
    {
        private Complaint? _complaint = null;
        public Complaint StoredComplaint
        {
            get
            {
                return _complaint;
            }
        }
        public Complaint UpdateUsingObject
        {
            set
            {
                _complaint = value;
                lblDate.Text = value.DateCreated.ToString();
                lblDateReference.Text = value.DateHappened.Date.ToString().Split()[0];
                lblStatus.Text = value.Status.ToString();
                lblTitle.Text = value.Title;
                rtbDescription.Text = value.Description;
                PaintColor(value.Status);
            }
        }

        // when using the default constructor, make sure to set the values using the `UpdateUsingObject` property.
        public ComplaintControl()
        {
            InitializeComponent();
        }
        public ComplaintControl(Complaint complaint)
        {
            _complaint = complaint;
            InitializeComponent();
            lblDate.Text = complaint.DateCreated.ToString();
            lblDateReference.Text = complaint.DateHappened.ToString();
            lblStatus.Text = complaint.Status.ToString();
            lblTitle.Text = complaint.Title;
            rtbDescription.Text = complaint.Description;
            PaintColor(complaint.Status);
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
