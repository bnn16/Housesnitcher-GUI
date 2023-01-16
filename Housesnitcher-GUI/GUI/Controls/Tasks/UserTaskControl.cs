using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housesnitcher_GUI.GUI.Controls.Tasks
{
    public partial class UserTaskControl : UserControl
    {
        public TennantTask UpdateUsingObject
        {
            set
            {
                TaskControlView.UpdateUsingObject = value;
            }
        }
        public UserTaskControl()
        {
            InitializeComponent();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var ret = TennantTaskHandler.CompleteTask(TaskControlView.StoredTask);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
    }
}
