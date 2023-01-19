namespace Housesnitcher_GUI.GUI.Forms
{
    partial class CreateComplaintForm
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label shitLabel;
            this.labeluser = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateComplaint = new System.Windows.Forms.Button();
            this.dtHappened = new System.Windows.Forms.DateTimePicker();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            shitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(35, 157);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 15);
            label4.TabIndex = 47;
            label4.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 15);
            label2.TabIndex = 45;
            label2.Text = "Date happened:";
            // 
            // shitLabel
            // 
            shitLabel.AutoSize = true;
            shitLabel.Location = new System.Drawing.Point(73, 46);
            shitLabel.Name = "shitLabel";
            shitLabel.Size = new System.Drawing.Size(32, 15);
            shitLabel.TabIndex = 44;
            shitLabel.Text = "Title:";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.labeluser.Location = new System.Drawing.Point(335, 7);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(0, 15);
            this.labeluser.TabIndex = 8;
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(108, 85);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(233, 23);
            this.cbType.TabIndex = 50;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(120, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreateComplaint
            // 
            this.btnCreateComplaint.AutoSize = true;
            this.btnCreateComplaint.ForeColor = System.Drawing.Color.Black;
            this.btnCreateComplaint.Location = new System.Drawing.Point(200, 368);
            this.btnCreateComplaint.Name = "btnCreateComplaint";
            this.btnCreateComplaint.Size = new System.Drawing.Size(135, 30);
            this.btnCreateComplaint.TabIndex = 48;
            this.btnCreateComplaint.Text = "Create Complaint";
            this.btnCreateComplaint.UseVisualStyleBackColor = true;
            this.btnCreateComplaint.Click += new System.EventHandler(this.btnCreateComplaint_Click_1);
            // 
            // dtHappened
            // 
            this.dtHappened.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.dtHappened.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.dtHappened.Location = new System.Drawing.Point(108, 124);
            this.dtHappened.Name = "dtHappened";
            this.dtHappened.Size = new System.Drawing.Size(233, 23);
            this.dtHappened.TabIndex = 46;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tbDescription.Location = new System.Drawing.Point(108, 157);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(7);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "a small description of what your problem is";
            this.tbDescription.Size = new System.Drawing.Size(233, 174);
            this.tbDescription.TabIndex = 43;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Location = new System.Drawing.Point(108, 46);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(7);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PlaceholderText = "A quick title for what your problem is";
            this.tbTitle.Size = new System.Drawing.Size(233, 32);
            this.tbTitle.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.label13.Location = new System.Drawing.Point(71, 88);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "Type:";
            // 
            // CreateComplaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(427, 442);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateComplaint);
            this.Controls.Add(label4);
            this.Controls.Add(this.dtHappened);
            this.Controls.Add(label2);
            this.Controls.Add(shitLabel);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labeluser);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateComplaintForm";
            this.Text = "Create Complaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labeluser;
        private ComboBox cbType;
        private Button btnCancel;
        private Button btnCreateComplaint;
        private DateTimePicker dtHappened;
        private TextBox tbDescription;
        private TextBox tbTitle;
        private Label label13;
    }
}