using Housesnitcher_GUI.DataHandling;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var user = UserHandler.LogIn(textBoxName.Text, textBoxPassword.Text);
            if (user != null)
            {
                var Form = new MainForm(user);
                Form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void labelNotRegister_Click(object sender, EventArgs e)
        {
            var Form = new RegisterForm();
            Form.Show();
            Hide();
        }
    }
}
