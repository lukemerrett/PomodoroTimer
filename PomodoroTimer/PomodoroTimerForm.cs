using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class PomodoroTimerForm : Form
    {
        private const string _timeFormatString = @"mm\:ss";

        private Timer secondTimer = new Timer { Interval = 1000 };
        private TimeSpan FocusTime = TimeSpan.FromMinutes(25);
        private TimeSpan ElapsedTime = new TimeSpan(0);

        private bool _timerStarted;

        public PomodoroTimerForm()
        {
            InitializeComponent();
            ResetTimer();
            secondTimer.Tick += timer_Tick;
        }

        private void btnStartToggle_Click(object sender, EventArgs e)
        {
            if (!_timerStarted)
            {
                secondTimer.Start();
                btnStartToggle.Text = "Stop Timer";
                _timerStarted = true;
            }
            else
            {
                secondTimer.Stop();
                btnStartToggle.Text = "Start Timer";
                _timerStarted = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ElapsedTime = ElapsedTime.Add(TimeSpan.FromSeconds(1));

            if (ElapsedTime.TotalMilliseconds >= FocusTime.TotalMilliseconds)
            {
                ResetTimer();
            }
            else
            {
                lblTimer.Text = FocusTime.Subtract(ElapsedTime).ToString(_timeFormatString); 
            }
        }

        private void ResetTimer()
        {
            secondTimer.Stop();
            ElapsedTime = new TimeSpan(0);
            lblTimer.Text = FocusTime.ToString(_timeFormatString); 

            btnStartToggle.Text = "Start Timer";
            _timerStarted = false; 
        }
    }
}
