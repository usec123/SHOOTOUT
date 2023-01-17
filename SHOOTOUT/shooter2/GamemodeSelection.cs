using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shooter2
{
    public partial class GamemodeSelection : Form
    {
        public bool illegal = true;
        public GamemodeSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            illegal = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            illegal = false;
        }
    }
}
