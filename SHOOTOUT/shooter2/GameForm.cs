using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Activities.Statements;

namespace shooter2
{
    public partial class gf : Form
    {
        bool isComp;
        bool gameOver = false;

        public Point mouseLocation;
        public Point shoot;
        public Point startLoc;
        public Point hidePoint = new Point(-200, 10);


        public int xvel = 0;
        public int yvel = 0;
        public bool flipped = false;
        public bool shootable = true;
        public bool backwards = false;
        Random r = new Random();
        public string username = null;
        

        public gf(string un, bool comp)
        {
            Username = un;
            isComp = comp;
            InitializeComponent();
        }
        public string Username
        {
            get { return username; }
            set { if (value!=null) username = value;}
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!gameOver)
            {
                DialogResult r = MessageBox.Show("Should the score be saved to the scoreboard?", "Save scoreboard?",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                switch (r)
                {
                    case DialogResult.Yes:
                        StreamWriter sr = new StreamWriter("..\\\\..\\\\scoreboard.txt", true);
                        if (username != null)
                        {
                            sr.Write(username + " (");
                            if (isComp) sr.Write("Competitive): ");
                            else sr.Write("Casual): ");
                        }
                        sr.WriteLine(scorelbl.Text);
                        sr.Close();
                        MainForm a = new MainForm();
                        a.Show();
                        break;
                    case DialogResult.No:
                        MainForm b = new MainForm();
                        b.Show();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
            else
            {
                MainForm a = new MainForm();
                a.Show();
            }

            // how to break forms 101
            //this.Close();
        }
        private void GameForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (shootable)
            {
                Cursor.Show();
                shoot = mouseLocation;
                shooter();
                timer2.Stop();
            }
        }
        private void GameForm_MouseDown(object sender, MouseEventArgs e)
        {
            trackBar1.Value = 0;
            if (shootable)
            {
                Cursor.Hide();
                timer2.Start();
            }
            crosshair.Location = Cursor.Position;
        }
        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && shootable)
            {
                mouseLocation = new Point(e.Location.X - crosshair.Width / 2, e.Location.Y - crosshair.Width / 2);
                crosshair.Location = mouseLocation;
            }
        }
        public void shooter()
        {
            xvel = shoot.X / 10; yvel = (this.Height - shoot.Y) / 10;
            shootable = false;
            crosshair.Location = hidePoint;
            timer1.Start();
        }
        public void reset()
        {
            proj.Location = startLoc;
            xvel = 0;
            yvel = 0;
            shootable = true;
            proj.BackgroundImage = Properties.Resources.arrowup;
            flipped = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            proj.Top -= yvel + (trackBar1.Value/10)*2;
            proj.Left += xvel + (trackBar1.Value/10)*2;
            yvel -= 10;
            if (yvel < 30 && yvel > 0 && !flipped) proj.BackgroundImage = Properties.Resources.arrowsideways;
            if (yvel < -30 && !flipped) { proj.BackgroundImage = Properties.Resources.arrowup; proj.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone); flipped = true; }
            if (proj.Location.Y > this.Height || proj.Location.X > this.Width || proj.Bounds.IntersectsWith(target.Bounds))
            {
                if (proj.Bounds.IntersectsWith(target.Bounds))
                {
                    if (proj.Location.Y < island.Location.Y - (proj.Width / 3))
                    {
                        scorelbl.Text = (int.Parse(scorelbl.Text) + 1).ToString();
                        generateTarget();
                        reset();
                    }
                    else
                    {
                        xvel = 0;
                        proj.Left = island.Location.X - proj.Width;
                    }
                }
                else
                {
                    reset();
                    xvel = 0; yvel = 0;
                    if (isComp)
                    {
                        scorelbl.Text = (int.Parse(scorelbl.Text) - 1).ToString();
                        if (scorelbl.Text=="0")
                        {
                            MessageBox.Show("Game over! Your score reached 0!", "Game Over!");
                            gameOver = true;
                            this.Close();
                        }
                    }
                    timer1.Stop();
                }
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            startLoc = proj.Location;
            crosshair.Location = hidePoint;
            target.Location = hidePoint;
            island.Location = hidePoint;
            if (isComp) scorelbl.Text = 5.ToString();

            generateTarget();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!backwards)
            {
                try { trackBar1.Value += 1; }
                catch { }
                if (trackBar1.Value >= 100) backwards = true;
            }
            else
            {
                try { trackBar1.Value -= 1; }
                catch { }
                if (trackBar1.Value <= 0) backwards = false;
            }
        }


        private void generateTarget()
        {
            int x = r.Next(limit.Location.X, this.Width - island.Width);
            int y = r.Next(limit.Location.Y, this.Height - (target.Height + island.Height));
            target.Location = new Point(x, y);
            island.Location = new Point(x + target.Width / 2 - island.Width / 2, y + target.Height - 30);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.LightBlue;
        }
    }
}