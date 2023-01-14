using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.GUI.Controls;
using Housesnitcher_GUI.GUI.Controls.Complaints;
using Housesnitcher_GUI.Models;
using Housesnitcher_GUI.StateManagement;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class MainForm : Form
    {
        User _user { get; }
        // initializing the whole form and filling in the different data.
        void HydratePages()
        {
            {
                flpComplaintsHome.Controls.Clear();
                flpMyComplaints.Controls.Clear();
                flpInShort.Controls.Clear();
                flowTasksHome.Controls.Clear();
                cbType.Items.Clear();
                foreach (var type in State.complaintTypes)
                {
                    cbType.Items.Add(type);
                    cbType.AutoCompleteCustomSource.Add(type);
                }

                // populate the homepage
                foreach (var complaint in ComplaintHandler.AllComplaints().Take(10))
                {
                    flpComplaintsHome.Controls.Add(new AdminComplaintControl(complaint));
                }

                foreach (var task in TennantTaskHandler.AllTasks().Take(10))
                {
                    flowTasksHome.Controls.Add(new TaskControl(task));
                }

                // populate the user-specific page
                foreach (var complaint in ComplaintHandler.SpecificUserComplaints(_user))
                {
                    flpMyComplaints.Controls.Add(new PersonalUserComplaintControl(complaint));
                }

                // populate in-short section
                foreach (var complaint in ComplaintHandler.SpecificUserComplaints(_user))
                {
                    flpInShort.Controls.Add(new CompactComplaintControl(complaint));
                }
            }
        }
        public MainForm(User user)
        {
            // reminder to the next person: keep this at the top ffs. Second time I fall for this in an hour.
            _user = user;
            InitializeComponent();
            ShowAppropriatePages();
            // if you have other important things to add to here, please respect the order.

            lblUserData.Text = _user.ToString();
            HydratePages();
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
            ComplaintHandler.LodgeComplaint(new Complaint(tbTitle.Text, tbDescription.Text, _user.Username, cbType.Text, ComplaintStatus.Created, null, dtHappened.Value));
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

        // logout button, duh.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }

        private void HomeTabControl_Selected(object sender, TabControlEventArgs e)
        {
            HydratePages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CreateTaskForm().Show();
        }
    }
}