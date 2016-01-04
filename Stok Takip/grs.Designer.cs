namespace Stok_Takip
{
    partial class grs
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
            this.txt_k_adi = new MetroFramework.Controls.MetroTextBox();
            this.txt_sfr = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txt_k_adi
            // 
            this.txt_k_adi.Lines = new string[0];
            this.txt_k_adi.Location = new System.Drawing.Point(58, 99);
            this.txt_k_adi.MaxLength = 32767;
            this.txt_k_adi.Name = "txt_k_adi";
            this.txt_k_adi.PasswordChar = '\0';
            this.txt_k_adi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_k_adi.SelectedText = "";
            this.txt_k_adi.Size = new System.Drawing.Size(101, 23);
            this.txt_k_adi.TabIndex = 0;
            this.txt_k_adi.UseSelectable = true;
            // 
            // txt_sfr
            // 
            this.txt_sfr.Lines = new string[0];
            this.txt_sfr.Location = new System.Drawing.Point(183, 98);
            this.txt_sfr.MaxLength = 32767;
            this.txt_sfr.Name = "txt_sfr";
            this.txt_sfr.PasswordChar = '\0';
            this.txt_sfr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sfr.SelectedText = "";
            this.txt_sfr.Size = new System.Drawing.Size(101, 23);
            this.txt_sfr.TabIndex = 1;
            this.txt_sfr.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(115, 153);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 42);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Giriş";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(255, 213);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Çıkış";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(67, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Kullanıcı Adı";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(190, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Kullanıcı Şifresi";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // grs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 259);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txt_sfr);
            this.Controls.Add(this.txt_k_adi);
            this.Name = "grs";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Kullanıcı Girişi";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_k_adi;
        private MetroFramework.Controls.MetroTextBox txt_sfr;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;


    }
}