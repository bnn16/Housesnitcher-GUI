namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    partial class AdminComplaintControl
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
            this.ComplaintControlView = new Housesnitcher_GUI.GUI.Controls.ComplaintControl();
            this.btnAcknowledge = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnInvalidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComplaintControlView
            // 
            this.ComplaintControlView.Location = new System.Drawing.Point(0, 0);
            this.ComplaintControlView.Name = "ComplaintControlView";
            this.ComplaintControlView.Size = new System.Drawing.Size(300, 200);
            this.ComplaintControlView.TabIndex = 0;
            // 
            // btnAcknowledge
            // 
            this.btnAcknowledge.AutoSize = true;
            this.btnAcknowledge.Enabled = false;
            this.btnAcknowledge.Location = new System.Drawing.Point(306, 16);
            this.btnAcknowledge.Name = "btnAcknowledge";
            this.btnAcknowledge.Size = new System.Drawing.Size(89, 25);
            this.btnAcknowledge.TabIndex = 1;
            this.btnAcknowledge.Text = "Acknowledge";
            this.btnAcknowledge.UseVisualStyleBackColor = true;
            // 
            // btnReview
            // 
            this.btnReview.AutoSize = true;
            this.btnReview.Enabled = false;
            this.btnReview.Location = new System.Drawing.Point(306, 47);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(89, 25);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // btnResolve
            // 
            this.btnResolve.AutoSize = true;
            this.btnResolve.Enabled = false;
            this.btnResolve.Location = new System.Drawing.Point(306, 78);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(89, 25);
            this.btnResolve.TabIndex = 3;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            // 
            // btnInvalidate
            // 
            this.btnInvalidate.AutoSize = true;
            this.btnInvalidate.Location = new System.Drawing.Point(306, 159);
            this.btnInvalidate.Name = "btnInvalidate";
            this.btnInvalidate.Size = new System.Drawing.Size(89, 25);
            this.btnInvalidate.TabIndex = 4;
            this.btnInvalidate.Text = "Invalidate";
            this.btnInvalidate.UseVisualStyleBackColor = true;
            // 
            // AdminComplaintControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInvalidate);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnAcknowledge);
            this.Controls.Add(this.ComplaintControlView);
            this.Name = "AdminComplaintControl";
            this.Size = new System.Drawing.Size(400, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComplaintControl ComplaintControlView;
        private Button btnAcknowledge;
        private Button btnReview;
        private Button btnResolve;
        private Button btnInvalidate;
    }
}
