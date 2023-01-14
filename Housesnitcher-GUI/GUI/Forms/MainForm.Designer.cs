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
            System.Windows.Forms.Label label6;
            this.HomeTabControl = new System.Windows.Forms.TabControl();
            this.tpHomepage = new System.Windows.Forms.TabPage();
            this.flowTasksHome = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserData = new System.Windows.Forms.Label();
            this.flpComplaintsHome = new System.Windows.Forms.FlowLayoutPanel();
            this.tpSelf = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pLodgeComplaint = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateComplaint = new System.Windows.Forms.Button();
            this.dtHappened = new System.Windows.Forms.DateTimePicker();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.flpInShort = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLodgeComplaint = new System.Windows.Forms.Button();
            this.flpMyComplaints = new System.Windows.Forms.FlowLayoutPanel();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            shitLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.HomeTabControl.SuspendLayout();
            this.tpHomepage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpSelf.SuspendLayout();
            this.pLodgeComplaint.SuspendLayout();
            this.tpAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(87, 87);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "Last 10 complaints";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 81);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 20);
            label3.TabIndex = 0;
            label3.Text = "My complaints:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 167);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 20);
            label4.TabIndex = 37;
            label4.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 131);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 20);
            label2.TabIndex = 35;
            label2.Text = "Date happened:";
            // 
            // shitLabel
            // 
            shitLabel.AutoSize = true;
            shitLabel.Location = new System.Drawing.Point(72, 19);
            shitLabel.Name = "shitLabel";
            shitLabel.Size = new System.Drawing.Size(41, 20);
            shitLabel.TabIndex = 34;
            shitLabel.Text = "Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(513, 67);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 20);
            label5.TabIndex = 6;
            label5.Text = "In short...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(546, 87);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 20);
            label6.TabIndex = 4;
            label6.Text = "Last 10 Tasks";
            // 
            // HomeTabControl
            // 
            this.HomeTabControl.Controls.Add(this.tpHomepage);
            this.HomeTabControl.Controls.Add(this.tpSelf);
            this.HomeTabControl.Controls.Add(this.tpAdmin);
            this.HomeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeTabControl.Location = new System.Drawing.Point(0, 0);
            this.HomeTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeTabControl.Name = "HomeTabControl";
            this.HomeTabControl.SelectedIndex = 0;
            this.HomeTabControl.Size = new System.Drawing.Size(1447, 813);
            this.HomeTabControl.TabIndex = 0;
            this.HomeTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.HomeTabControl_Selected);
            // 
            // tpHomepage
            // 
            this.tpHomepage.Controls.Add(this.flowTasksHome);
            this.tpHomepage.Controls.Add(label6);
            this.tpHomepage.Controls.Add(this.tableLayoutPanel1);
            this.tpHomepage.Controls.Add(this.flpComplaintsHome);
            this.tpHomepage.Controls.Add(label1);
            this.tpHomepage.Location = new System.Drawing.Point(4, 29);
            this.tpHomepage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpHomepage.Name = "tpHomepage";
            this.tpHomepage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpHomepage.Size = new System.Drawing.Size(1439, 780);
            this.tpHomepage.TabIndex = 0;
            this.tpHomepage.Text = "Homepage";
            this.tpHomepage.UseVisualStyleBackColor = true;
            // 
            // flowTasksHome
            // 
            this.flowTasksHome.AutoScroll = true;
            this.flowTasksHome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTasksHome.Location = new System.Drawing.Point(481, 125);
            this.flowTasksHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowTasksHome.Name = "flowTasksHome";
            this.flowTasksHome.Size = new System.Drawing.Size(369, 635);
            this.flowTasksHome.TabIndex = 5;
            this.flowTasksHome.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblUserData, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1290, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 141);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblUserData
            // 
            this.lblUserData.AutoSize = true;
            this.lblUserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserData.Location = new System.Drawing.Point(3, 0);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.Size = new System.Drawing.Size(138, 141);
            this.lblUserData.TabIndex = 0;
            this.lblUserData.Text = "CurrentUserLoggedIn";
            // 
            // flpComplaintsHome
            // 
            this.flpComplaintsHome.AutoScroll = true;
            this.flpComplaintsHome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpComplaintsHome.Location = new System.Drawing.Point(22, 125);
            this.flpComplaintsHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpComplaintsHome.Name = "flpComplaintsHome";
            this.flpComplaintsHome.Size = new System.Drawing.Size(369, 635);
            this.flpComplaintsHome.TabIndex = 2;
            this.flpComplaintsHome.WrapContents = false;
            // 
            // tpSelf
            // 
            this.tpSelf.Controls.Add(this.btnLogout);
            this.tpSelf.Controls.Add(this.pLodgeComplaint);
            this.tpSelf.Controls.Add(this.flpInShort);
            this.tpSelf.Controls.Add(label5);
            this.tpSelf.Controls.Add(this.btnLodgeComplaint);
            this.tpSelf.Controls.Add(this.flpMyComplaints);
            this.tpSelf.Controls.Add(label3);
            this.tpSelf.Location = new System.Drawing.Point(4, 29);
            this.tpSelf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpSelf.Name = "tpSelf";
            this.tpSelf.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpSelf.Size = new System.Drawing.Size(1439, 780);
            this.tpSelf.TabIndex = 1;
            this.tpSelf.Text = "Self";
            this.tpSelf.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1343, 28);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 31);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pLodgeComplaint
            // 
            this.pLodgeComplaint.Controls.Add(this.cbType);
            this.pLodgeComplaint.Controls.Add(this.btnCancel);
            this.pLodgeComplaint.Controls.Add(this.btnCreateComplaint);
            this.pLodgeComplaint.Controls.Add(label4);
            this.pLodgeComplaint.Controls.Add(this.dtHappened);
            this.pLodgeComplaint.Controls.Add(label2);
            this.pLodgeComplaint.Controls.Add(shitLabel);
            this.pLodgeComplaint.Controls.Add(this.tbDescription);
            this.pLodgeComplaint.Controls.Add(this.tbTitle);
            this.pLodgeComplaint.Controls.Add(this.label13);
            this.pLodgeComplaint.Location = new System.Drawing.Point(9, 81);
            this.pLodgeComplaint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pLodgeComplaint.Name = "pLodgeComplaint";
            this.pLodgeComplaint.Size = new System.Drawing.Size(403, 537);
            this.pLodgeComplaint.TabIndex = 6;
            this.pLodgeComplaint.Visible = false;
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(113, 71);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(266, 28);
            this.cbType.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 452);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateComplaint
            // 
            this.btnCreateComplaint.AutoSize = true;
            this.btnCreateComplaint.Location = new System.Drawing.Point(218, 449);
            this.btnCreateComplaint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateComplaint.Name = "btnCreateComplaint";
            this.btnCreateComplaint.Size = new System.Drawing.Size(154, 40);
            this.btnCreateComplaint.TabIndex = 38;
            this.btnCreateComplaint.Text = "Create Complaint";
            this.btnCreateComplaint.UseVisualStyleBackColor = true;
            this.btnCreateComplaint.Click += new System.EventHandler(this.btnCreateComplaint_Click);
            // 
            // dtHappened
            // 
            this.dtHappened.Location = new System.Drawing.Point(113, 123);
            this.dtHappened.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtHappened.Name = "dtHappened";
            this.dtHappened.Size = new System.Drawing.Size(266, 27);
            this.dtHappened.TabIndex = 36;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Location = new System.Drawing.Point(113, 167);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "a small description of what your problem is";
            this.tbDescription.Size = new System.Drawing.Size(266, 231);
            this.tbDescription.TabIndex = 32;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Location = new System.Drawing.Point(113, 19);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PlaceholderText = "A quick title for what your problem is";
            this.tbTitle.Size = new System.Drawing.Size(266, 43);
            this.tbTitle.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(70, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Type:";
            // 
            // flpInShort
            // 
            this.flpInShort.AutoScroll = true;
            this.flpInShort.Location = new System.Drawing.Point(553, 105);
            this.flpInShort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpInShort.Name = "flpInShort";
            this.flpInShort.Size = new System.Drawing.Size(275, 651);
            this.flpInShort.TabIndex = 7;
            // 
            // btnLodgeComplaint
            // 
            this.btnLodgeComplaint.AutoSize = true;
            this.btnLodgeComplaint.Location = new System.Drawing.Point(9, 27);
            this.btnLodgeComplaint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLodgeComplaint.Name = "btnLodgeComplaint";
            this.btnLodgeComplaint.Size = new System.Drawing.Size(153, 40);
            this.btnLodgeComplaint.TabIndex = 5;
            this.btnLodgeComplaint.Text = "Lodge Complaint";
            this.btnLodgeComplaint.UseVisualStyleBackColor = true;
            this.btnLodgeComplaint.Click += new System.EventHandler(this.btnLodgeComplaint_Click);
            // 
            // flpMyComplaints
            // 
            this.flpMyComplaints.AutoScroll = true;
            this.flpMyComplaints.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMyComplaints.Location = new System.Drawing.Point(0, 105);
            this.flpMyComplaints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpMyComplaints.Name = "flpMyComplaints";
            this.flpMyComplaints.Size = new System.Drawing.Size(536, 651);
            this.flpMyComplaints.TabIndex = 3;
            this.flpMyComplaints.WrapContents = false;
            // 
            // tpAdmin
            // 
            this.tpAdmin.Controls.Add(this.label7);
            this.tpAdmin.Controls.Add(this.button1);
            this.tpAdmin.Location = new System.Drawing.Point(4, 29);
            this.tpAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Size = new System.Drawing.Size(1439, 780);
            this.tpAdmin.TabIndex = 2;
            this.tpAdmin.Text = "Administration";
            this.tpAdmin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add a Task ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 41);
            this.label7.TabIndex = 1;
            this.label7.Text = "Add a task for a student.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 813);
            this.Controls.Add(this.HomeTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "HouseSnitcher";
            this.HomeTabControl.ResumeLayout(false);
            this.tpHomepage.ResumeLayout(false);
            this.tpHomepage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpSelf.ResumeLayout(false);
            this.tpSelf.PerformLayout();
            this.pLodgeComplaint.ResumeLayout(false);
            this.pLodgeComplaint.PerformLayout();
            this.tpAdmin.ResumeLayout(false);
            this.tpAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl HomeTabControl;
        private TabPage tpHomepage;
        private TabPage tpSelf;
        private FlowLayoutPanel flpComplaintsHome;
        private TabPage tpAdmin;
        private FlowLayoutPanel flpMyComplaints;
        private Panel pLodgeComplaint;
        private Button btnCreateComplaint;
        private DateTimePicker dtHappened;
        private TextBox tbDescription;
        private TextBox tbTitle;
        private Label label13;
        private Button btnLodgeComplaint;
        private Button btnCancel;
        private FlowLayoutPanel flpInShort;
        private ComboBox cbType;
        private Button btnLogout;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUserData;
        private FlowLayoutPanel flowTasksHome;
        private Button button1;
        private Label label7;
    }
}