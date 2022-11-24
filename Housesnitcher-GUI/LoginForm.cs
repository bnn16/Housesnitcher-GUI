using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.CodeDom;

namespace Housesnitcher_GUI
{
    public partial class LoginForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var _username = this.tbUsername.Text;
            var data = new LoginData
            {
                username = _username,
                password = this.tbPassword.Text
            };
            String json = JsonSerializer.Serialize(data);
            var response = await client.PostAsJsonAsync("http://localhost:8000/api/login", data);
            try
            {
                var content = await response.Content.ReadAsStringAsync();
                var temp = JsonSerializer.Deserialize<Response>(content);
                var state = new State
                {
                    user = new User
                    {
                        username = _username,
                        authLevel = temp.scope
                    }
                };
                if (Convert.ToBoolean(temp.auth))
                {

                    LoggedInView x = new LoggedInView(state);
                    //x.state = state;
                    x.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Wrong password, try again.", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
