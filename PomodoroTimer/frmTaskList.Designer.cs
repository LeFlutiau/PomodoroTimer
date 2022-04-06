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
            this.listTasks = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewTaskName = new System.Windows.Forms.TextBox();
            this.numNewTaskDuration = new System.Windows.Forms.NumericUpDown();
            this.btnSetState = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCleanAllDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNewTaskDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // listTasks
            // 
            this.listTasks.HideSelection = false;
            this.listTasks.Location = new System.Drawing.Point(9, 9);
            this.listTasks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(466, 276);
            this.listTasks.TabIndex = 0;
            this.listTasks.UseCompatibleStateImageBehavior = false;
            this.listTasks.View = System.Windows.Forms.View.List;
            this.listTasks.SelectedIndexChanged += new System.EventHandler(this.listTasks_SelectedIndexChanged);
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
            // btnSetState
            // 
            this.btnSetState.Location = new System.Drawing.Point(176, 336);
            this.btnSetState.Name = "btnSetState";
            this.btnSetState.Size = new System.Drawing.Size(160, 32);
            this.btnSetState.TabIndex = 5;
            this.btnSetState.Text = "Mark done";
            this.btnSetState.UseVisualStyleBackColor = true;
            this.btnSetState.Visible = false;
            this.btnSetState.Click += new System.EventHandler(this.btnSetState_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(384, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnCleanAllDone
            // 
            this.btnCleanAllDone.Location = new System.Drawing.Point(8, 336);
            this.btnCleanAllDone.Name = "btnCleanAllDone";
            this.btnCleanAllDone.Size = new System.Drawing.Size(160, 32);
            this.btnCleanAllDone.TabIndex = 4;
            this.btnCleanAllDone.Text = "Clean all done";
            this.btnCleanAllDone.UseVisualStyleBackColor = true;
            this.btnCleanAllDone.Click += new System.EventHandler(this.btnCleanAllDone_Click);
            // 
            // frmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 373);
            this.Controls.Add(this.btnCleanAllDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSetState);
            this.Controls.Add(this.numNewTaskDuration);
            this.Controls.Add(this.txtNewTaskName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listTasks);
            this.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTaskList";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.frmTaskList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNewTaskDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listTasks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewTaskName;
        private System.Windows.Forms.NumericUpDown numNewTaskDuration;
        private System.Windows.Forms.Button btnSetState;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCleanAllDone;
    }
}