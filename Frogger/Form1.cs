using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Frogger
{
    public partial class Form1 : Form
    {
        List<PictureBox> cars = new List<PictureBox>();
        List<PictureBox> trucks = new List<PictureBox>();
        List<PictureBox> endFrogs = new List<PictureBox>();
        List<PictureBox> logLs = new List<PictureBox>();
        List<PictureBox> logRs = new List<PictureBox>();
        int score = 0;
        int timeScore = 500;
        WMPLib.WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();

            cars.Add(pbCar1); cars.Add(pbCar2); cars.Add(pbCar3); cars.Add(pbCar4); cars.Add(pbCar5); cars.Add(pbCar6);
            trucks.Add(pbTruck1); trucks.Add(pbTruck2); trucks.Add(pbTruck3); trucks.Add(pbTruck4);
            endFrogs.Add(pbEndFrog1); endFrogs.Add(pbEndFrog2); endFrogs.Add(pbEndFrog3); endFrogs.Add(pbEndFrog4); endFrogs.Add(pbEndFrog5);
            logLs.Add(pbLogL1); logLs.Add(pbLogL2); logRs.Add(pbLogR1); logRs.Add(pbLogR2); logRs.Add(pbLogR3); logRs.Add(pbLogR4);

            wplayer.URL = Environment.CurrentDirectory + "\\AxelF.mp3";
            wplayer.settings.setMode("loop", true);
            wplayer.controls.play();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            foreach(PictureBox endFrog in endFrogs){
                endFrog.Visible = false;
            }
            groupBoxMenu.Visible = false;
            TrafficTimer.Enabled = true;
            scoreTimer.Enabled = true;
            this.KeyPreview = true;
            score = 0;
            timeScore = 500;
        }

        private void TrafficTimer_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox car in cars)
            {
                car.Left += 2;
                if (car.Left > this.ClientRectangle.Width + 15)
                    car.Left = -20;
            }

            foreach (PictureBox truck in trucks)
            {
                truck.Left -= 1;
                if (truck.Left < -35)
                    truck.Left = this.ClientRectangle.Width + 40;
            }

            foreach (PictureBox log in logLs)
            {
                log.Left -= 1;
                if (log.Left < -35)
                    log.Left = this.ClientRectangle.Width + 40;
            }

            foreach (PictureBox log in logRs)
            {
                log.Left += 2;
                if (log.Left > this.ClientRectangle.Width + 30)
                    log.Left = -20;
            }

            if (CollisionDetector())
                Lose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode){
                case Keys.Up:
                case Keys.W:
                    if(pbFrog.Top < 40){
                        break;
                    }
                    if (!(pbFrog.Top <= 50))
                        pbFrog.Top -= 30;
                    else if ((pbFrog.Left > 0 && pbFrog.Left < 30) || (pbFrog.Left > 70 && pbFrog.Left < 90) || (pbFrog.Left > 130 && pbFrog.Left < 150) || (pbFrog.Left > 190 && pbFrog.Left < 210) || (pbFrog.Left > 250 && pbFrog.Left < 270))
                        pbFrog.Top -= 30;
                    break;
                case Keys.Down:
                case Keys.S:
                    pbFrog.Top += 30;
                    break;
                case Keys.Left:
                case Keys.A:
                    pbFrog.Left -= 20;
                    break;
                case Keys.Right:
                case Keys.D:
                    pbFrog.Left += 20;
                    break;
            }
        }

        private bool CollisionDetector(){
            int visiCount = 0;
            foreach(PictureBox endFrog in endFrogs){
                if (pbFrog.Bounds.IntersectsWith(endFrog.Bounds) && !endFrog.Visible)
                {
                    endFrog.Visible = true;
                    score += 200 + timeScore;
                    labScore.Text = String.Format("Score: {0}", score);
                    pbFrog.Top = 290; pbFrog.Left = 140;
                    timeScore = 500;
                }
                if (endFrog.Visible)
                    visiCount++;
                if(visiCount == 5){
                    score += 5000;
                    labScore.Text = String.Format("Score: {0}", score);

                    foreach (PictureBox endFrogVis in endFrogs)
                    {
                        endFrogVis.Visible = false;
                    }
                }
            }

            foreach (PictureBox car in cars)
            {
                if (pbFrog.Bounds.IntersectsWith(car.Bounds))
                    return true;
            }

            foreach (PictureBox truck in trucks)
            {
                if (pbFrog.Bounds.IntersectsWith(truck.Bounds))
                    return true;
            }

            if (pbFrog.Bounds.IntersectsWith(pbRiver.Bounds))
            {
                if (pbFrog.Bounds.IntersectsWith(pbLogL1.Bounds) || pbFrog.Bounds.IntersectsWith(pbLogL2.Bounds))
                    pbFrog.Left -= 1;
                else if (pbFrog.Bounds.IntersectsWith(pbLogR1.Bounds) || pbFrog.Bounds.IntersectsWith(pbLogR2.Bounds) || pbFrog.Bounds.IntersectsWith(pbLogR3.Bounds) || pbFrog.Bounds.IntersectsWith(pbLogR4.Bounds))
                    pbFrog.Left += 2;
                else
                    return true;
            }

            if(!pbFrog.Bounds.IntersectsWith(this.ClientRectangle))
                return true;

            return false;
        }

        private void Lose()
        {
            TrafficTimer.Enabled = false;
            scoreTimer.Enabled = false;
            this.KeyPreview = false;
            groupBoxMenu.Visible = true;
            pbFrog.Top = 290;
            pbFrog.Left = 140;
            labScore.Text = "Score: 0";
            wplayer.controls.pause();
            WMPLib.WindowsMediaPlayer mplayer = new WindowsMediaPlayer();
            mplayer.URL = Environment.CurrentDirectory + "//GGWP.mp3";
            mplayer.controls.play();
            MessageBox.Show("R.I.P. Frog, You'll be missed");
            mplayer.controls.stop();
            wplayer.controls.play();
        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            if(!(timeScore < 0))
                timeScore--;
        }
    }
}
