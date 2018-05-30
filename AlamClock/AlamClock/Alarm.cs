using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using AlarmClock.Properties;
using System.Globalization;

namespace AlarmClock
{
    public class Alarm
    {
        public String Date { set; get; }
        public String Time { set; get; }
        public int Snooze { set; get; }
        public int Limit { set; get; }
        public String Ringtone { set; get; }
        public int Game { set; get; }  
        public static SoundPlayer  player { set; get; }
        public bool SnoozeMode { set; get; }

        public Alarm(String date, String time, int snooze, int limit,String ringtone)
        {
            this.Time = time;
            this.Date = date;
            this.Snooze = snooze;
            this.Ringtone = ringtone;
            this.Limit = limit;
            player = new SoundPlayer(Resources.lalala);
            // = Ringtone
            Game = 0;
            SnoozeMode = false;
        }

        public bool check()
        {
            String currDate = DateTime.Now.ToString("dd/MM/yyyy");
            String currTime = DateTime.Now.ToString("h:m tt");
            
            if (Date == currDate && Time == currTime && Limit == 0)
            {
                return true;
            } 
            else
            {
                if (Date == currDate && Time == currTime && SnoozeMode == false)
                {
                    SnoozeMode = true;
                    SnoozeIt snoozeBox = new SnoozeIt();
                    player.Play();
                    if (snoozeBox.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    {
                        player.Stop();
                        SnoozeMode = false;
                        return true;
                    }
                    else
                    {
                        player.Stop();
                        SnoozeMode = false;
                        DateTime dateTime = DateTime.Now;
                        dateTime = dateTime.AddMinutes(Snooze);
                        Date = dateTime.ToString("dd/MM/yyyy");
                        Time = dateTime.ToString("h:m tt");
                        Limit--;
                    }
                }
                return false;
            }
        }

        public void start()
        {
            player.Play();
            //if(Game==0)
            Maze mazeGame = new Maze();
            mazeGame.Show();
        }
        
    }
}
