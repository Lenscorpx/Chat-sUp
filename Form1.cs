using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; // pour l'emplacement a l'ecran
using System.Linq;
using System.Text; // pour l'utlisation du texte dans l'appli
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO; // pour les fichiers de stockage des sms;
using System.Net.Sockets;// pour mes sockets
using System.Speech; // reference pour le speech ou la parole dans mon application
using System.Speech.Synthesis; // idem que le precedent

//Programmeur : Lens Mutombo Lukusa
//Debut du projet : Samedi, 16 mai 2015 à 19 heures 34 min
//Derniere modification : Mardi 19 mai 2015 à 8 heures 32 min

namespace ChatsUp
{
    public partial class frm_principal : Form
    {
        //NotifyIcon notification = new NotifyIcon();
        Socket sock; // declaration du socket pour le transfert en udp
        EndPoint ep_local, ep_distant; // declaration des endpoints
        byte[] buffer; // contiendra mon sms transcodé en byte,
        SpeechSynthesizer parole = new SpeechSynthesizer();// mon speech pour les alertes

        
        int x; int y; // les variables qui contiendront mon emplacement a l'ecran pour le deplacement des panels
        string text_a_envoyer; // contiendra les valeurs a envoyer
        System.Drawing.Point move_adress = new System.Drawing.Point(); // decaration des points de deplacements de l'ecran
        string nom_du_fichier;

        public frm_principal()
        {
            InitializeComponent(); // constructeur qui initialise les elements du formulaire herité venant de System.Form
        }

        private void frm_principal_Load(object sender, EventArgs e)// au chargement de mon appli, les codes qui suivent s'executent
        {
            notification.Visible = true;
            notification.ShowBalloonTip(3000, "ChatsUp LensX", "Bienvenu(e) dans ChatsUp", ToolTipIcon.Info);
            txt_nom_local.Text = Convert.ToString(System.Environment.UserName);
            btn_etat.Text = "OK";
            lbl_heure.Text = Convert.ToString(DateTime.Today.DayOfWeek) + " " + Convert.ToString(DateTime.Today.Date.ToShortDateString());

            // je configure mon socket
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);// j'utilise udp et non pas ftp ou http pour des raisons de rapidité ->> udp > ftp pour le transfert vu 
            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);// que udp ne verifie pas le paquet de donnees en cas de manque de certaines parties

