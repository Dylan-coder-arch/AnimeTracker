using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeTracker
{
    public partial class frmMain : KryptonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl uc, Panel pnlContainer)
        {
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uc);

        }

        private void kbtnHomeMenu_Click(object sender, EventArgs e)
        {
            uctHome home = new uctHome();
            
            addUserControl(home, pnlContent);
            
        }

        private void kbtnAddAnimeMenu_Click(object sender, EventArgs e)
        {
            uctAdd add = new uctAdd();
            addUserControl(add, pnlContent);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            // sign out maybe ?
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            // Settings - Theme 
            // Font sizing maybe ?

            
        }

        private void kbtnAnimeTrackMenu_Click(object sender, EventArgs e)
        {
            
            uctDash dash = new uctDash();
            addUserControl(dash, pnlContent);
        }
    }
}
