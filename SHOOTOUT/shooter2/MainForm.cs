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

namespace shooter2
{
    public partial class MainForm : Form
    {
        bool isComp = false;
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
            textBox1.Select();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            GamemodeSelection gm = new GamemodeSelection();
            DialogResult r = gm.ShowDialog();
            if (!gm.illegal)
            {
                if (r == DialogResult.Yes) isComp = true;
                else if (r == DialogResult.No) isComp = false;
                string username = textBox1.Text;
                if (username == "") username = null;
                gf game = new gf(username, isComp);
                game.Show();
                this.Hide();
            }
        }

        private void showScoreboard_Click(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader("..\\\\..\\\\scoreboard.txt");
            listBox1.Show();
            listBox1.Items.Clear();
            string a = r.ReadLine();
            while (a != null)
            {
                listBox1.Items.Add(a);
                a = r.ReadLine();
            }
            r.Close();
        }
        private void resetScoreboard_Click(object sender, EventArgs e)
        {
            StreamWriter r = new StreamWriter("..\\\\..\\\\scoreboard.txt", false);
            r.Write((string)null);
            r.Close();
            listBox1.Items.Clear();
            listBox1.Hide();
        }
    }
}
