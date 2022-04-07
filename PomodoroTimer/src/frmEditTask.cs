using System;
using System.Windows.Forms;

namespace Pomodoro.src
{
    public partial class frmEditTask : Form
    {
        private Task task;

        public frmEditTask( ProgramData data, Task task )
        {
            InitializeComponent();
            numPomodoroCount.Maximum = data.optionTaskMaxPomodoro;
            txtTaskName.Text = task.Name;
            numPomodoroCount.Value = task.Planned;

            this.task = task;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            task.Name = txtTaskName.Text;
            task.Planned = (int)numPomodoroCount.Value;
            Close();
        }
    }
}
