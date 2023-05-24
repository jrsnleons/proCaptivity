
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProductivityApp.Views
{
    public partial class PomodoroPage: ContentPage
    {
        private TimeSpan workTime = TimeSpan.FromMinutes(25);
        private TimeSpan restTime = TimeSpan.FromMinutes(1);
        private TimeSpan currentTime;
        private bool isWorking;

        public PomodoroPage()
        {
            InitializeComponent();
        }

        private TimeSpan remainingTime; // Added field to store remaining time

        private void StartButton_Clicked(object sender, EventArgs e)
        {
            isWorking = !isWorking;
            if (isWorking)
            {
                statusLabel.Text = "Working";
                statusLabel.TextColor = Color.Red;
                timerLabel.TextColor = Color.Red;
                if (remainingTime == TimeSpan.Zero)
                {
                    currentTime = workTime;
                }
                else
                {
                    currentTime = remainingTime; // Resume from the remaining time
                    remainingTime = TimeSpan.Zero; // Reset remaining time
                }
                startButton.Text = "Pause";
                resetButton.IsEnabled = false;
                Device.StartTimer(TimeSpan.FromSeconds(1), TimerTick);
            }
            else
            {
                statusLabel.Text = "Paused";
                startButton.Text = "Resume";
                resetButton.IsEnabled = true;
                remainingTime = currentTime; // Store remaining time when pausing
            }
        }


        private bool TimerTick()
        {
            currentTime = currentTime.Subtract(TimeSpan.FromSeconds(1));
            timerLabel.Text = FormatTime(currentTime);

            if (currentTime <= TimeSpan.Zero)
            {
                if (isWorking)
                {
                    statusLabel.Text = "Resting";
                    statusLabel.TextColor = Color.Green;
                    timerLabel.TextColor = Color.Green; // Change color to green during rest
                    currentTime = restTime;
                }
                else
                {
                    statusLabel.Text = "Working";
                    statusLabel.TextColor = Color.Red;
                    timerLabel.TextColor = Color.Red; // Change color to red during work
                    currentTime = workTime;
                }
                isWorking = !isWorking; // Switch between work and rest
            }

            return isWorking;
        }





        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            statusLabel.Text = "Working";
            statusLabel.TextColor = Color.Red;
            timerLabel.TextColor = Color.Red;
            currentTime = workTime;
            timerLabel.Text = FormatTime(currentTime);
            startButton.Text = "Start";
            resetButton.IsEnabled = false;
        }

        private string FormatTime(TimeSpan timeSpan)
        {
            return timeSpan.ToString(@"mm\:ss");
        }
    }
}
