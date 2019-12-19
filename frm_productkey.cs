using System;
using System.Configuration.Internal;
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
    public partial class frm_productkey : Form
    {
        public frm_productkey()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
           if(txt_product_key.Text != "")
           {
               if (txt_product_key.Text == Properties.Settings.Default.Password)
               {
                   splashscreen s = new splashscreen();
                   s.Show();
                   this.Hide();
                   Properties.Settings.Default.Product_Key.Replace("No", "Yes");
               }
               else
               {
                   MessageBox.Show(this,"Votre clé n'est pas authentique!","Authentification",MessageBoxButtons.OK,MessageBoxIcon.Warning);
               }
           }
            else
           {
               MessageBox.Show(this, "Completer la clé d'activation!", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
            
        }

        private void btn_autre_Click(object sender, EventArgs e)
        {
            frm_nous_ecrire fr = new frm_nous_ecrire();
            fr.Show();
            this.Hide();
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_productkey_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Product_Key.Equals("Yes"))
            {
                splashscreen s = new splashscreen();
                s.Show();
                this.Hide();

            }
        }
    }
}
