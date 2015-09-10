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
    public partial class Timer : Form
    {
        private bool _timerStarted;

        public Timer()
        {
            InitializeComponent();
        }

        private void btnStartToggle_Click(object sender, EventArgs e)
        {

            if (!_timerStarted)
            {
                btnStartToggle.Text = "Stop Timer";
                _timerStarted = true;
            }
            else
            {
                btnStartToggle.Text = "Start Timer";
                _timerStarted = false;
            }
        }
    }
}
