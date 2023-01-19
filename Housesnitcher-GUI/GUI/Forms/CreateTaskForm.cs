using Housesnitcher_GUI.DataHandling;
using Housesnitcher_GUI.GUI.Events;
using Housesnitcher_GUI.Models;
using Housesnitcher_GUI.StateManagement;

namespace Housesnitcher_GUI.GUI.Forms
{
    public partial class CreateTaskForm : Form
    {
        public CreateTaskForm()
        {
            InitializeComponent();
        }
        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            foreach (var type in State.complaintTypes)
            {
                cmbTasks.Items.Add(type);
                cmbTasks.AutoCompleteCustomSource.Add(type);
            }

            foreach (var username in UserHandler.UsernamesList())
            {
                cmbUsers.Items.Add(username);
                cmbUsers.AutoCompleteCustomSource.Add(username);

            }
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TennantTask newTask = new(txtBoxTaskTitle.Text, txtBoxTaskDescription.Text, cmbUsers.Text, cmbTasks.Text, dateTimePicker1.Value);

            var res = TennantTaskHandler.AssignTask(newTask);
            if (res == null)
            {
                MessageBox.Show("Task not created", "Error");
            }
            else
            {
                MessageBox.Show("Task created", "Success");
            }
            ForceRefreshEvent.RaiseRefreshEvent(this, new EventArgs());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
