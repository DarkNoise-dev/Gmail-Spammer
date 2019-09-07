namespace Gmail_Spammer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtbx_angreifer_adresse = new System.Windows.Forms.TextBox();
            this.txtbx_angreifer_password = new System.Windows.Forms.TextBox();
            this.txtbx_opfer_adresse = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtbx_email_anzahl = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtbx_email_text = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtbx_email_betreff = new System.Windows.Forms.TextBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(172, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Angreifer Gmail Adresse";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(180, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Angreifer Gmail Passwort";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 177);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Opfer Email Adresse";
            // 
            // txtbx_angreifer_adresse
            // 
            this.txtbx_angreifer_adresse.Location = new System.Drawing.Point(270, 88);
            this.txtbx_angreifer_adresse.Multiline = true;
            this.txtbx_angreifer_adresse.Name = "txtbx_angreifer_adresse";
            this.txtbx_angreifer_adresse.Size = new System.Drawing.Size(195, 20);
            this.txtbx_angreifer_adresse.TabIndex = 3;
            this.txtbx_angreifer_adresse.TextChanged += new System.EventHandler(this.txtbx_angreifer_adresse_TextChanged);
            // 
            // txtbx_angreifer_password
            // 
            this.txtbx_angreifer_password.Location = new System.Drawing.Point(270, 133);
            this.txtbx_angreifer_password.Multiline = true;
            this.txtbx_angreifer_password.Name = "txtbx_angreifer_password";
            this.txtbx_angreifer_password.Size = new System.Drawing.Size(195, 20);
            this.txtbx_angreifer_password.TabIndex = 4;
            this.txtbx_angreifer_password.TextChanged += new System.EventHandler(this.txtbx_angreifer_password_TextChanged);
            // 
            // txtbx_opfer_adresse
            // 
            this.txtbx_opfer_adresse.Location = new System.Drawing.Point(270, 178);
            this.txtbx_opfer_adresse.Multiline = true;
            this.txtbx_opfer_adresse.Name = "txtbx_opfer_adresse";
            this.txtbx_opfer_adresse.Size = new System.Drawing.Size(195, 20);
            this.txtbx_opfer_adresse.TabIndex = 5;
            this.txtbx_opfer_adresse.TextChanged += new System.EventHandler(this.txtbx_opfer_adresse_TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 297);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(129, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Anzahl der Emails";
            // 
            // txtbx_email_anzahl
            // 
            this.txtbx_email_anzahl.Location = new System.Drawing.Point(270, 296);
            this.txtbx_email_anzahl.Multiline = true;
            this.txtbx_email_anzahl.Name = "txtbx_email_anzahl";
            this.txtbx_email_anzahl.Size = new System.Drawing.Size(195, 20);
            this.txtbx_email_anzahl.TabIndex = 7;
            this.txtbx_email_anzahl.TextChanged += new System.EventHandler(this.txtbx_email_anzahl_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 261);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(80, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Email Text";
            // 
            // txtbx_email_text
            // 
            this.txtbx_email_text.Location = new System.Drawing.Point(270, 260);
            this.txtbx_email_text.Multiline = true;
            this.txtbx_email_text.Name = "txtbx_email_text";
            this.txtbx_email_text.Size = new System.Drawing.Size(195, 20);
            this.txtbx_email_text.TabIndex = 10;
            this.txtbx_email_text.TextChanged += new System.EventHandler(this.txtbx_email_text_TextChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 221);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(96, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Email Betreff";
            // 
            // txtbx_email_betreff
            // 
            this.txtbx_email_betreff.Location = new System.Drawing.Point(270, 222);
            this.txtbx_email_betreff.Multiline = true;
            this.txtbx_email_betreff.Name = "txtbx_email_betreff";
            this.txtbx_email_betreff.Size = new System.Drawing.Size(195, 20);
            this.txtbx_email_betreff.TabIndex = 12;
            this.txtbx_email_betreff.TextChanged += new System.EventHandler(this.txtbx_email_betreff_TextChanged);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(233, 331);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(125, 59);
            this.materialRaisedButton2.TabIndex = 13;
            this.materialRaisedButton2.Text = "Emails Schicken";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(33, 349);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(125, 41);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "Info";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 402);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.txtbx_email_betreff);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtbx_email_text);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtbx_email_anzahl);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtbx_opfer_adresse);
            this.Controls.Add(this.txtbx_angreifer_password);
            this.Controls.Add(this.txtbx_angreifer_adresse);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Text = "Gmail Spammer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox txtbx_angreifer_adresse;
        private System.Windows.Forms.TextBox txtbx_angreifer_password;
        private System.Windows.Forms.TextBox txtbx_opfer_adresse;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txtbx_email_anzahl;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox txtbx_email_text;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox txtbx_email_betreff;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

