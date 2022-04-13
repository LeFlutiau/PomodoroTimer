using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Threading;

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
        private DateTime timerEnd;
        
        public frmTimer( ProgramData data )
        {
            InitializeComponent();
            this.data = data;
            timerEnd = DateTime.Now;
            timerState = TimerStates.NoTask;
            spent = 0;
            UpdateTimerDisplay();
            timer1.Stop();
            btnDone.Visible = false;
            this.Icon = Properties.Resources.tomato;
        }
        private void UpdateTimerDisplay()
        {
            int m;
            int s;

            timerValue = (int)( (timerEnd - DateTime.Now).TotalSeconds );

            m = timerValue / 60;
            s = timerValue % 60;

            lblTimerValue.Text = m.ToString("00") + ":" + s.ToString("00");
        }        
        private void BlinkTimer()
        {
            Color curColor = lblTimerValue.ForeColor;
            for( int i = 0; i < 5; i++)
            {
                lblTimerValue.ForeColor = Color.Black;
                lblTimerValue.Update();
                Thread.Sleep(500);
                lblTimerValue.ForeColor = curColor;
                lblTimerValue.Update();
                Thread.Sleep(500);
            }
        }
        private void SetTimerToShortPause()
        {
            this.lblTimerValue.ForeColor = Color.Green;
            timerEnd = DateTime.Now.AddMinutes(data.optionShortPauseDuration);
            UpdateTimerDisplay();
        }
        private void SetTimerToLongPause()
        {
            this.lblTimerValue.ForeColor = Color.Green;
            timerEnd = DateTime.Now.AddMinutes(data.optionLongPauseDuration);
            UpdateTimerDisplay();
        }
        private void SetTimerToTask()
        {
            lblTimerValue.ForeColor = Color.Yellow;
            timerEnd = DateTime.Now.AddMinutes( data.optionPomodoroDuration );
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
                
                // No task -> call task list
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

                // Stopped -> Start
                case TimerStates.Stopped:
                    timerState = TimerStates.TaskRunning;
                    SetTimerToTask();
                    btnStopStart.Text = "Stop timer";
                    timer1.Start();
                    break;

                // Running -> Stop
                case TimerStates.TaskRunning:
                    timer1.Stop();
                    timerState = TimerStates.Stopped;
                    SetTimerToTask();
                    btnStopStart.Text = "Start timer";
                    break;

                // Pause -> Stopped
                case TimerStates.ShortPauseRunning:
                case TimerStates.LongPauseRunning:
                    timerState = TimerStates.Stopped;
                    timer1.Stop();

                    btnStopStart.Text = "Start timer";
                    break;
            }
        }
        private void btnTaskList_Click(object sender, EventArgs e)
        {
            frmTaskList form;
            form = new frmTaskList( data );
            form.ShowDialog();
            if( (data.currentTask != null) && ( timerState != TimerStates.TaskRunning ) ) 
            {
                btnStopStart.Text = "Start timer";
                DisplayTaskAdvance();
                // timerState = TimerStates.Stopped;
                SetTimerToTask();
                // btnStopStart.Text = "Start timer";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerValue--;
            UpdateTimerDisplay();
            if ((timerValue <= 5 ) && (timerState == TimerStates.TaskRunning ))
            {
                lblTimerValue.ForeColor = Color.Red;
            }
            if (timerValue <= 0)
            {
                timer1.Stop();
                SoundPlayer simpleSound = new SoundPlayer(@".\sounds\alarm.wav");
                simpleSound.Play();
                BlinkTimer();
                timer1.Start();
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
                        btnStopStart.Text = "Stop pause";
                        break;
                    case TimerStates.ShortPauseRunning:
                    case TimerStates.LongPauseRunning:
                        SetTimerToTask();
                        timer1.Stop();
                        btnStopStart.Text = "Start timer";
                        break;
                }
                DisplayTaskAdvance();
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
