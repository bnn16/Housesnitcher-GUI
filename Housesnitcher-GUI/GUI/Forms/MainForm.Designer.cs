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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            this.HomeTabControl = new System.Windows.Forms.TabControl();
            this.tpHomepage = new System.Windows.Forms.TabPage();
            this.flowTasksHome = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserData = new System.Windows.Forms.Label();
            this.flpComplaintsHome = new System.Windows.Forms.FlowLayoutPanel();
            this.tpSelf = new System.Windows.Forms.TabPage();
            this.flpMyTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flpInShort = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLodgeComplaint = new System.Windows.Forms.Button();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.flpAdminComplaints = new System.Windows.Forms.FlowLayoutPanel();
            this.pLodgeComplaint = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.HomeTabControl.SuspendLayout();
            this.tpHomepage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpSelf.SuspendLayout();
            this.tpAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(76, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 21);
            label1.TabIndex = 1;
            label1.Text = "Last 10 complaints";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(38, 56);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(119, 21);
            label5.TabIndex = 6;
            label5.Text = "My Complaints";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(532, 65);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 21);
            label6.TabIndex = 4;
            label6.Text = "Last 10 Tasks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(340, 56);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 21);
            label3.TabIndex = 9;
            label3.Text = "My Tasks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            label2.Location = new System.Drawing.Point(17, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 21);
            label2.TabIndex = 5;
            label2.Text = "Complaints:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            label4.Location = new System.Drawing.Point(450, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 21);
            label4.TabIndex = 6;
            label4.Text = "Tasks:";
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
            this.HomeTabControl.Size = new System.Drawing.Size(1266, 610);
            this.HomeTabControl.TabIndex = 0;
            this.HomeTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.HomeTabControl_Selected);
            // 
            // tpHomepage
            // 
            this.tpHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.tpHomepage.Controls.Add(this.flowTasksHome);
            this.tpHomepage.Controls.Add(label6);
            this.tpHomepage.Controls.Add(this.tableLayoutPanel1);
            this.tpHomepage.Controls.Add(this.flpComplaintsHome);
            this.tpHomepage.Controls.Add(label1);
            this.tpHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tpHomepage.Location = new System.Drawing.Point(4, 24);
            this.tpHomepage.Name = "tpHomepage";
            this.tpHomepage.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomepage.Size = new System.Drawing.Size(1258, 582);
            this.tpHomepage.TabIndex = 0;
            this.tpHomepage.Text = "Homepage";
            // 
            // flowTasksHome
            // 
            this.flowTasksHome.AutoScroll = true;
            this.flowTasksHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.flowTasksHome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTasksHome.ForeColor = System.Drawing.Color.Black;
            this.flowTasksHome.Location = new System.Drawing.Point(475, 94);
            this.flowTasksHome.Name = "flowTasksHome";
            this.flowTasksHome.Size = new System.Drawing.Size(323, 476);
            this.flowTasksHome.TabIndex = 5;
            this.flowTasksHome.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblUserData, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1129, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(126, 106);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblUserData
            // 
            this.lblUserData.AutoSize = true;
            this.lblUserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserData.Location = new System.Drawing.Point(3, 0);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.Size = new System.Drawing.Size(120, 106);
            this.lblUserData.TabIndex = 0;
            this.lblUserData.Text = "CurrentUserLoggedIn";
            // 
            // flpComplaintsHome
            // 
            this.flpComplaintsHome.AutoScroll = true;
            this.flpComplaintsHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.flpComplaintsHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpComplaintsHome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpComplaintsHome.ForeColor = System.Drawing.Color.Black;
            this.flpComplaintsHome.Location = new System.Drawing.Point(19, 94);
            this.flpComplaintsHome.Name = "flpComplaintsHome";
            this.flpComplaintsHome.Size = new System.Drawing.Size(307, 477);
            this.flpComplaintsHome.TabIndex = 2;
            this.flpComplaintsHome.WrapContents = false;
            // 
            // tpSelf
            // 
            this.tpSelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.tpSelf.Controls.Add(this.flpMyTasks);
            this.tpSelf.Controls.Add(label3);
            this.tpSelf.Controls.Add(this.btnLogout);
            this.tpSelf.Controls.Add(this.flpInShort);
            this.tpSelf.Controls.Add(label5);
            this.tpSelf.Controls.Add(this.btnLodgeComplaint);
            this.tpSelf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tpSelf.Location = new System.Drawing.Point(4, 24);
            this.tpSelf.Name = "tpSelf";
            this.tpSelf.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelf.Size = new System.Drawing.Size(1258, 582);
            this.tpSelf.TabIndex = 1;
            this.tpSelf.Text = "Self";
            // 
            // flpMyTasks
            // 
            this.flpMyTasks.AutoScroll = true;
            this.flpMyTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.flpMyTasks.ForeColor = System.Drawing.Color.Black;
            this.flpMyTasks.Location = new System.Drawing.Point(340, 80);
            this.flpMyTasks.Name = "flpMyTasks";
            this.flpMyTasks.Size = new System.Drawing.Size(300, 488);
            this.flpMyTasks.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(1175, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // flpInShort
            // 
            this.flpInShort.AutoScroll = true;
            this.flpInShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.flpInShort.ForeColor = System.Drawing.Color.Black;
            this.flpInShort.Location = new System.Drawing.Point(38, 80);
            this.flpInShort.Name = "flpInShort";
            this.flpInShort.Size = new System.Drawing.Size(241, 488);
            this.flpInShort.TabIndex = 7;
            // 
            // btnLodgeComplaint
            // 
            this.btnLodgeComplaint.AutoSize = true;
            this.btnLodgeComplaint.ForeColor = System.Drawing.Color.Black;
            this.btnLodgeComplaint.Location = new System.Drawing.Point(38, 17);
            this.btnLodgeComplaint.Name = "btnLodgeComplaint";
            this.btnLodgeComplaint.Size = new System.Drawing.Size(134, 30);
            this.btnLodgeComplaint.TabIndex = 5;
            this.btnLodgeComplaint.Text = "Lodge Complaint";
            this.btnLodgeComplaint.UseVisualStyleBackColor = true;
            this.btnLodgeComplaint.Click += new System.EventHandler(this.btnLodgeComplaint_Click);
            // 
            // tpAdmin
            // 
            this.tpAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.tpAdmin.Controls.Add(label4);
            this.tpAdmin.Controls.Add(label2);
            this.tpAdmin.Controls.Add(this.flowLayoutPanel1);
            this.tpAdmin.Controls.Add(this.btnCreateTask);
            this.tpAdmin.Controls.Add(this.flpAdminComplaints);
            this.tpAdmin.Location = new System.Drawing.Point(4, 24);
            this.tpAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Size = new System.Drawing.Size(1258, 582);
            this.tpAdmin.TabIndex = 2;
            this.tpAdmin.Text = "Administration";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(450, 44);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(357, 357);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.AutoSize = true;
            this.btnCreateTask.Location = new System.Drawing.Point(627, 11);
            this.btnCreateTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(76, 25);
            this.btnCreateTask.TabIndex = 4;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // flpAdminComplaints
            // 
            this.flpAdminComplaints.AutoScroll = true;
            this.flpAdminComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.flpAdminComplaints.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAdminComplaints.Location = new System.Drawing.Point(7, 44);
            this.flpAdminComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpAdminComplaints.Name = "flpAdminComplaints";
            this.flpAdminComplaints.Size = new System.Drawing.Size(423, 357);
            this.flpAdminComplaints.TabIndex = 3;
            this.flpAdminComplaints.WrapContents = false;
            // 
            // pLodgeComplaint
            // 
            this.pLodgeComplaint.Location = new System.Drawing.Point(0, 0);
            this.pLodgeComplaint.Name = "pLodgeComplaint";
            this.pLodgeComplaint.Size = new System.Drawing.Size(200, 100);
            this.pLodgeComplaint.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 610);
            this.Controls.Add(this.HomeTabControl);
            this.Name = "MainForm";
            this.Text = "HouseSnitcher";
            this.HomeTabControl.ResumeLayout(false);
            this.tpHomepage.ResumeLayout(false);
            this.tpHomepage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpSelf.ResumeLayout(false);
            this.tpSelf.PerformLayout();
            this.tpAdmin.ResumeLayout(false);
            this.tpAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl HomeTabControl;
        private TabPage tpHomepage;
        private TabPage tpSelf;
        private FlowLayoutPanel flowTasksHome;
        private FlowLayoutPanel flpComplaintsHome;
        private Panel pLodgeComplaint;
        private TabPage tpAdmin;
        private Button btnLodgeComplaint;
        private FlowLayoutPanel flpInShort;
        private Button btnLogout;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUserData;
        private FlowLayoutPanel flpAdminComplaints;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCreateTask;
        private Label label4;
        private FlowLayoutPanel flpMyTasks;
    }
}