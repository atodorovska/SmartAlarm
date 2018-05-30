using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
        private Alarm a;
        private bool alarmON;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            DatePicker.Value = DateTime.Now;
            alarmON = false;
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            
            String date = DatePicker.Value.ToString("dd/MM/yyyy");
            String time = upDownHours.Value +":"+upDownMinutes.Value +" " + upDownPMAM.Text;
            a = new Alarm(date, time,(int)upDownSnooze.Value, (int)upDownTimes.Value,"bla");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (alarmON == false)
            {
                if (a!= null && a.check())
               {
                alarmON = true;
                a.start();
                }
            }
        }

        private void upDownMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (upDownMinutes.Value == -1)
                upDownMinutes.Value = 59;
            if (upDownMinutes.Value == 60)
                upDownMinutes.Value = 0;
        }

        private void upDownHours_ValueChanged(object sender, EventArgs e)
        {
            if (upDownHours.Value == 0)
                upDownHours.Value = 12;
            if (upDownHours.Value == 13)
                upDownHours.Value = 1;
        }

        private void upDownSnooze_ValueChanged(object sender, EventArgs e)
        {
            if (upDownSnooze.Value != 0 && upDownTimes.Value == 0)
                upDownTimes.Value = 1;
            
        }
    }
}
