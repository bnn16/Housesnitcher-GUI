namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    partial class CompactComplaintControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDateReference = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Date ref:";
            label1.Click += new System.EventHandler(this.CompactComplaintControl_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Created:";
            label2.Click += new System.EventHandler(this.CompactComplaintControl_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.Click += new System.EventHandler(this.CompactComplaintControl_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.CompactComplaintControl_Click);
            // 
            // lblDateReference
            // 
            this.lblDateReference.AutoSize = true;
            this.lblDateReference.Location = new System.Drawing.Point(73, 54);
            this.lblDateReference.Name = "lblDateReference";
            this.lblDateReference.Size = new System.Drawing.Size(139, 15);
            this.lblDateReference.TabIndex = 4;
            this.lblDateReference.Text = "ComplaintDateReference";
            this.lblDateReference.Click += new System.EventHandler(this.CompactComplaintControl_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(73, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "ComplaintDate";
            this.lblDate.Click += new System.EventHandler(this.CompactComplaintControl_Click);
            // 
            // CompactComplaintControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.lblDateReference);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Name = "CompactComplaintControl";
            this.Size = new System.Drawing.Size(215, 102);
            this.Click += new System.EventHandler(this.CompactComplaintControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblStatus;
        private Label lblDateReference;
        private Label lblDate;
    }
}
