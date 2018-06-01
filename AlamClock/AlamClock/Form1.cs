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
using AlarmClock.Properties;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            DatePicker.Value = DateTime.Now;
            timer1.Start();
            btnRemove.Enabled = false;
            btnChange.Enabled = false;
            lbSongs.Items.Add("Lalala");
            //add other songs
        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            String date = DatePicker.Value.ToString("dd/MM/yyyy");
            String time = upDownHours.Value +":"+upDownMinutes.Value +" " + upDownPMAM.Text;
            String song = "Lalala"; // default value
            if (lbSongs.SelectedItem != null)
                song = lbSongs.SelectedItem as String;
            Alarm a = new Alarm(date, time,(int)upDownSnooze.Value, (int)upDownTimes.Value,song);
            lbAlarms.Items.Add(a);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbAlarms.Items.Count != 0)
            {
                foreach (Alarm a in lbAlarms.Items)
                { 
                    if (a.Done == true)
                    {
                        continue;
                    }
                    else if (a.check() && a.AlarmOn == false)
                    { 
                        a.start();

                    }
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
            if (upDownSnooze.Value == 0)
                upDownTimes.Value = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbAlarms.Items.Remove(lbAlarms.SelectedItem);
        }

        private void lbAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lbAlarms.SelectedItem != null;
            btnChange.Enabled = lbAlarms.SelectedItem != null;
        }

        private void upDownTimes_ValueChanged(object sender, EventArgs e)
        {
            if (upDownTimes.Value != 0 && upDownSnooze.Value == 0)
                upDownSnooze.Value = 1;
            if (upDownTimes.Value == 0)
                upDownSnooze.Value = 0;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Alarm selected = (lbAlarms.SelectedItem as Alarm);
            // Display all data for the chosen alarm and make changes
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
