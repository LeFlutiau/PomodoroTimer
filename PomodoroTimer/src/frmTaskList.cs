using Pomodoro.src;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class frmTaskList : Form
    {
        ProgramData data;
        public frmTaskList(ProgramData data)
        {
            InitializeComponent();
            this.data = data;
            listTasks.View = View.Details;
            listTasks.Columns.Add("Name", 200);
            listTasks.Columns.Add("Elapsed", -2);
            listTasks.Columns.Add("Planned", -2);
            listTasks.FullRowSelect = true;
            listTasks.MultiSelect = false;
            PopulateList();
        }

        public void PopulateList()
        {
            listTasks.Items.Clear();
            foreach (Task task in data.tasks)
            {
                ListViewItem item = new ListViewItem(new[] { task.Name, task.Elapsed.ToString(), task.Planned.ToString() });
                if (task.State == States.Complete)
                {
                    Font font = new Font(
                        listTasks.Font,
                        listTasks.Font.Style | FontStyle.Strikeout
                    );
                    item.Font = font;
                }
                listTasks.Items.Add(item);
                item.Tag = task;
            }
        }

        private void frmTaskList_Load(object sender, EventArgs e)
        {
            numNewTaskDuration.Minimum = 0;
            numNewTaskDuration.Maximum = data.optionTaskMaxPomodoro;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Name = txtNewTaskName.Text;
            task.Planned = (int)numNewTaskDuration.Value;

            var item = new ListViewItem(new[] { task.Name, task.Elapsed.ToString(), task.Planned.ToString() });
            item.Tag = task;
            listTasks.Items.Add(item);
            data.addTask(task);

            txtNewTaskName.Text = "";
            numNewTaskDuration.Value = 0;
        }
        private void listTasks_DoubleClick(object sender, EventArgs e)
        {
            if (listTasks.SelectedItems.Count != 0)
            {
                data.currentTask = (Task)listTasks.SelectedItems[0].Tag;
                Close();
            }
        }

        private void markTaskDone(object sender, EventArgs e)
        {
            Task task;
            if (this.listTasks.SelectedItems.Count > 0)
            {
                task = (Task)this.listTasks.SelectedItems[0].Tag;
                if (task.State == States.Created)
                {
                    task.State = States.Complete;
                    Font font = new Font(
                        this.listTasks.SelectedItems[0].Font,
                        this.listTasks.SelectedItems[0].Font.Style | FontStyle.Strikeout
                    );
                    this.listTasks.SelectedItems[0].Font = font;
                }
            }
        }

        private void markTaskUndone(object sender, EventArgs e)
        {
            Task task;
            if (this.listTasks.SelectedItems.Count > 0)
            {
                task = (Task)this.listTasks.SelectedItems[0].Tag;
                if (task.State == States.Complete)
                {
                    task.State = States.Created;
                    Font font = new Font(
                        this.listTasks.SelectedItems[0].Font,
                        this.listTasks.SelectedItems[0].Font.Style & ~FontStyle.Strikeout
                    );
                    this.listTasks.SelectedItems[0].Font = font;
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTask form;
            if (this.listTasks.SelectedItems.Count > 0)
            {
                form = new frmEditTask(data, (Task)this.listTasks.SelectedItems[0].Tag);
                form.ShowDialog();
                PopulateList();
            }
        }
        private void deleteTask(object sender, EventArgs e)
        {
            if (this.listTasks.SelectedItems.Count > 0)
            {
                Task task = (Task)this.listTasks.SelectedItems[0].Tag;
                if (task == data.currentTask)
                {
                    data.currentTask = null;
                }
                data.tasks.Remove(task);
                PopulateList();
            }
        }

        private void cleanAllDone(object sender, EventArgs e)
        {
            data.tasks.RemoveAll(x => x.State == States.Complete);
            PopulateList();
        }
    }
}
