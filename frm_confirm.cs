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

namespace ChatsUp
{
    public partial class frm_confirm : Form
    {
        int x, y;
        System.Drawing.Point ad_point = new System.Drawing.Point();

        public frm_confirm()
        {
            InitializeComponent();
        }
        

        private void btn_non_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_principal fr = new frm_principal();
            frm_nous_ecrire fr2 = new frm_nous_ecrire();
            frm_about_box fr3 = new frm_about_box();

            fr.Enabled = true;
            fr2.Enabled = true;
            fr3.Enabled = true;
        }

        private void btn_oui_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void frm_confirm_Load(object sender, EventArgs e)
        {
            frm_principal fr = new frm_principal();
            frm_nous_ecrire fr2 = new frm_nous_ecrire();
            frm_about_box fr3 = new frm_about_box();

            fr.Enabled = false;
            fr2.Enabled = false;
            fr3.Enabled = false;
        }
    }
}
