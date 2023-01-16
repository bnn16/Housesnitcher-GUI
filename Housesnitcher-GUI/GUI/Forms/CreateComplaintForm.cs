using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.Models;
using Housesnitcher_GUI.StateManagement;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class CreateComplaintForm : Form
    {
        private string? _user { get; set; }

        public CreateComplaintForm()
        {
            InitializeComponent();
        }

        public CreateComplaintForm(string _user) {
            InitializeComponent();
            foreach (var type in State.complaintTypes)
            {
                cbType.Items.Add(type);
                cbType.AutoCompleteCustomSource.Add(type);
            }
            //labeluser.Text = _user;
            this._user = _user;
        }
        private void btnCreateComplaint_Click_1(object sender, EventArgs e)
        {
            ComplaintHandler.LodgeComplaint(new Complaint(tbTitle.Text, tbDescription.Text, _user, cbType.Text, ComplaintStatus.Created, null, dtHappened.Value));
            MessageBox.Show("Complaint Created!", "Success");
            tbTitle.Text = "";
            tbDescription.Text = "";
        }
    }
}
