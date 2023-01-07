using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    public partial class PersonalUserComplaintControl : UserControl
    {
        public Complaint UpdateUsingObject
        {
            set
            {
                ComplaintControlView.UpdateUsingObject = value;
                rtbFeedback.Text = value.ComplaintFeedback ?? "No feedback received Yet.";
            }
        }
        public PersonalUserComplaintControl()
        {
            InitializeComponent();
        }

        public PersonalUserComplaintControl(Complaint complaint)
        {
            InitializeComponent();
            UpdateUsingObject = complaint;
        }
    }
}
