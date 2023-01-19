using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls
{
    public partial class AnnouncementControl : UserControl
    {
        Announcement _announcement;
        public Announcement StoredAnnouncement
        {
            get { return _announcement; }
        }

        public Announcement UpdateUsingObject
        {
            set
            {
                _announcement = value;
                lblTitle.Text = value.Title;
                lblAnnounced.Text = value.Announced.ToString();
                lblDateReferenced.Text = value.ReferredDate.ToString();
                lblAnnouncer.Text = value.Announcer;
                tbDescription.Text = value.Description;
            }
        }
        public AnnouncementControl(Announcement announcement)
        {
            InitializeComponent();
            UpdateUsingObject = announcement;
        }
    }
}
