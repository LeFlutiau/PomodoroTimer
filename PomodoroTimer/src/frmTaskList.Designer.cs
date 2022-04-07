namespace Pomodoro
{
    partial class frmTaskList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listTasks = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewTaskName = new System.Windows.Forms.TextBox();
            this.numNewTaskDuration = new System.Windows.Forms.NumericUpDown();
            this.taskListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.markDoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markUndoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numNewTaskDuration)).BeginInit();
            this.taskListContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTasks
            // 
            this.listTasks.ContextMenuStrip = this.taskListContextMenu;
            this.listTasks.HideSelection = false;
            this.listTasks.Location = new System.Drawing.Point(9, 9);
            this.listTasks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(466, 276);
            this.listTasks.TabIndex = 0;
            this.listTasks.UseCompatibleStateImageBehavior = false;
            this.listTasks.View = System.Windows.Forms.View.List;
            this.listTasks.DoubleClick += new System.EventHandler(this.listTasks_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(383, 295);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNewTaskName
            // 
            this.txtNewTaskName.Location = new System.Drawing.Point(9, 295);
            this.txtNewTaskName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNewTaskName.Name = "txtNewTaskName";
            this.txtNewTaskName.Size = new System.Drawing.Size(255, 31);
            this.txtNewTaskName.TabIndex = 1;
            // 
            // numNewTaskDuration
            // 
            this.numNewTaskDuration.Location = new System.Drawing.Point(272, 296);
            this.numNewTaskDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numNewTaskDuration.Name = "numNewTaskDuration";
            this.numNewTaskDuration.Size = new System.Drawing.Size(65, 31);
            this.numNewTaskDuration.TabIndex = 2;
            // 
            // taskListContextMenu
            // 
            this.taskListContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.taskListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markDoneToolStripMenuItem,
            this.markUndoneToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.taskListContextMenu.Name = "contextMenuStrip1";
            this.taskListContextMenu.Size = new System.Drawing.Size(196, 164);
            // 
            // markDoneToolStripMenuItem
            // 
            this.markDoneToolStripMenuItem.Name = "markDoneToolStripMenuItem";
            this.markDoneToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.markDoneToolStripMenuItem.Text = "Mark done";
            this.markDoneToolStripMenuItem.Click += new System.EventHandler(this.markTaskDone);
            // 
            // markUndoneToolStripMenuItem
            // 
            this.markUndoneToolStripMenuItem.Name = "markUndoneToolStripMenuItem";
            this.markUndoneToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.markUndoneToolStripMenuItem.Text = "Mark undone";
            this.markUndoneToolStripMenuItem.Click += new System.EventHandler(this.markTaskUndone);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuItem1.Text = "Clean all done";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.cleanAllDone);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteTask);
            // 
            // frmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 341);
            this.Controls.Add(this.numNewTaskDuration);
            this.Controls.Add(this.txtNewTaskName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listTasks);
            this.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskList";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.frmTaskList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNewTaskDuration)).EndInit();
            this.taskListContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listTasks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewTaskName;
        private System.Windows.Forms.NumericUpDown numNewTaskDuration;
        private System.Windows.Forms.ContextMenuStrip taskListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem markDoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markUndoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}