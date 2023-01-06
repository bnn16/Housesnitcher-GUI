using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.GUI.Controls;
using Housesnitcher_GUI.Models;
using System.Diagnostics;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class MainForm : Form
    {
        User _user;
        public MainForm(User user)
        {
            // reminder to the next person: keep this at the top ffs. Second time I fall for this in an hour.
            InitializeComponent();
            
            
            _user = user;
            foreach (var complaint in ComplaintHandler.AllComplaints())
            {
                flpComplaintsHome.Controls.Add(new ComplaintControl(complaint));
            }
        }
    }
}