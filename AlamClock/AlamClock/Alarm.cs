using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using AlarmClock.Properties;

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
        }

        public bool check()
        {
            String currDate = DateTime.Now.ToString("dd/MM/yyyy");
            String currTime = DateTime.Now.ToString("h:m tt");
            
            if (Date == currDate && Time == currTime)
               return true;
            else return false;
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
