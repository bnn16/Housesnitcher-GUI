namespace Housesnitcher_GUI.GUI.Controls
{
    partial class TaskControl
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDateReference = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAssign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(219, 229);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 20);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "TaskStatus";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Location = new System.Drawing.Point(0, 76);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(343, 128);
            this.rtbDescription.TabIndex = 8;
            this.rtbDescription.Text = "TaskRtbDescription";
            // 
            // lblDateReference
            // 
            this.lblDateReference.AutoSize = true;
            this.lblDateReference.Location = new System.Drawing.Point(181, 52);
            this.lblDateReference.Name = "lblDateReference";
            this.lblDateReference.Size = new System.Drawing.Size(134, 20);
            this.lblDateReference.TabIndex = 7;
            this.lblDateReference.Text = "TaskDateReference";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(181, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "TaskDate";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 20);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "TaskTitle";
            // 
            // lblAssign
            // 
            this.lblAssign.AutoSize = true;
            this.lblAssign.Location = new System.Drawing.Point(18, 229);
            this.lblAssign.Name = "lblAssign";
            this.lblAssign.Size = new System.Drawing.Size(75, 20);
            this.lblAssign.TabIndex = 10;
            this.lblAssign.Text = "Username";
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblAssign);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDateReference);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(339, 263);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStatus;
        private RichTextBox rtbDescription;
        private Label lblDateReference;
        private Label lblDate;
        private Label lblTitle;
        private Label lblAssign;
    }
}
