﻿using Housesnitcher_GUI.Models;

namespace Housesnitcher_GUI.GUI.Controls
{
    public partial class ComplaintControl : UserControl
    {
        public DateTime Date
        {
            get
            {
                return DateTime.Parse(lblDate.Text);
            }
        }
        public DateTime DateReference
        {
            get
            {
                return DateTime.Parse(lblDateReference.Text);
            }
        }
        public ComplaintStatus Status
        {
            get
            {
                return Enum.Parse<ComplaintStatus>(lblStatus.Text);
            }
            set
            {
                lblStatus.Text = value.ToString();
            }
        }
        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
        }
        public string Description
        {
            get
            {
                return rtbDescription.Text;
            }
        }

        public Complaint UpdateUsingObject
        {
            set
            {
                lblDate.Text = value.DateCreated.ToString();
                lblDateReference.Text = value.DateHappened.ToString();
                lblStatus.Text = value.Status.ToString();
                lblTitle.Text = value.Title;
                rtbDescription.Text = value.Description;
                PaintColor(value.Status);
            }
        }
        public ComplaintControl(Complaint complaint)
        {
            InitializeComponent();
            lblDate.Text = complaint.DateCreated.ToString();
            lblDateReference.Text = complaint.DateHappened.ToString();
            lblStatus.Text = complaint.Status.ToString();
            lblTitle.Text = complaint.Title;
            rtbDescription.Text = complaint.Description;
            PaintColor(complaint.Status);
        }
        private void PaintColor(ComplaintStatus status)
        {
            lblStatus.ForeColor = status switch
            {
                ComplaintStatus.Failed => Color.Red,
                ComplaintStatus.Created => Color.Black,
                ComplaintStatus.Acknowledged => Color.Yellow,
                ComplaintStatus.Reviewed => Color.YellowGreen,
                ComplaintStatus.Resolved => Color.Green,
                _ => Color.Aqua,
            };
        }
    }
}
