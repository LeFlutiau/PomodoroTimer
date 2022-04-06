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
            this.listTasks.View = View.Details;
            this.listTasks.Columns.Add("Name", 200);
            this.listTasks.Columns.Add("E", -2);
            this.listTasks.Columns.Add("P", -2);
            this.listTasks.FullRowSelect = true;
            this.listTasks.MultiSelect = false;
            this.PopulateList();
        }

        public void PopulateList()
        {
            this.listTasks.Items.Clear();
            foreach( Task task in data.tasks ) {
                ListViewItem item = new ListViewItem(new[] { task.Name, task.Elapsed.ToString(), task.Planned.ToString() });
                if (task.State == 1)
                {
                    Font font = new Font(
                        this.listTasks.Font,
                        this.listTasks.Font.Style | FontStyle.Strikeout
                    );
                    item.Font = font;
                }
                this.listTasks.Items.Add(item);
                item.Tag = task;
            }
        }

        private void frmTaskList_Load(object sender, EventArgs e)
        {
            this.numNewTaskDuration.Minimum = 0;
            this.numNewTaskDuration.Maximum = this.data.optionTaskMaxPomodoro;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Name = this.txtNewTaskName.Text;
            task.Planned = (int)this.numNewTaskDuration.Value;

            var item = new ListViewItem(new[] { task.Name, task.Elapsed.ToString(), task.Planned.ToString() });
            item.Tag = task;
            this.listTasks.Items.Add(item);
            
            data.addTask(task);

            this.txtNewTaskName.Text = "";
            this.numNewTaskDuration.Value = 0;

        }

        private void listTasks_DoubleClick(object sender, EventArgs e)
        {
            if (this.listTasks.SelectedItems.Count != 0)
            {
                data.currentTask = (Task)this.listTasks.SelectedItems[0].Tag;
                this.Close();
            }
        }

        private void listTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task task;
            if (this.listTasks.SelectedItems.Count == 0)
            {
                this.btnSetState.Visible = false;
                this.btnDelete.Visible = false;
            }
            else
            {
                task = (Task)this.listTasks.SelectedItems[0].Tag;
                if( task.State == 0 )
                {
                    this.btnSetState.Text = "Mark done";
                }
                else
                {
                    this.btnSetState.Text = "Mark undone";
                }
                this.btnSetState.Visible = true;
                this.btnDelete.Visible = true;
            }
        }

        private void btnSetState_Click(object sender, EventArgs e)
        {
            Task task;
            if (this.listTasks.SelectedItems.Count > 0)
            {
                task = (Task)this.listTasks.SelectedItems[0].Tag;
                Font font = new Font(
                    this.listTasks.SelectedItems[0].Font,
                    this.listTasks.SelectedItems[0].Font.Style ^ FontStyle.Strikeout
                );
                this.listTasks.SelectedItems[0].Font = font;

                if (task.State == 0)
                {
                    task.State = 1;
                    this.btnSetState.Text = "Mark undone";
                }
                else
                {
                    task.State = 0;
                    this.btnSetState.Text = "Mark done";
                }
            }
        }

        private void btnCleanAllDone_Click(object sender, EventArgs e)
        {
            data.tasks.RemoveAll(x => x.State == 1);
            this.PopulateList();
        }
    }
}
