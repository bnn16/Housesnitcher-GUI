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
            System.Windows.Forms.Panel panel1;
            this.HomeTabControl = new System.Windows.Forms.TabControl();
            this.tpHomepage = new System.Windows.Forms.TabPage();
            this.tpSelf = new System.Windows.Forms.TabPage();
            this.tlpComplaintsHome = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            this.HomeTabControl.SuspendLayout();
            this.tpHomepage.SuspendLayout();
            this.SuspendLayout();
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
            this.tpHomepage.Controls.Add(panel1);
            this.tpHomepage.Controls.Add(label1);
            this.tpHomepage.Controls.Add(this.tlpComplaintsHome);
            this.tpHomepage.Location = new System.Drawing.Point(4, 24);
            this.tpHomepage.Name = "tpHomepage";
            this.tpHomepage.Padding = new System.Windows.Forms.Padding(3);
            this.tpHomepage.Size = new System.Drawing.Size(1005, 573);
            this.tpHomepage.TabIndex = 0;
            this.tpHomepage.Text = "Homepage";
            this.tpHomepage.UseVisualStyleBackColor = true;
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
            // tlpComplaintsHome
            // 
            this.tlpComplaintsHome.AutoSize = true;
            this.tlpComplaintsHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpComplaintsHome.ColumnCount = 1;
            this.tlpComplaintsHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComplaintsHome.Location = new System.Drawing.Point(47, 99);
            this.tlpComplaintsHome.Name = "tlpComplaintsHome";
            this.tlpComplaintsHome.RowCount = 1;
            this.tlpComplaintsHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpComplaintsHome.Size = new System.Drawing.Size(0, 0);
            this.tlpComplaintsHome.TabIndex = 0;
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
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(47, 99);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(10, 10);
            panel1.TabIndex = 2;
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
        private TableLayoutPanel tlpComplaintsHome;
        private Panel panel1;
    }
}