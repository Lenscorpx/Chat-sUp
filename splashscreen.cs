using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatsUp
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void splashscreen_Load(object sender, EventArgs e)
        {
            notification.Icon = SystemIcons.Application;
            notification.BalloonTipText = "Bienvenu(e) dans ChatsUp";
            notification.BalloonTipTitle = "ChatsUp LensX";
            notification.Visible = true;
            notification.ShowBalloonTip(3000);
            progressBar1.BackColor = Color.Black;
            progressBar1.ForeColor = Color.Black;
            timer1.Start();
            timer1.Enabled = true;
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value==100)
            {
                timer1.Enabled = false;
                notification.Visible = false;
                frm_principal fr = new frm_principal();
                fr.Show();

                this.Hide();
            }
            else
            {
                progressBar1.Increment(+1);
            }
            
        }
    }
}
