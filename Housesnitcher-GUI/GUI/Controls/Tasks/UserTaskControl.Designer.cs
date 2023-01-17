namespace Housesnitcher_GUI.GUI.Controls.Tasks
{
    partial class UserTaskControl
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
            this.TaskControlView = new Housesnitcher_GUI.GUI.Controls.Tasks.TaskControl();
            this.btnComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskControlView
            // 
            this.TaskControlView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaskControlView.Location = new System.Drawing.Point(0, 0);
            this.TaskControlView.Name = "TaskControlView";
            this.TaskControlView.Size = new System.Drawing.Size(297, 198);
            this.TaskControlView.TabIndex = 0;
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
            // UserTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.TaskControlView);
            this.Name = "UserTaskControl";
            this.Size = new System.Drawing.Size(385, 197);
            this.ResumeLayout(false);

        }

        #endregion

        private TaskControl TaskControlView;
        private Button btnComplete;
    }
}