            txt_mon_ip.Text = recuperer_ip(); // je recupere l'ip de ma machine
            txt_ip_partenaire.Text = recuperer_ip();// je refais la meme chose pour montrer aux utilisateurs ce qu'ils doivent faire
        }

        
        private string recuperer_ip()// fonction qui recupere l'ip
        {
            IPHostEntry hote;
            hote = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in hote.AddressList)
            { 
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }
        
        private void frm_principal_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==System.Windows.Forms.MouseButtons.Left)
            {
                move_adress = Control.MousePosition;
                move_adress.X -= (x);
                move_adress.Y -= (y);
                this.Location = move_adress;
            }
        }

        private void frm_principal_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            frm_confirm confirm = new frm_confirm();
            confirm.Show();
        }

        private void btn_reduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void btn_cacher_Click(object sender, EventArgs e)
        {
            pnl_control.Hide();
            pnl_mes_parametres.Hide();
            pnl_param_corrsp.Hide();
            pnl_photo.Hide();
            btn_show.Text = ">>";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnl_control.Visible==false)
            {
                pnl_control.Show();
                pnl_mes_parametres.Show();
                pnl_param_corrsp.Show();
                pnl_photo.Show();
                btn_show.Text = "<<";
            }
            else
            {
                pnl_control.Hide();
                pnl_mes_parametres.Hide();
                pnl_param_corrsp.Hide();
                pnl_photo.Hide();
                btn_show.Text = ">>";
            }
        }

        private void pnl_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_effacer_Click(object sender, EventArgs e)
        {
            txt_envoi.Clear();
        }

        private void txt_envoi_MouseClick(object sender, MouseEventArgs e)
        {
            btn_etat.Text = "";
            btn_etat.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst_messages.Items.Clear();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            txt_mon_ip.Text = recuperer_ip();

            if(txt_mon_ip.Text=="")
            {
                txt_mon_ip.BackColor = Color.Red;
                MessageBox.Show("Remplissez l'adresse ip local!", "IP LOCAL INEXISTANT", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            else if(txt_port_local.Text=="")
            {
                txt_port_local.BackColor = Color.Red;
                MessageBox.Show("Remplissez le port d'envoi local!", "PORT LOCAL INEXISTANT", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            else if(txt_ip_partenaire.Text=="")
            {
                txt_ip_partenaire.BackColor = Color.Red;
                MessageBox.Show("Remplissez l'adresse ip du correspondant!", "IP DISTANT INEXISTANT", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            else if(txt_port_partenaire.Text=="")
            {
                txt_port_partenaire.BackColor = Color.Red;
                MessageBox.Show("Remplissez le port d'envoi distant!", "PORT DISTANT INEXISTANT", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            else 
            {
                try
                {
                    ep_local = new IPEndPoint(IPAddress.Parse(txt_mon_ip.Text), Convert.ToInt32(txt_port_local.Text));
                    sock.Bind(ep_local);

                    ep_distant = new IPEndPoint(IPAddress.Parse(txt_ip_partenaire.Text), Convert.ToInt32(txt_port_partenaire.Text));
                    sock.Connect(ep_distant);

                    buffer = new byte[1500];
                    sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ep_distant, new AsyncCallback(Appel_message), buffer);

                    parole.SpeakAsync("Connexion Réussie");

                    notification.Icon = SystemIcons.Information;
                    notification.BalloonTipText = "Connexion réussie!!";
                    notification.BalloonTipTitle = "ChatsUp LensX";
                    notification.ShowBalloonTip(7000);

                    MessageBox.Show("Connexion réussie!", "Connexion Reussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }
        
       
        private void Appel_message(IAsyncResult lensResult)
        {
            byte[] recevoir_data = new byte[1500];
            recevoir_data =(byte[])lensResult.AsyncState;

            //Conversion des bytes en string
            ASCIIEncoding lensEncodage = new ASCIIEncoding();
            string sms_recu = lensEncodage.GetString(recevoir_data);

            //Ajout des sms à la listebox
            lst_messages.Items.Add("");
            lst_messages.Items.Add("");
            lst_messages.Items.Add(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            lst_messages.Items.Add("Message de :" + " " + sms_recu);

            notification.Icon = SystemIcons.Information;
            notification.BalloonTipText = "Vous avez reçu un nouveau message !!";
            notification.BalloonTipTitle = "ChatsUp LensX";
            notification.ShowBalloonTip(7000);

            parole.SpeakAsync("Vous avez reçu un nouveau message"+ txt_nom_partenaire.Text);
            MessageBox.Show("Vous avez reçu un nouveau message", "Nouveau SMS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, false);
            buffer = new byte[1500];
            sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ep_distant, new AsyncCallback(Appel_message), buffer);

        }

        private void Lire_sms(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader fluxRead = new StreamReader(nom_du_fichier))
                {
                    string ligne;
                    // lecture des lignes de texte dans le fichier à travers le flux :
                    while ((ligne = fluxRead.ReadLine()) != null)
                        lst_messages.Items.Add(ligne);
                    fluxRead.Close();
                } // fermeture et désallocation de l'objet fluxRead
            }
            catch(Exception ex)
            {
                MessageBox.Show("Impossible de lire le fichier");
                MessageBox.Show(ex.ToString(),"Message d'erreur",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Enregistrer_sms_Transmis(object sender, EventArgs e)
        {
            int item_nombre;// pour determiner les elements contenus dans ma listbox
            try
            {
                string nom_du_fichier, adress_fichier;
                adress_fichier = @"c:\ChatsUp\SMS\Messages Transmis\";
                nom_du_fichier = adress_fichier + "Messages.lml";

                if (!Directory.Exists(Path.GetDirectoryName(adress_fichier)))
                    Directory.CreateDirectory(Path.GetDirectoryName(adress_fichier));
                
                    using (StreamWriter fluxWrite = new StreamWriter(nom_du_fichier))
                    {
                        parole.SpeakAsync("Message stocké avec succès");
                        MessageBox.Show(this, "Message stocké avec succès", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        item_nombre = lst_messages.Items.Count;
                        // écriture de lignes de texte dans le fichier à travers le flux :
                        for (int i = 0; i < item_nombre; i++)
                        {
                            fluxWrite.WriteLine(lst_messages.Items[i]);
                        }
                            
                        fluxWrite.Close();
                    } // fermeture et désallocation de l'objet fluxWrite
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec d'enregistrement" + ex.ToString());
            }

        }

        private void Enregistrer_sms_non_transmis(object sender, EventArgs e)
        {
            int item_nombre;// pour determiner les elements contenus dans ma listbox
            try
            {
                string nom_du_fichier, adress_fichier;
                adress_fichier = @"c:\ChatsUp\SMS\Messages Non Transmis\";
                nom_du_fichier = adress_fichier + "Messages.lml";

                if (!Directory.Exists(Path.GetDirectoryName(adress_fichier)))
                    Directory.CreateDirectory(Path.GetDirectoryName(adress_fichier));
                
                    using (StreamWriter fluxWrite = new StreamWriter(nom_du_fichier))
                    {
                        parole.SpeakAsync("Message stocké avec succès");
                        MessageBox.Show(this, "Message stocké avec succès", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        item_nombre = lst_messages.Items.Count;
                        // écriture de lignes de texte dans le fichier à travers le flux :
                        for (int i = 0; i < item_nombre; i++)
                            fluxWrite.WriteLine(lst_messages.Items[i]);
                    } // fermeture et désallocation de l'objet fluxWrite
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec d'enregistrement" + ex.ToString());
            }

        }

        private void Enregistrer_brouillon(object sender, EventArgs e)
        {
            int item_nombre;// pour determiner les elements contenus dans ma listbox
            try
            {
                string nom_du_fichier, adress_fichier;
                adress_fichier = @"C:\ChatsUp\SMS\Brouillons\";
                nom_du_fichier = adress_fichier + "Messages.lml";

                if (!Directory.Exists(Path.GetDirectoryName(adress_fichier)))
                    Directory.CreateDirectory(Path.GetDirectoryName(adress_fichier));

                
                    using (StreamWriter fluxWrite = new StreamWriter(nom_du_fichier))
                    {
                        item_nombre = lst_messages.Items.Count;
                        // écriture de lignes de texte dans le fichier à travers le flux :
                        for (int i = 0; i < item_nombre; i++)
                        {
                            fluxWrite.WriteLine(lst_messages.Items[i]);
                            parole.SpeakAsync("Message stocké avec succès");
                            MessageBox.Show(this, "Message stocké avec succès", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } // fermeture et désallocation de l'objet fluxWrite
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec d'enregistrement" + ex.ToString());
            }

        }
        private void btn_ecrire_Click(object sender, EventArgs e)
        {
            lst_messages.Items.Add("");
            lst_messages.Items.Add("");
            lst_messages.Items.Add(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            lst_messages.Items.Add("Moi :" + " " + txt_envoi.Text);
            try
            {
                text_a_envoyer = txt_nom_local.Text + ":" + txt_envoi.Text;
                ASCIIEncoding lensEncoding = new ASCIIEncoding();
                byte[] envoi_sms = new byte[1500];
                envoi_sms = lensEncoding.GetBytes(text_a_envoyer);
                sock.Send(envoi_sms);
                txt_envoi.Text = "";
                btn_etat.BackColor = Color.Green;
                MessageBox.Show("Message envoyé", "Envoi reussi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, false);

                notification.Icon = SystemIcons.Information;
                notification.BalloonTipText = "Message envoyé avec succès!";
                notification.BalloonTipTitle = "ChatsUp LensX";
                notification.ShowBalloonTip(7000);
                //Enregistrement sms
                Enregistrer_sms_Transmis(sender, e);

            }
            catch (Exception ex)
            {
                button1_Click(sender, e);

                notification.Icon = SystemIcons.Error;
                notification.BalloonTipText = "Echec d'envoi du message!";
                notification.BalloonTipTitle = "ChatsUp LensX";
                notification.ShowBalloonTip(7000);

                MessageBox.Show("Envoi du SMS échoué!!!", "Echec d'envoi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString(), "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_etat.BackColor = Color.Red;
                Enregistrer_sms_non_transmis(sender, e);
            }
        }

        private void pnl_principal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                move_adress = Control.MousePosition;
                move_adress.X -= (x);
                move_adress.Y -= (y);
                this.Location = move_adress;
            }
        }

        private void pnl_principal_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void pnl_mes_parametres_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                move_adress = Control.MousePosition;
                move_adress.X -= (x);
                move_adress.Y -= (y);
                this.Location = move_adress;
            }
        }

        private void pnl_mes_parametres_MouseMove(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void pnl_photo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                move_adress = Control.MousePosition;
                move_adress.X -= (x);
                move_adress.Y -= (y);
                this.Location = move_adress;
            }
        }

        private void pnl_photo_MouseMove(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void pnl_param_corrsp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                move_adress = Control.MousePosition;
                move_adress.X -= (x);
                move_adress.Y -= (y);
                this.Location = move_adress;
            }
        }

        private void pnl_param_corrsp_MouseMove(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void pnl_control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                move_adress = Control.MousePosition;
                move_adress.X -= (x);
                move_adress.Y -= (y);
                this.Location = move_adress;
            }
        }

        private void pnl_control_MouseMove(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                move_adress = Control.MousePosition;
                move_adress.X -= (x);
                move_adress.Y -= (y);
                this.Location = move_adress;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void txt_nom_local_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nom_local.BackColor = Color.Black;
        }

        private void txt_mon_ip_MouseClick(object sender, MouseEventArgs e)
        {
            txt_mon_ip.BackColor = Color.Black;
        }

        private void txt_port_local_MouseClick(object sender, MouseEventArgs e)
        {
            txt_port_local.BackColor = Color.Black;
        }

        private void txt_nom_partenaire_MouseClick(object sender, MouseEventArgs e)
        {
            txt_nom_partenaire.BackColor = Color.Black;
        }

        private void txt_ip_partenaire_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ip_partenaire.BackColor = Color.Black;
        }

        private void txt_port_partenaire_MouseClick(object sender, MouseEventArgs e)
        {
            txt_port_partenaire.BackColor = Color.Black;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_confirm confirm = new frm_confirm();
            confirm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ecranDeSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_connect_Click(sender, e);
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void reduireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_cacher_Click(sender, e);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_confirm a = new frm_confirm();
            a.Show();
        }

        private void effacerLigne1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lst_messages.Items.RemoveAt(0);
        }

        private void effacerDerniereLigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n;
            n = lst_messages.Items.Count;
            lst_messages.Items.RemoveAt(n - 1);
        }

        private void viderLecranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lst_messages.Items.Clear();
        }

        private void effacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_effacer_Click(sender, e);
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enregistrer_sms_Transmis(sender, e);
        }

        private void enregistrerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Enregistrer_sms_non_transmis(sender, e);
        }

        private void enregistrerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Enregistrer_brouillon(sender, e);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ffichier = new OpenFileDialog();
            ffichier.Title = "Consulter SMS Transmis";
            ffichier.Filter = "Fichier(*.lml)|*.lml";
            ffichier.InitialDirectory = @"c:\ChatsUp\SMS\Messages Transmis";
            ffichier.ShowDialog();
            if(ffichier.FileName.Length==0)
            {
                MessageBox.Show(this,"Vous devez selectionner un enregistrement","Selection",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                nom_du_fichier = ffichier.FileName;
            }
        }

        private void consulterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ffichier = new OpenFileDialog();
            ffichier.Title = "Consulter SMS Non Transmis";
            ffichier.Filter = "Fichier(*.lml)|*.lml";
            ffichier.InitialDirectory = @"c:\ChatsUp\SMS\Messages Non Transmis";
            ffichier.ShowDialog();
            if (ffichier.FileName.Length == 0)
            {
                MessageBox.Show(this, "Vous devez selectionner un enregistrement", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                nom_du_fichier = ffichier.FileName;
            }
        }

        private void consulterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ffichier = new OpenFileDialog();
            ffichier.Title = "Consulter Brouillons";
            ffichier.Filter = "Fichier(*.lml)|*.lml";
            ffichier.InitialDirectory = @"c:\ChatsUp\SMS\Brouillons";
            ffichier.ShowDialog();
            if (ffichier.FileName.Length == 0)
            {
                MessageBox.Show(this, "Vous devez selectionner un enregistrement", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                nom_du_fichier = ffichier.FileName;
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about_box frm = new frm_about_box();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sock.Disconnect(true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txt_envoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals(Keys.Enter))
            {
                btn_ecrire_Click(sender, e);
            }
           
        }

        private void txt_envoi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(Keys.Enter))
            {
                btn_ecrire_Click(sender, e);
            }
        }

    }
}
