using Housesnitcher_GUI.DataHandling;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == textBoxRepPass.Text)
            {
                var user = UserHandler.CreateUser(textBoxName.Text, textBoxRepPass.Text);
                if (user != null)
                {
                    var Form = new MainForm(user);
                    Form.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Register failed!");
                }
            }
        }

        private void labelGoLogin_Click(object sender, EventArgs e)
        {
            var Form = new LoginForm();
            Form.Show();
            Hide();
        }
    }
}
