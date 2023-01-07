using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    public partial class AdminComplaintControl : UserControl
    {
        public Complaint UpdateUsingObject
        { set {
                ComplaintControlView.UpdateUsingObject = value;
                ActivateButton();
            } }
        public AdminComplaintControl(Complaint complaint)
        {
            InitializeComponent();
            UpdateUsingObject = complaint;
            lblComplainer.Text = complaint.Username;
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
                    btnReview.Enabled = true;
                    break;
                case ComplaintStatus.Reviewed:
                    btnResolve.Enabled = true;
                    break;
                case ComplaintStatus.Resolved:
                    btnInvalidate.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            var ret = ComplaintHandler.FailComplaint(ComplaintControlView.StoredComplaint);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            var ret = ComplaintHandler.ResolveComplaint(ComplaintControlView.StoredComplaint);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
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
            UpdateUsingObject = ret;
        }

        private void btnConfirmReview_Click(object sender, EventArgs e)
        {
            var ret = ComplaintHandler.ReviewComplaint(ComplaintControlView.StoredComplaint, tbReviewText.Text);
            ResolvePanel.Hide();
            _ = ret ?? throw new NullReferenceException();
            ComplaintControlView.Show();
            UpdateUsingObject = ret;
        }
    }
}
