namespace Housesnitcher_GUI.GUI.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.textBoxRepPass = new System.Windows.Forms.TextBox();
            this.pictureBoxRegister = new System.Windows.Forms.PictureBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelRepPass = new System.Windows.Forms.Label();
            this.labelGoLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRepPass
            // 
            this.textBoxRepPass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRepPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRepPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRepPass.Location = new System.Drawing.Point(373, 489);
            this.textBoxRepPass.Margin = new System.Windows.Forms.Padding(7);
            this.textBoxRepPass.Name = "textBoxRepPass";
            this.textBoxRepPass.PasswordChar = '*';
            this.textBoxRepPass.Size = new System.Drawing.Size(246, 20);
            this.textBoxRepPass.TabIndex = 22;
            this.textBoxRepPass.UseSystemPasswordChar = true;
            // 
            // pictureBoxRegister
            // 
            this.pictureBoxRegister.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegister.ErrorImage")));
            this.pictureBoxRegister.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegister.Image")));
            this.pictureBoxRegister.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegister.InitialImage")));
            this.pictureBoxRegister.Location = new System.Drawing.Point(242, 21);
            this.pictureBoxRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxRegister.Name = "pictureBoxRegister";
            this.pictureBoxRegister.Size = new System.Drawing.Size(533, 307);
            this.pictureBoxRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRegister.TabIndex = 21;
            this.pictureBoxRegister.TabStop = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Blue;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(438, 533);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Padding = new System.Windows.Forms.Padding(1);
            this.buttonRegister.Size = new System.Drawing.Size(120, 31);
            this.buttonRegister.TabIndex = 20;
            this.buttonRegister.Text = "SIGN UP";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(373, 396);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(7);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(246, 20);
            this.textBoxName.TabIndex = 19;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPass.Location = new System.Drawing.Point(373, 443);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(7);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(246, 20);
            this.textBoxPass.TabIndex = 18;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Location = new System.Drawing.Point(450, 350);
            this.labelRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(89, 15);
            this.labelRegister.TabIndex = 17;
            this.labelRegister.Text = "Create Account";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(320, 397);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(320, 443);
            this.labelPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(33, 15);
            this.labelPass.TabIndex = 24;
            this.labelPass.Text = "Pass:";
            // 
            // labelRepPass
            // 
            this.labelRepPass.AutoSize = true;
            this.labelRepPass.Location = new System.Drawing.Point(288, 490);
            this.labelRepPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRepPass.Name = "labelRepPass";
            this.labelRepPass.Size = new System.Drawing.Size(72, 15);
            this.labelRepPass.TabIndex = 25;
            this.labelRepPass.Text = "Repeat Pass:";
            // 
            // labelGoLogin
            // 
            this.labelGoLogin.AutoSize = true;
            this.labelGoLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelGoLogin.Location = new System.Drawing.Point(423, 582);
            this.labelGoLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGoLogin.Name = "labelGoLogin";
            this.labelGoLogin.Size = new System.Drawing.Size(165, 15);
            this.labelGoLogin.TabIndex = 26;
            this.labelGoLogin.Text = "Already registered? Click here!";
            this.labelGoLogin.Click += new System.EventHandler(this.labelGoLogin_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 606);
            this.Controls.Add(this.labelGoLogin);
            this.Controls.Add(this.labelRepPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxRepPass);
            this.Controls.Add(this.pictureBoxRegister);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelRegister);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxRepPass;
        private PictureBox pictureBoxRegister;
        private Button buttonRegister;
        private TextBox textBoxName;
        private TextBox textBoxPass;
        private Label labelRegister;
        private Label labelName;
        private Label labelPass;
        private Label labelRepPass;
        private Label labelGoLogin;
    }
}