using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.GUI.Controls;
using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class MainForm : Form
    {
        User _user;
        public MainForm(User user)
        {
            _user = user;
            foreach (var complaint in ComplaintHandler.AllComplaints())
            {
                tlpComplaintsHome.Controls.Add(new ComplaintControl(complaint));
            }
            InitializeComponent();
        }
    }
}