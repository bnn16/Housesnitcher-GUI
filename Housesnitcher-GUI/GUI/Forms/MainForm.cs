using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.GUI.Controls.Complaints;
using Housesnitcher_GUI.Models;
using Housesnitcher_GUI.StateManagement;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class MainForm : Form
    {
        User _user { get; }
        // initializing the whole form and filling in the different data.
        public MainForm(User user)
        {
            // reminder to the next person: keep this at the top ffs. Second time I fall for this in an hour.
            _user = user;
            InitializeComponent();
            ShowAppropriatePages();
            // if you have other important things to add to here, please respect the order.

            lblUserData.Text = _user.ToString();

            foreach (var type in State.complaintTypes)
            {
                cbType.Items.Add(type);
                cbType.AutoCompleteCustomSource.Add(type);
            }

            foreach (var complaint in ComplaintHandler.AllComplaints().Take(10))
            {
                flpComplaintsHome.Controls.Add(new AdminComplaintControl(complaint));
            }
            foreach (var complaint in ComplaintHandler.SpecificUserComplaints(_user))
            {
                flpMyComplaints.Controls.Add(new PersonalUserComplaintControl(complaint));
            }
        }


        // complaints creation section of the code, boring stuff.
        private void btnLodgeComplaint_Click(object sender, EventArgs e)
        {
            flpMyComplaints.Hide();
            pLodgeComplaint.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            flpMyComplaints.Show();
            pLodgeComplaint.Hide();
        }

        private void btnCreateComplaint_Click(object sender, EventArgs e)
        {
            ComplaintHandler.LodgeComplaint(new Complaint(tbTitle.Text, tbDescription.Text, _user.Username, cbType.Text, dtHappened.Value));
        }

        // after login check which pages should be shown
        private void ShowAppropriatePages()
        {
            HomeTabControl.TabPages.Clear();
            HomeTabControl.TabPages.Add(tpHomepage);

            if (_user.AuthLevel == ScopeLevel.None)
            {
                return;
            }
            HomeTabControl.TabPages.Add(tpSelf);
            if (_user.AuthLevel == ScopeLevel.Admin)
            {
                HomeTabControl.TabPages.Add(tpAdmin);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }
    }
}