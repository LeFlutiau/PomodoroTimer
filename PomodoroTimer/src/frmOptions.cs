using System;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class frmOptions : Form
    {
        private ProgramData data;

        public frmOptions( ProgramData data )
        {
            InitializeComponent();
            this.data = data;         
            this.numPomodoroDuration.Value = data.optionPomodoroDuration;
            this.numShortPauseDuration.Value = data.optionShortPauseDuration;
            this.numLongPauseDuration.Value = data.optionLongPauseDuration;
            this.numCountToLongPause.Value = data.optionLongPauseAfter;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.data.optionPomodoroDuration = (int)this.numPomodoroDuration.Value;
            this.data.optionShortPauseDuration = (int)this.numShortPauseDuration.Value;
            this.data.optionLongPauseDuration = (int)this.numLongPauseDuration.Value;
            this.data.optionLongPauseAfter = (int)this.numCountToLongPause.Value;
            this.Close();
        }
    }
}
