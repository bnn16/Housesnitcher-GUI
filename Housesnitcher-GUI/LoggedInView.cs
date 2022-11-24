using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housesnitcher_GUI
{
    public partial class LoggedInView : Form
    {
        public State state { get; set; }
        private void init()
        {
            InitializeComponent();
            this.lblWriteUser.Text = state.user.username;
            this.lblWritePerm.Text = state.user.authLevel.ToString();

        }
        public LoggedInView(State state)
        {
            this.state = state;
            init();
        }
        public LoggedInView()
        {
            init();
        }
    }
}
