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
            this.HomeTabControl = new System.Windows.Forms.TabControl();
            this.tpHomepage = new System.Windows.Forms.TabPage();
            this.flpComplaintsHome = new System.Windows.Forms.FlowLayoutPanel();
            this.tpSelf = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            this.HomeTabControl.SuspendLayout();
            this.tpHomepage.SuspendLayout();
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
            // HomeTabControl
            // 
            this.HomeTabControl.Controls.Add(this.tpHomepage);
            this.HomeTabControl.Controls.Add(this.tpSelf);
            this.HomeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeTabControl.Location = new System.Drawing.Point(0, 0);
            this.HomeTabControl.Name = "HomeTabControl";
            this.HomeTabControl.SelectedIndex = 0;
            this.HomeTabControl.Size = new System.Drawing.Size(1013, 601);
            this.HomeTabControl.TabIndex = 0;
            // 
            // tpHomepage
            // 
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
            this.tpSelf.Location = new System.Drawing.Point(4, 24);
            this.tpSelf.Name = "tpSelf";
            this.tpSelf.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelf.Size = new System.Drawing.Size(1005, 573);
            this.tpSelf.TabIndex = 1;
            this.tpSelf.Text = "Self";
            this.tpSelf.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl HomeTabControl;
        private TabPage tpHomepage;
        private TabPage tpSelf;
        private FlowLayoutPanel flpComplaintsHome;
    }
}