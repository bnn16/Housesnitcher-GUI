using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    public partial class AdminComplaintControl : UserControl
    {
        public AdminComplaintControl(Complaint complaint)
        {
            InitializeComponent();
            ComplaintControlView.UpdateUsingObject = complaint;
            lblComplainer.Text = complaint.Username;
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
        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            var ret = ComplaintHandler.FailComplaint(ComplaintControlView.StoredComplaint);
            _ = ret ?? throw new NullReferenceException();
            ComplaintControlView.UpdateUsingObject = ret;
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            var ret = ComplaintHandler.ResolveComplaint(ComplaintControlView.StoredComplaint);
            _ = ret ?? throw new NullReferenceException();
            ComplaintControlView.UpdateUsingObject = ret;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ComplaintControlView.Hide();
            ResolvePanel.Show();
        }

        private void btnAcknowledge_Click(object sender, EventArgs e)
        {
            var ret = ComplaintHandler.AcknowledgeComplaint(ComplaintControlView.StoredComplaint);
            _ = ret ?? throw new NullReferenceException();
            ComplaintControlView.UpdateUsingObject = ret;
        }

        private void btnConfirmReview_Click(object sender, EventArgs e)
        {
            var ret = ComplaintHandler.ReviewComplaint(ComplaintControlView.StoredComplaint, tbReviewText.Text);
            ResolvePanel.Hide();
            _ = ret ?? throw new NullReferenceException();
            ComplaintControlView.Show();
            ComplaintControlView.UpdateUsingObject = ret;
        }
    }
}
