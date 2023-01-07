namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    partial class PersonalUserComplaintControl
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
            this.ComplaintControlView = new Housesnitcher_GUI.GUI.Controls.ComplaintControl();
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComplaintControlView
            // 
            this.ComplaintControlView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ComplaintControlView.Location = new System.Drawing.Point(0, 0);
            this.ComplaintControlView.Name = "ComplaintControlView";
            this.ComplaintControlView.Size = new System.Drawing.Size(300, 200);
            this.ComplaintControlView.TabIndex = 0;
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFeedback.Location = new System.Drawing.Point(303, 31);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.Size = new System.Drawing.Size(144, 146);
            this.rtbFeedback.TabIndex = 1;
            this.rtbFeedback.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(306, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Feedback from admin:";
            // 
            // PersonalUserComplaintControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label1);
            this.Controls.Add(this.rtbFeedback);
            this.Controls.Add(this.ComplaintControlView);
            this.Name = "PersonalUserComplaintControl";
            this.Size = new System.Drawing.Size(450, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComplaintControl ComplaintControlView;
        private RichTextBox rtbFeedback;
    }
}
