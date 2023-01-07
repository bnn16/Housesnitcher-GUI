namespace Housesnitcher_GUI.GUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label shitLabel;
            System.Windows.Forms.Label label5;
            this.HomeTabControl = new System.Windows.Forms.TabControl();
            this.tpHomepage = new System.Windows.Forms.TabPage();
            this.tbLoggedInAs = new System.Windows.Forms.TextBox();
            this.flpComplaintsHome = new System.Windows.Forms.FlowLayoutPanel();
            this.tpSelf = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateComplaint = new System.Windows.Forms.Button();
            this.dtHappened = new System.Windows.Forms.DateTimePicker();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLodgeComplaint = new System.Windows.Forms.Button();
            this.flpMyComplaints = new System.Windows.Forms.FlowLayoutPanel();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            shitLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.HomeTabControl.SuspendLayout();
            this.tpHomepage.SuspendLayout();
            this.tpSelf.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(76, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Last 10 complaints";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 61);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 15);
            label3.TabIndex = 0;
            label3.Text = "My complaints:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(25, 125);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 15);
            label4.TabIndex = 37;
            label4.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 15);
            label2.TabIndex = 35;
            label2.Text = "Date happened:";
            // 
            // shitLabel
            // 
            shitLabel.AutoSize = true;
            shitLabel.Location = new System.Drawing.Point(63, 14);
            shitLabel.Name = "shitLabel";
            shitLabel.Size = new System.Drawing.Size(32, 15);
            shitLabel.TabIndex = 34;
            shitLabel.Text = "Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(449, 50);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 15);
            label5.TabIndex = 6;
            label5.Text = "In short...";
            // 
            // HomeTabControl
            // 
            this.HomeTabControl.Controls.Add(this.tpHomepage);
            this.HomeTabControl.Controls.Add(this.tpSelf);
            this.HomeTabControl.Controls.Add(this.tpAdmin);
            this.HomeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeTabControl.Location = new System.Drawing.Point(0, 0);
            this.HomeTabControl.Name = "HomeTabControl";
            this.HomeTabControl.SelectedIndex = 0;
            this.HomeTabControl.Size = new System.Drawing.Size(1013, 601);
            this.HomeTabControl.TabIndex = 0;
            // 
            // tpHomepage
            // 
            this.tpHomepage.Controls.Add(this.tbLoggedInAs);
            this.tpHomepage.Controls.Add(this.flpComplaintsHome);
            this.tpHomepage.Controls.Add(label1);
            this.tpHomepage.Location = new System.Drawing.Point(4, 24);
            this.tpHomepage.Name = "tpHomepage";
            this.tpHomepage.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomepage.Size = new System.Drawing.Size(1005, 573);
            this.tpHomepage.TabIndex = 0;
            this.tpHomepage.Text = "Homepage";
            this.tpHomepage.UseVisualStyleBackColor = true;
            // 
            // tbLoggedInAs
            // 
            this.tbLoggedInAs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoggedInAs.Location = new System.Drawing.Point(902, 3);
            this.tbLoggedInAs.Multiline = true;
            this.tbLoggedInAs.Name = "tbLoggedInAs";
            this.tbLoggedInAs.Size = new System.Drawing.Size(100, 66);
            this.tbLoggedInAs.TabIndex = 5;
            // 
            // flpComplaintsHome
            // 
            this.flpComplaintsHome.AutoScroll = true;
            this.flpComplaintsHome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpComplaintsHome.Location = new System.Drawing.Point(19, 94);
            this.flpComplaintsHome.Name = "flpComplaintsHome";
            this.flpComplaintsHome.Size = new System.Drawing.Size(323, 476);
            this.flpComplaintsHome.TabIndex = 2;
            this.flpComplaintsHome.WrapContents = false;
            // 
            // tpSelf
            // 
            this.tpSelf.Controls.Add(this.panel1);
            this.tpSelf.Controls.Add(this.flowLayoutPanel1);
            this.tpSelf.Controls.Add(label5);
            this.tpSelf.Controls.Add(this.btnLodgeComplaint);
            this.tpSelf.Controls.Add(this.flpMyComplaints);
            this.tpSelf.Controls.Add(label3);
            this.tpSelf.Location = new System.Drawing.Point(4, 24);
            this.tpSelf.Name = "tpSelf";
            this.tpSelf.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelf.Size = new System.Drawing.Size(1005, 573);
            this.tpSelf.TabIndex = 1;
            this.tpSelf.Text = "Self";
            this.tpSelf.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnCreateComplaint);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.dtHappened);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(shitLabel);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(8, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 403);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(99, 53);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(233, 23);
            this.cbType.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateComplaint
            // 
            this.btnCreateComplaint.AutoSize = true;
            this.btnCreateComplaint.Location = new System.Drawing.Point(191, 337);
            this.btnCreateComplaint.Name = "btnCreateComplaint";
            this.btnCreateComplaint.Size = new System.Drawing.Size(110, 25);
            this.btnCreateComplaint.TabIndex = 38;
            this.btnCreateComplaint.Text = "Create Complaint";
            this.btnCreateComplaint.UseVisualStyleBackColor = true;
            this.btnCreateComplaint.Click += new System.EventHandler(this.btnCreateComplaint_Click);
            // 
            // dtHappened
            // 
            this.dtHappened.Location = new System.Drawing.Point(99, 92);
            this.dtHappened.Name = "dtHappened";
            this.dtHappened.Size = new System.Drawing.Size(233, 23);
            this.dtHappened.TabIndex = 36;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Location = new System.Drawing.Point(99, 125);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(7);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "a small description of what your problem is";
            this.tbDescription.Size = new System.Drawing.Size(233, 173);
            this.tbDescription.TabIndex = 32;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Location = new System.Drawing.Point(99, 14);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(7);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PlaceholderText = "A quick title for what your problem is";
            this.tbTitle.Size = new System.Drawing.Size(233, 32);
            this.tbTitle.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(61, 56);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Type:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(484, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnLodgeComplaint
            // 
            this.btnLodgeComplaint.AutoSize = true;
            this.btnLodgeComplaint.Location = new System.Drawing.Point(8, 20);
            this.btnLodgeComplaint.Name = "btnLodgeComplaint";
            this.btnLodgeComplaint.Size = new System.Drawing.Size(109, 25);
            this.btnLodgeComplaint.TabIndex = 5;
            this.btnLodgeComplaint.Text = "Lodge Complaint";
            this.btnLodgeComplaint.UseVisualStyleBackColor = true;
            this.btnLodgeComplaint.Click += new System.EventHandler(this.btnLodgeComplaint_Click);
            // 
            // flpMyComplaints
            // 
            this.flpMyComplaints.AutoScroll = true;
            this.flpMyComplaints.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMyComplaints.Location = new System.Drawing.Point(0, 79);
            this.flpMyComplaints.Name = "flpMyComplaints";
            this.flpMyComplaints.Size = new System.Drawing.Size(469, 488);
            this.flpMyComplaints.TabIndex = 3;
            this.flpMyComplaints.WrapContents = false;
            // 
            // tpAdmin
            // 
            this.tpAdmin.Location = new System.Drawing.Point(4, 24);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Size = new System.Drawing.Size(1005, 573);
            this.tpAdmin.TabIndex = 2;
            this.tpAdmin.Text = "Administration";
            this.tpAdmin.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 601);
            this.Controls.Add(this.HomeTabControl);
            this.Name = "MainForm";
            this.Text = "HouseSnitcher";
            this.HomeTabControl.ResumeLayout(false);
            this.tpHomepage.ResumeLayout(false);
            this.tpHomepage.PerformLayout();
            this.tpSelf.ResumeLayout(false);
            this.tpSelf.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl HomeTabControl;
        private TabPage tpHomepage;
        private TabPage tpSelf;
        private FlowLayoutPanel flpComplaintsHome;
        private TextBox tbLoggedInAs;
        private TabPage tpAdmin;
        private FlowLayoutPanel flpMyComplaints;
        private Panel panel1;
        private Button btnCreateComplaint;
        private DateTimePicker dtHappened;
        private TextBox tbDescription;
        private TextBox tbTitle;
        private Label label13;
        private Button btnLodgeComplaint;
        private Button btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cbType;
    }
}