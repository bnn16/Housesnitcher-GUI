using Housesnitcher_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    public partial class PersonalUserComplaintControl : UserControl
    {
        public Complaint UpdateUsingObject { set
            {
                ComplaintControlView.UpdateUsingObject = value;
                rtbFeedback.Text = value.ComplaintFeedback ?? "No feedback received Yet.";
            } }
        public PersonalUserComplaintControl()
        {
            InitializeComponent();
        }

        public PersonalUserComplaintControl(Complaint complaint)
        {
            InitializeComponent();
            UpdateUsingObject = complaint;
        }
    }
}
