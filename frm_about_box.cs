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
    public partial class frm_about_box : Form
    {
        int x, y;
        System.Drawing.Point ad_point = new System.Drawing.Point();

        public frm_about_box()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_about_ChatsUp_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void btn_about_lens_Click(object sender, EventArgs e)
        {
            frm_nous_ecrire fr = new frm_nous_ecrire();
            fr.Show();
        }

        private void frm_about_box_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ad_point = Control.MousePosition;
                ad_point.X -= (x);
                ad_point.Y -= (y);
                this.Location = ad_point;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ad_point = Control.MousePosition;
                ad_point.X -= (x);
                ad_point.Y -= (y);
                this.Location = ad_point;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ad_point = Control.MousePosition;
                ad_point.X -= (x);
                ad_point.Y -= (y);
                this.Location = ad_point;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ad_point = Control.MousePosition;
                ad_point.X -= (x);
                ad_point.Y -= (y);
                this.Location = ad_point;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ad_point = Control.MousePosition;
                ad_point.X -= (x);
                ad_point.Y -= (y);
                this.Location = ad_point;
            }
        }
    }
}
