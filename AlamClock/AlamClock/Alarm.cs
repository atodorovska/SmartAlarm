using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;

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
        public static WMPLib.WindowsMediaPlayer player { set; get; }

        public Alarm(String date, String time, int snooze, int limit,String ringtone)
        {
            this.Time = time;
            this.Date = date;
            this.Snooze = snooze;
            this.Ringtone = ringtone;
            this.Limit = limit;
            player= new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\Dragana\Downloads\yourbody.mp3";
            player.controls.stop();
            // = Ringtone
            Game = 0;
        }

        public bool check()
        {
            String currDate = DateTime.Now.ToString("dd/MM/yyyy");
            String currTime = DateTime.Now.ToString("h:mm tt"); 
            if (Date == currDate && Time == currTime)
               return true;
            else return false;
        }

        public void start()
        {
            player.controls.play();
            //if(Game==0)
            Maze mazeGame = new Maze();
            mazeGame.Show();
        }
        
    }
}
