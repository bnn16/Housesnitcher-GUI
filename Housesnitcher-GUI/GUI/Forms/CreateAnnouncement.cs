using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.GUI.Events;
using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class CreateAnnouncement : Form
    {
        User _user;
        public CreateAnnouncement(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AnnouncementHandler.CreateAnnouncement(new Announcement(
                tbTitle.Text,
                tbDescription.Text,
                _user.Username,
                dtpDateReferenced.Value.Date));
            ForceRefreshEvent.RaiseRefreshEvent(this, new EventArgs());
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
