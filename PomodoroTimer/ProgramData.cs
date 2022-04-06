using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Pomodoro
{
    public class ProgramData
    {
        public List<Task> tasks;
        public Task currentTask = null;
        public int optionPomodoroDuration = 25;     // duration of pomodoro
        public int optionTaskMaxPomodoro = 6;       // maximum number of pomodoro per task
        public int optionShortPauseDuration = 5;    // short pause duration
        public int optionLongPauseDuration = 20;    // long pause duration
        public int optionLongPauseAfter = 4;        // number of pomodoro before a long pause

        public ProgramData()
        {
            tasks = new List<Task>();
        }

        public void addTask( Task newTask ) { tasks.Add( newTask ); }

        public bool Save() {
            try
            {
                string fileName = Application.UserAppDataPath + @"\tasks.json";
                string jsonString = JsonSerializer.Serialize(tasks);
                File.WriteAllText(fileName, jsonString);
            }
            catch
            {
                MessageBox.Show("Something went wrong while saving data");
                return false;
            }
            return true;
        }

        public bool Load()
        {
            try
            {
                string fileName = Application.UserAppDataPath + @"\tasks.json";
                string jsonString = File.ReadAllText(fileName);
                this.tasks = JsonSerializer.Deserialize<List<Task>>(jsonString);
            }
            catch
            {
                MessageBox.Show("Something went wrong while reading data");
                return false;
            }
            return true;
        }
    }
}
