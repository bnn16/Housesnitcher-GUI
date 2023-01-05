using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    public partial class AdminComplaintControl : UserControl
    {
        public AdminComplaintControl(Complaint complaint)
        {
            InitializeComponent();
            ComplaintControlView.UpdateUsingObject = complaint;
            ActivateButton();
        }

        // based on the status, activate buttons
        private void ActivateButton()
        {
            btnAcknowledge.Enabled = false;
            btnResolve.Enabled = false;
            btnResolve.Enabled = false;
            btnReview.Enabled = false;
            btnInvalidate.Enabled = true;

            switch (ComplaintControlView.StoredComplaint.Status)
            {
                case ComplaintStatus.Created:
                    btnAcknowledge.Enabled = true;
                    break;
                case ComplaintStatus.Acknowledged:
                    btnResolve.Enabled = true;
                    break;
                case ComplaintStatus.Reviewed:
                    btnResolve.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
