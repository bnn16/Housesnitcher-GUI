namespace Housesnitcher_GUI.GUI.Controls
{
    partial class AnnouncementControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAnnounced = new System.Windows.Forms.Label();
            this.lblDateReferenced = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblAnnouncer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblAnnounced
            // 
            this.lblAnnounced.AutoSize = true;
            this.lblAnnounced.Location = new System.Drawing.Point(141, 9);
            this.lblAnnounced.Name = "lblAnnounced";
            this.lblAnnounced.Size = new System.Drawing.Size(100, 15);
            this.lblAnnounced.TabIndex = 1;
            this.lblAnnounced.Text = "WhenAnnounced";
            // 
            // lblDateReferenced
            // 
            this.lblDateReferenced.AutoSize = true;
            this.lblDateReferenced.Location = new System.Drawing.Point(141, 34);
            this.lblDateReferenced.Name = "lblDateReferenced";
            this.lblDateReferenced.Size = new System.Drawing.Size(69, 15);
            this.lblDateReferenced.TabIndex = 2;
            this.lblDateReferenced.Text = "Announced";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(0, 52);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(286, 75);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Text = "Description";
            // 
            // lblAnnouncer
            // 
            this.lblAnnouncer.AutoSize = true;
            this.lblAnnouncer.Location = new System.Drawing.Point(3, 133);
            this.lblAnnouncer.Name = "lblAnnouncer";
            this.lblAnnouncer.Size = new System.Drawing.Size(66, 15);
            this.lblAnnouncer.TabIndex = 4;
            this.lblAnnouncer.Text = "Announcer";
            // 
            // AnnouncementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblAnnouncer);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDateReferenced);
            this.Controls.Add(this.lblAnnounced);
            this.Controls.Add(this.lblTitle);
            this.Name = "AnnouncementControl";
            this.Size = new System.Drawing.Size(282, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblAnnounced;
        private Label lblDateReferenced;
        private TextBox tbDescription;
        private Label lblAnnouncer;
    }
}
