using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            alarmON = false;
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            
            String date = DatePicker.Value.ToString("dd/MM/yyyy");
            String time = upDownHours.Value +":"+upDownMinutes.Value +" " + upDownPMAM.Text;
            a = new Alarm(date, time, 0, 0, "bla");
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
    }
}
