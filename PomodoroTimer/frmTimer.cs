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
        public frmTimer( ProgramData data )
        {
            InitializeComponent();
            this.data = data;
            timerValue = 0;
            timerState = TimerStates.NoTask;
            spent = 0;
            UpdateTimerDisplay();
            timer1.Stop();
            btnDone.Visible = false;
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
            this.timerValue = data.optionShortPauseDuration * 60;
            UpdateTimerDisplay();
        }
        private void SetTimerToLongPause()
        {
            this.lblTimerValue.ForeColor = Color.Green;
            this.timerValue = data.optionLongPauseDuration * 60;
            UpdateTimerDisplay();
        }

        private void SetTimerToTask()
        {
            this.lblTimerValue.ForeColor = Color.Yellow;
            this.timerValue = data.optionPomodoroDuration * 60;
            UpdateTimerDisplay();
        }

        private void DisplayTaskAdvance()
        {
            lblCurrentTask.Text =
                   data.currentTask.Name + " (" +
                   data.currentTask.Elapsed.ToString() + "/" +
                   data.currentTask.Planned.ToString() + ")";
        }

        private void btnStopStart_Click(object sender, EventArgs e)
        {
            switch( timerState ) {
                
                case TimerStates.NoTask:
                    frmTaskList form;
                    form = new frmTaskList( data );
                    form.ShowDialog();
                    if (data.currentTask != null) {
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
                    timerState = TimerStates.Stopped;
                    btnStopStart.Text = "Start timer";
                    timer1.Stop();
                    break;

                case TimerStates.ShortPauseRunning:
                case TimerStates.LongPauseRunning:
                    timerState = TimerStates.Stopped;
                    btnStopStart.Text = "Stop pause";
                    timer1.Stop();
                    break;
            }
        }

        private void btnTaskList_Click(object sender, EventArgs e)
        {
            frmTaskList form;
            form = new frmTaskList( data );
            form.ShowDialog();
            if (data.currentTask != null)
            {
                DisplayTaskAdvance();
                timerState = TimerStates.Stopped;
                SetTimerToTask();
                btnStopStart.Text = "Start timer";
            }
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
                        data.currentTask.Elapsed++;

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
