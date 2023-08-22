using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacManGUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Loading.Value += 10;
            if (Loading.Value == 50)
            {
                timer1.Enabled = false;
                this.Hide();
                Form game = new StartMenu();
                game.ShowDialog();
                this.Show();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Loading_Click(object sender, EventArgs e)
        {

        }
    }
}
