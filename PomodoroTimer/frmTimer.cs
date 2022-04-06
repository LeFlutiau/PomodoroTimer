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
    public partial class frmTimer : Form
    {
        enum TimerStates
        {
            NoTask,
            Stopped,
            TaskRunning,
            ShortPauseRunning,
            LongPauseRunning
        }

        public ProgramData data;
        private TimerStates timerState;
        private int timerValue;
        private int spent;      // number of tomtatoes spent since started
        private Task currentTask;
        private Point _mouseLoc;
        public frmTimer( ProgramData data )
        {
            InitializeComponent();
            this.data = data;
            timerValue = 0;
            timerState = TimerStates.NoTask;
            spent = 0;
            UpdateTimerDisplay();
            timer1.Stop();
        }

        private void UpdateTimerDisplay()
        {
            int m;
            int s;
                
            m = timerValue / 60;
            s = timerValue % 60;

            this.lblTimerValue.Text = m.ToString("00") + ":" + s.ToString("00");
        }

        private void SetTimerToShortPause()
        {
            this.lblTimerValue.ForeColor = Color.Green;
            this.timerValue = data.optionShortPauseDuration;
            UpdateTimerDisplay();
        }
        private void SetTimerToLongPause()
        {
            this.lblTimerValue.ForeColor = Color.Green;
            this.timerValue = data.optionLongPauseDuration;
            UpdateTimerDisplay();
        }

        private void SetTimerToTask()
        {
            this.lblTimerValue.ForeColor = Color.Yellow;
            this.timerValue = data.optionPomodoroDuration;
            UpdateTimerDisplay();
        }

        private void DisplayTaskAdvance()
        {
            lblCurrentTask.Text =
                   currentTask.Name + " (" +
                   currentTask.Elapsed.ToString() + "/" +
                   currentTask.Planned.ToString() + ")";
        }

        private void btnStopStart_Click(object sender, EventArgs e)
        {
            switch( timerState ) {
                
                case TimerStates.NoTask:
                    frmNewTask form;
                    form = new frmNewTask( data );
                    form.ShowDialog();
                    if (form.task.Planned != -1) {
                        currentTask = form.task;
                        currentTask.Elapsed = 0;
                        DisplayTaskAdvance();
                        timerState = TimerStates.Stopped;
                        SetTimerToTask();
                        btnStopStart.Text = "Start timer";
                    }
                    break;

                case TimerStates.Stopped:
                    timerState = TimerStates.TaskRunning;
                    SetTimerToTask();
                    btnStopStart.Text = "Stop timer";
                    timer1.Start();
                    break;

                case TimerStates.TaskRunning:
                case TimerStates.ShortPauseRunning:
                case TimerStates.LongPauseRunning:
                    timerState = TimerStates.Stopped;
                    btnStopStart.Text = "Start timer";
                    timer1.Stop();
                    break;
            }
        }

        private void btnTaskList_Click(object sender, EventArgs e)
        {
            frmTaskList form;
            form = new frmTaskList( data );
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerValue--;
            UpdateTimerDisplay();
            if ((timerValue < 5 ) && (timerState == TimerStates.TaskRunning ))
            {
                lblTimerValue.ForeColor = Color.Red;
            }
            if (timerValue == 0)
            {
                DisplayTaskAdvance();
                switch (timerState) {
                    case TimerStates.TaskRunning:
                        spent++;
                        currentTask.Elapsed++;

                        if( spent == data.optionLongPauseAfter )
                        {
                            spent = 0;
                            timerState = TimerStates.LongPauseRunning;
                            SetTimerToLongPause();
                        }
                        else
                        {                               
                            timerState = TimerStates.ShortPauseRunning;
                            SetTimerToShortPause();
                        }
                        break;
                    case TimerStates.ShortPauseRunning:
                    case TimerStates.LongPauseRunning:
                        SetTimerToTask();
                        btnStopStart.Text = "Start timer";
                        timer1.Stop();
                        break;
                }
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions form;
            form = new frmOptions(data);
            form.ShowDialog();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
