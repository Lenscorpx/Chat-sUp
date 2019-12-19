namespace ChatsUp
{
    partial class frm_nous_ecrire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nous_ecrire));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_go = new System.Windows.Forms.Button();
            this.rtxtbox = new System.Windows.Forms.RichTextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usermail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sujet_mail = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = global::ChatsUp.Properties.Resources.signature;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_usermail);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_sujet_mail);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_pwd);
            this.panel3.Controls.Add(this.btn_annuler);
            this.panel3.Controls.Add(this.rtxtbox);
            this.panel3.Controls.Add(this.btn_go);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(13, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 501);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 524);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright @ LensCorp Enterprises Corporation, 2015";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "LensCorp Mailing";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // btn_go
            // 
            this.btn_go.BackColor = System.Drawing.Color.Transparent;
            this.btn_go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_go.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.Location = new System.Drawing.Point(129, 450);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(67, 35);
            this.btn_go.TabIndex = 12;
            this.btn_go.Text = "Go!";
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // rtxtbox
            // 
            this.rtxtbox.BackColor = System.Drawing.Color.Black;
            this.rtxtbox.ForeColor = System.Drawing.Color.White;
            this.rtxtbox.Location = new System.Drawing.Point(38, 250);
            this.rtxtbox.Name = "rtxtbox";
            this.rtxtbox.Size = new System.Drawing.Size(371, 189);
            this.rtxtbox.TabIndex = 13;
            this.rtxtbox.Text = "Ecrivez votre texte ici";
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.Transparent;
            this.btn_annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_annuler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(253, 450);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(62, 35);
            this.btn_annuler.TabIndex = 16;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mot de Passe";
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.Black;
            this.txt_pwd.ForeColor = System.Drawing.Color.White;
            this.txt_pwd.Location = new System.Drawing.Point(113, 140);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(227, 23);
            this.txt_pwd.TabIndex = 17;
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adresse mail";
            // 
            // txt_usermail
            // 
            this.txt_usermail.BackColor = System.Drawing.Color.Black;
            this.txt_usermail.ForeColor = System.Drawing.Color.White;
            this.txt_usermail.Location = new System.Drawing.Point(38, 92);
            this.txt_usermail.Name = "txt_usermail";
            this.txt_usermail.Size = new System.Drawing.Size(371, 23);
            this.txt_usermail.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sujet du message";
            // 
            // txt_sujet_mail
            // 
            this.txt_sujet_mail.BackColor = System.Drawing.Color.Black;
            this.txt_sujet_mail.ForeColor = System.Drawing.Color.White;
            this.txt_sujet_mail.Location = new System.Drawing.Point(38, 188);
            this.txt_sujet_mail.Name = "txt_sujet_mail";
            this.txt_sujet_mail.Size = new System.Drawing.Size(371, 23);
            this.txt_sujet_mail.TabIndex = 19;
            // 
            // frm_nous_ecrire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(480, 525);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_nous_ecrire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_nous_ecrire";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usermail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_sujet_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.RichTextBox rtxtbox;
        private System.Windows.Forms.Button btn_go;
    }
}