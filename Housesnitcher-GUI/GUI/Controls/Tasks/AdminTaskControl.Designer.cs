namespace Housesnitcher_GUI.GUI.Controls.Tasks
{
    partial class AdminTaskControl
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
            this.taskControl1 = new Housesnitcher_GUI.GUI.Controls.Tasks.TaskControl();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnFail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskControl1
            // 
            this.taskControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taskControl1.Location = new System.Drawing.Point(0, 0);
            this.taskControl1.Name = "taskControl1";
            this.taskControl1.Size = new System.Drawing.Size(297, 198);
            this.taskControl1.TabIndex = 0;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(303, 3);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnFail
            // 
            this.btnFail.Location = new System.Drawing.Point(303, 32);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(75, 23);
            this.btnFail.TabIndex = 2;
            this.btnFail.Text = "Fail";
            this.btnFail.UseVisualStyleBackColor = true;
            this.btnFail.Click += new System.EventHandler(this.btnFail_Click);
            // 
            // AdminTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFail);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.taskControl1);
            this.Name = "AdminTaskControl";
            this.Size = new System.Drawing.Size(380, 197);
            this.ResumeLayout(false);

        }

        #endregion

        private TaskControl taskControl1;
        private Button btnComplete;
        private Button btnFail;
    }
}
