namespace Housesnitcher_GUI
{
    partial class LoggedInView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblUser;
            System.Windows.Forms.Label lblPerm;
            this.scrollAnn = new System.Windows.Forms.VScrollBar();
            this.panelComplain = new System.Windows.Forms.Panel();
            this.panelAnnounces = new System.Windows.Forms.Panel();
            this.scrollComplain = new System.Windows.Forms.VScrollBar();
            this.btnComplain = new System.Windows.Forms.Button();
            this.btnAnnounce = new System.Windows.Forms.Button();
            this.lblWritePerm = new System.Windows.Forms.Label();
            this.lblWriteUser = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();
            lblPerm = new System.Windows.Forms.Label();
            this.panelComplain.SuspendLayout();
            this.panelAnnounces.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollAnn
            // 
            this.scrollAnn.Location = new System.Drawing.Point(219, 0);
            this.scrollAnn.Name = "scrollAnn";
            this.scrollAnn.Size = new System.Drawing.Size(17, 266);
            this.scrollAnn.TabIndex = 0;
            // 
            // panelComplain
            // 
            this.panelComplain.Controls.Add(this.scrollComplain);
            this.panelComplain.Location = new System.Drawing.Point(30, 57);
            this.panelComplain.Name = "panelComplain";
            this.panelComplain.Size = new System.Drawing.Size(236, 266);
            this.panelComplain.TabIndex = 1;
            // 
            // panelAnnounces
            // 
            this.panelAnnounces.Controls.Add(this.scrollAnn);
            this.panelAnnounces.Location = new System.Drawing.Point(542, 57);
            this.panelAnnounces.Name = "panelAnnounces";
            this.panelAnnounces.Size = new System.Drawing.Size(236, 266);
            this.panelAnnounces.TabIndex = 2;
            // 
            // scrollComplain
            // 
            this.scrollComplain.Location = new System.Drawing.Point(219, 0);
            this.scrollComplain.Name = "scrollComplain";
            this.scrollComplain.Size = new System.Drawing.Size(17, 266);
            this.scrollComplain.TabIndex = 1;
            // 
            // btnComplain
            // 
            this.btnComplain.Location = new System.Drawing.Point(383, 57);
            this.btnComplain.Name = "btnComplain";
            this.btnComplain.Size = new System.Drawing.Size(75, 23);
            this.btnComplain.TabIndex = 3;
            this.btnComplain.Text = "Complain";
            this.btnComplain.UseVisualStyleBackColor = true;
            // 
            // btnAnnounce
            // 
            this.btnAnnounce.Location = new System.Drawing.Point(383, 86);
            this.btnAnnounce.Name = "btnAnnounce";
            this.btnAnnounce.Size = new System.Drawing.Size(75, 23);
            this.btnAnnounce.TabIndex = 4;
            this.btnAnnounce.Text = "Announce";
            this.btnAnnounce.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new System.Drawing.Point(30, 13);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(32, 13);
            lblUser.TabIndex = 5;
            lblUser.Text = "User:";
            // 
            // lblPerm
            // 
            lblPerm.AutoSize = true;
            lblPerm.Location = new System.Drawing.Point(30, 41);
            lblPerm.Name = "lblPerm";
            lblPerm.Size = new System.Drawing.Size(85, 13);
            lblPerm.TabIndex = 6;
            lblPerm.Text = "Permission level:";
            // 
            // lblWritePerm
            // 
            this.lblWritePerm.AutoSize = true;
            this.lblWritePerm.Location = new System.Drawing.Point(121, 41);
            this.lblWritePerm.Name = "lblWritePerm";
            this.lblWritePerm.Size = new System.Drawing.Size(49, 13);
            this.lblWritePerm.TabIndex = 7;
            this.lblWritePerm.Text = "NullPerm";
            // 
            // lblWriteUser
            // 
            this.lblWriteUser.AutoSize = true;
            this.lblWriteUser.Location = new System.Drawing.Point(68, 13);
            this.lblWriteUser.Name = "lblWriteUser";
            this.lblWriteUser.Size = new System.Drawing.Size(47, 13);
            this.lblWriteUser.TabIndex = 8;
            this.lblWriteUser.Text = "NullUser";
            // 
            // LoggedInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWriteUser);
            this.Controls.Add(this.lblWritePerm);
            this.Controls.Add(lblPerm);
            this.Controls.Add(lblUser);
            this.Controls.Add(this.btnAnnounce);
            this.Controls.Add(this.btnComplain);
            this.Controls.Add(this.panelAnnounces);
            this.Controls.Add(this.panelComplain);
            this.Name = "LoggedInView";
            this.Text = "Form1";
            this.panelComplain.ResumeLayout(false);
            this.panelAnnounces.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar scrollAnn;
        private System.Windows.Forms.Panel panelComplain;
        private System.Windows.Forms.VScrollBar scrollComplain;
        private System.Windows.Forms.Panel panelAnnounces;
        private System.Windows.Forms.Button btnComplain;
        private System.Windows.Forms.Button btnAnnounce;
        private System.Windows.Forms.Label lblWritePerm;
        private System.Windows.Forms.Label lblWriteUser;
    }
}