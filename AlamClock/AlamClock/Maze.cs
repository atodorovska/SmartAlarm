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
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
        }

        private void Finish_MouseEnter(object sender, EventArgs e)
        {
            Alarm.player.Stop();
            this.Close();
        }

        public void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(15, 15);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
