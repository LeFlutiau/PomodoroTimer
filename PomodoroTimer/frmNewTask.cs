using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class frmNewTask : Form
    {
        private ProgramData data;
        public Task task { get; set; }

        public frmNewTask( ProgramData data )
        {
            InitializeComponent();
            this.data = data;
            task = new Task();
            task.Planned = -1;
            numDuration.Maximum = data.optionTaskMaxPomodoro;
            this.KeyPreview = true;
        }

        private void frmNewTask_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if (e.KeyChar == (char)Keys.Escape)
            {
                task.Planned = -1;
                Close();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                task.Name = txtTaskName.Text;
                if (task.Name != "")
                {
                    task.Planned = ((int)this.numDuration.Value);
                    task.State = 0;
                    task.Elapsed = 0;
                }
                Close();
            }
        }
    }
}
