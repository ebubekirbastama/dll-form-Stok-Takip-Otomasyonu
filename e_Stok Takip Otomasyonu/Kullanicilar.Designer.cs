namespace e_Stok_Takip_Otomasyonu
{
    partial class Kullanicilar
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
            this.txt_k_sfr = new MetroFramework.Controls.MetroTextBox();
            this.txt_k_adi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btn_kydt = new MetroFramework.Controls.MetroButton();
            this.cmd_ytk = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // txt_k_sfr
            // 
            this.txt_k_sfr.Lines = new string[0];
            this.txt_k_sfr.Location = new System.Drawing.Point(136, 122);
            this.txt_k_sfr.MaxLength = 32767;
            this.txt_k_sfr.Name = "txt_k_sfr";
            this.txt_k_sfr.PasswordChar = '\0';
            this.txt_k_sfr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_k_sfr.SelectedText = "";
            this.txt_k_sfr.Size = new System.Drawing.Size(119, 23);
            this.txt_k_sfr.TabIndex = 31;
            this.txt_k_sfr.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.txt_k_sfr, "Kullanıcı Şifresi");
            this.txt_k_sfr.UseSelectable = true;
            // 
            // txt_k_adi
            // 
            this.txt_k_adi.Lines = new string[0];
            this.txt_k_adi.Location = new System.Drawing.Point(136, 87);
            this.txt_k_adi.MaxLength = 32767;
            this.txt_k_adi.Name = "txt_k_adi";
            this.txt_k_adi.PasswordChar = '\0';
            this.txt_k_adi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_k_adi.SelectedText = "";
            this.txt_k_adi.Size = new System.Drawing.Size(119, 23);
            this.txt_k_adi.TabIndex = 30;
            this.txt_k_adi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.txt_k_adi, "Kullanıcı Adı");
            this.txt_k_adi.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Kullanıcı Yetkisi:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Kullanıcı Şifresi:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Kullanıcı Adı:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btn_kydt
            // 
            this.btn_kydt.Location = new System.Drawing.Point(178, 209);
            this.btn_kydt.Name = "btn_kydt";
            this.btn_kydt.Size = new System.Drawing.Size(76, 27);
            this.btn_kydt.TabIndex = 33;
            this.btn_kydt.Text = "Kaydet";
            this.btn_kydt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btn_kydt, "Kayıt işlemini tamamla");
            this.btn_kydt.UseSelectable = true;
            // 
            // cmd_ytk
            // 
            this.cmd_ytk.FormattingEnabled = true;
            this.cmd_ytk.ItemHeight = 23;
            this.cmd_ytk.Location = new System.Drawing.Point(136, 155);
            this.cmd_ytk.Name = "cmd_ytk";
            this.cmd_ytk.Size = new System.Drawing.Size(118, 29);
            this.cmd_ytk.TabIndex = 34;
            this.cmd_ytk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.cmd_ytk, "Kullanıcı Yetkisi");
            this.cmd_ytk.UseSelectable = true;
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 270);
            this.Controls.Add(this.cmd_ytk);
            this.Controls.Add(this.btn_kydt);
            this.Controls.Add(this.txt_k_sfr);
            this.Controls.Add(this.txt_k_adi);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Kullanicilar";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Kullanıcı Kayıt";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_k_sfr;
        private MetroFramework.Controls.MetroTextBox txt_k_adi;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroButton btn_kydt;
        private MetroFramework.Controls.MetroComboBox cmd_ytk;
    }
}