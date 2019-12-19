namespace ChatsUp
{
    partial class frm_confirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_confirm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_oui = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_non = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_oui);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 78);
            this.panel1.TabIndex = 0;
            // 
            // btn_oui
            // 
            this.btn_oui.BackColor = System.Drawing.Color.Transparent;
            this.btn_oui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_oui.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_oui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oui.Location = new System.Drawing.Point(14, 10);
            this.btn_oui.Name = "btn_oui";
            this.btn_oui.Size = new System.Drawing.Size(67, 52);
            this.btn_oui.TabIndex = 4;
            this.btn_oui.Text = "Oui";
            this.btn_oui.UseVisualStyleBackColor = false;
            this.btn_oui.Click += new System.EventHandler(this.btn_oui_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_non);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(158, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 78);
            this.panel3.TabIndex = 1;
            // 
            // btn_non
            // 
            this.btn_non.BackColor = System.Drawing.Color.Transparent;
            this.btn_non.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_non.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_non.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_non.Location = new System.Drawing.Point(16, 10);
            this.btn_non.Name = "btn_non";
            this.btn_non.Size = new System.Drawing.Size(64, 52);
            this.btn_non.TabIndex = 5;
            this.btn_non.Text = "Non";
            this.btn_non.UseVisualStyleBackColor = false;
            this.btn_non.Click += new System.EventHandler(this.btn_non_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(120, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 78);
            this.panel2.TabIndex = 2;
            // 
            // frm_confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(273, 100);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_confirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_confirm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.frm_confirm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_oui;
        private System.Windows.Forms.Button btn_non;
    }
}