using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class PomodoroTimerForm : Form
    {
        private const string _timeFormatString = @"mm\:ss";

        private Timer _secondTimer = new Timer { Interval = 1000 };

        private TimeSpan _focusTime = TimeSpan.FromMinutes(25);

        private TimeSpan _elapsedTime = new TimeSpan(0);

        private SoundPlayer _alarmSound = new SoundPlayer(@"Resources/Alarm.wav");

        private bool _timerStarted;

        public PomodoroTimerForm() 
        {
            InitializeComponent();
            ResetTimer();
            _secondTimer.Tick += timer_Tick;
        }

        private void btnStartToggle_Click(object sender, EventArgs e)
        {
            if (!_timerStarted)
            {
                _secondTimer.Start();
                btnStartToggle.Text = "Stop Timer";
                _timerStarted = true;
            }
            else
            {
                _secondTimer.Stop();
                btnStartToggle.Text = "Start Timer";
                _timerStarted = false;
            }
        }

        private void btnResetButton_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime = _elapsedTime.Add(TimeSpan.FromSeconds(1));

            if (_elapsedTime.TotalMilliseconds >= _focusTime.TotalMilliseconds)
            {
                ResetTimer();
                _alarmSound.Play();
            }
            else
            {
                lblTimer.Text = _focusTime.Subtract(_elapsedTime).ToString(_timeFormatString); 
            }
        }

        private void ResetTimer()
        {
            _secondTimer.Stop();
            _elapsedTime = new TimeSpan(0);
            lblTimer.Text = _focusTime.ToString(_timeFormatString); 

            btnStartToggle.Text = "Start Timer";
            _timerStarted = false; 
        }        
    }
}
