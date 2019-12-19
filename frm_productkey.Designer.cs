namespace ChatsUp
{
    partial class frm_productkey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_productkey));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_product_key = new System.Windows.Forms.TextBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_autre = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::ChatsUp.Properties.Resources.fd;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_fermer);
            this.panel1.Controls.Add(this.btn_autre);
            this.panel1.Controls.Add(this.btn_enregistrer);
            this.panel1.Controls.Add(this.txt_product_key);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 532);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "LensCorp Enterprise";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lors de votre  première utilisation\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenue dans ChatsUp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 90);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_product_key
            // 
            this.txt_product_key.BackColor = System.Drawing.Color.Black;
            this.txt_product_key.ForeColor = System.Drawing.Color.White;
            this.txt_product_key.Location = new System.Drawing.Point(20, 386);
            this.txt_product_key.Name = "txt_product_key";
            this.txt_product_key.Size = new System.Drawing.Size(301, 23);
            this.txt_product_key.TabIndex = 20;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btn_enregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer.Location = new System.Drawing.Point(63, 425);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(92, 35);
            this.btn_enregistrer.TabIndex = 21;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_autre
            // 
            this.btn_autre.BackColor = System.Drawing.Color.Transparent;
            this.btn_autre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_autre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_autre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autre.Location = new System.Drawing.Point(180, 425);
            this.btn_autre.Name = "btn_autre";
            this.btn_autre.Size = new System.Drawing.Size(92, 35);
            this.btn_autre.TabIndex = 22;
            this.btn_autre.Text = "Autre";
            this.btn_autre.UseVisualStyleBackColor = false;
            this.btn_autre.Click += new System.EventHandler(this.btn_autre_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.Transparent;
            this.btn_fermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fermer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fermer.Location = new System.Drawing.Point(286, 3);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(44, 31);
            this.btn_fermer.TabIndex = 23;
            this.btn_fermer.Text = "x";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // frm_productkey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(356, 554);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_productkey";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_productkey";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.frm_productkey_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_product_key;
        private System.Windows.Forms.Button btn_autre;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_fermer;

    }
}