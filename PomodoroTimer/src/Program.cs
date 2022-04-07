using System;
using System.Windows.Forms;

namespace Pomodoro
{
    internal static class Program
    {       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProgramData data;
            frmTimer form;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        
            data = new ProgramData();
            form = new frmTimer( data );

            // load settings and tasks
            data.optionPomodoroDuration = Settings1.Default.PomodoroDuration;
            data.optionShortPauseDuration = Settings1.Default.ShortPauseDuration;
            data.optionLongPauseDuration = Settings1.Default.LongPauseDuration;
            data.optionLongPauseAfter = Settings1.Default.LongPauseAfter;
            data.Load();

            Application.Run(form);

            // save settings and tasks
            Settings1.Default.PomodoroDuration = data.optionPomodoroDuration;
            Settings1.Default.ShortPauseDuration = data.optionShortPauseDuration;
            Settings1.Default.LongPauseDuration = data.optionLongPauseDuration;
            Settings1.Default.LongPauseAfter = data.optionLongPauseAfter;
            Settings1.Default.Save();
            data.Save();
        }
    }
}
