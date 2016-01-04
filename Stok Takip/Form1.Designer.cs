using e_Stok_Takip_Otomasyonu;
namespace Stok_Takip
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.girişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stokGrişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stokRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenlemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silmelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTemizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senelikRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.White;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 27);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(775, 306);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 1;
            this.ribbonControl1.Text = "Kontrol Merkezi";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(54, 85);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(97, 44);
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "Stok Giriş";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(157, 85);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(103, 44);
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "Müşteri Giriş";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click_1);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(266, 84);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(105, 45);
            this.buttonX3.TabIndex = 4;
            this.buttonX3.Text = "Kullanıcı Giriş";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişlerToolStripMenuItem,
            this.düzenlemelerToolStripMenuItem,
            this.silmelerToolStripMenuItem,
            this.raporİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // girişlerToolStripMenuItem
            // 
            this.girişlerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.girişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.stokGrişToolStripMenuItem,
            this.toolStripMenuItem1,
            this.stokRaporToolStripMenuItem});
            this.girişlerToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.girişlerToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.girişlerToolStripMenuItem.Name = "girişlerToolStripMenuItem";
            this.girişlerToolStripMenuItem.Size = new System.Drawing.Size(127, 23);
            this.girişlerToolStripMenuItem.Text = "Stok İşlemleri";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 24);
            this.toolStripMenuItem2.Text = "Stok Griş";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // stokGrişToolStripMenuItem
            // 
            this.stokGrişToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stokGrişToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.stokGrişToolStripMenuItem.Name = "stokGrişToolStripMenuItem";
            this.stokGrişToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.stokGrişToolStripMenuItem.Text = "Stok Güncelle";
            this.stokGrişToolStripMenuItem.Click += new System.EventHandler(this.stokGrişToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.toolStripMenuItem1.Text = "Stok Temizle";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // stokRaporToolStripMenuItem
            // 
            this.stokRaporToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stokRaporToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.stokRaporToolStripMenuItem.Name = "stokRaporToolStripMenuItem";
            this.stokRaporToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.stokRaporToolStripMenuItem.Text = "Stok Rapor";
            this.stokRaporToolStripMenuItem.Click += new System.EventHandler(this.stokRaporToolStripMenuItem_Click);
            // 
            // düzenlemelerToolStripMenuItem
            // 
            this.düzenlemelerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.düzenlemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriGirişToolStripMenuItem,
            this.müşteriGüncelleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem,
            this.müşteriRaporToolStripMenuItem});
            this.düzenlemelerToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.düzenlemelerToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.düzenlemelerToolStripMenuItem.Name = "düzenlemelerToolStripMenuItem";
            this.düzenlemelerToolStripMenuItem.Size = new System.Drawing.Size(150, 23);
            this.düzenlemelerToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // müşteriGirişToolStripMenuItem
            // 
            this.müşteriGirişToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.müşteriGirişToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.müşteriGirişToolStripMenuItem.Name = "müşteriGirişToolStripMenuItem";
            this.müşteriGirişToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.müşteriGirişToolStripMenuItem.Text = "Müşteri Giriş";
            this.müşteriGirişToolStripMenuItem.Click += new System.EventHandler(this.müşteriGirişToolStripMenuItem_Click);
            // 
            // müşteriGüncelleToolStripMenuItem
            // 
            this.müşteriGüncelleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.müşteriGüncelleToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.müşteriGüncelleToolStripMenuItem.Name = "müşteriGüncelleToolStripMenuItem";
            this.müşteriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.müşteriGüncelleToolStripMenuItem.Text = "Müşteri Güncelle";
            this.müşteriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.müşteriGüncelleToolStripMenuItem_Click);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.müşteriSilToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Temizle";
            this.müşteriSilToolStripMenuItem.Click += new System.EventHandler(this.müşteriSilToolStripMenuItem_Click);
            // 
            // müşteriRaporToolStripMenuItem
            // 
            this.müşteriRaporToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.müşteriRaporToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.müşteriRaporToolStripMenuItem.Name = "müşteriRaporToolStripMenuItem";
            this.müşteriRaporToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.müşteriRaporToolStripMenuItem.Text = "Müşteri Rapor";
            this.müşteriRaporToolStripMenuItem.Click += new System.EventHandler(this.müşteriRaporToolStripMenuItem_Click);
            // 
            // silmelerToolStripMenuItem
            // 
            this.silmelerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.silmelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıGirişToolStripMenuItem,
            this.kullanıcıGüncelleToolStripMenuItem,
            this.kullanıcıTemizleToolStripMenuItem,
            this.kullanıcıRaporToolStripMenuItem});
            this.silmelerToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.silmelerToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.silmelerToolStripMenuItem.Name = "silmelerToolStripMenuItem";
            this.silmelerToolStripMenuItem.Size = new System.Drawing.Size(161, 23);
            this.silmelerToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullanıcıGirişToolStripMenuItem
            // 
            this.kullanıcıGirişToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kullanıcıGirişToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.kullanıcıGirişToolStripMenuItem.Name = "kullanıcıGirişToolStripMenuItem";
            this.kullanıcıGirişToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.kullanıcıGirişToolStripMenuItem.Text = "Kullanıcı Giriş";
            this.kullanıcıGirişToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıGirişToolStripMenuItem_Click);
            // 
            // kullanıcıGüncelleToolStripMenuItem
            // 
            this.kullanıcıGüncelleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kullanıcıGüncelleToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.kullanıcıGüncelleToolStripMenuItem.Name = "kullanıcıGüncelleToolStripMenuItem";
            this.kullanıcıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.kullanıcıGüncelleToolStripMenuItem.Text = "Kullanıcı Güncelle";
            this.kullanıcıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıGüncelleToolStripMenuItem_Click);
            // 
            // kullanıcıTemizleToolStripMenuItem
            // 
            this.kullanıcıTemizleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kullanıcıTemizleToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.kullanıcıTemizleToolStripMenuItem.Name = "kullanıcıTemizleToolStripMenuItem";
            this.kullanıcıTemizleToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.kullanıcıTemizleToolStripMenuItem.Text = "Kullanıcı Temizle";
            this.kullanıcıTemizleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTemizleToolStripMenuItem_Click);
            // 
            // kullanıcıRaporToolStripMenuItem
            // 
            this.kullanıcıRaporToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kullanıcıRaporToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.kullanıcıRaporToolStripMenuItem.Name = "kullanıcıRaporToolStripMenuItem";
            this.kullanıcıRaporToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.kullanıcıRaporToolStripMenuItem.Text = "Kullanıcı Rapor";
            this.kullanıcıRaporToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıRaporToolStripMenuItem_Click);
            // 
            // raporİşlemleriToolStripMenuItem
            // 
            this.raporİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükRaporToolStripMenuItem,
            this.aylıkRaporToolStripMenuItem,
            this.senelikRaporToolStripMenuItem});
            this.raporİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.raporİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.raporİşlemleriToolStripMenuItem.Name = "raporİşlemleriToolStripMenuItem";
            this.raporİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(137, 23);
            this.raporİşlemleriToolStripMenuItem.Text = "Rapor İşlemleri";
            // 
            // günlükRaporToolStripMenuItem
            // 
            this.günlükRaporToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.günlükRaporToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.günlükRaporToolStripMenuItem.Name = "günlükRaporToolStripMenuItem";
            this.günlükRaporToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.günlükRaporToolStripMenuItem.Text = "Günlük Rapor";
            // 
            // aylıkRaporToolStripMenuItem
            // 
            this.aylıkRaporToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aylıkRaporToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.aylıkRaporToolStripMenuItem.Name = "aylıkRaporToolStripMenuItem";
            this.aylıkRaporToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.aylıkRaporToolStripMenuItem.Text = "Aylık Rapor";
            // 
            // senelikRaporToolStripMenuItem
            // 
            this.senelikRaporToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.senelikRaporToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.senelikRaporToolStripMenuItem.Name = "senelikRaporToolStripMenuItem";
            this.senelikRaporToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.senelikRaporToolStripMenuItem.Text = "Senelik Rapor";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 333);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Kontrol Merkezi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void a1()
        {
            bgl.ynldrm("stk_grs"); 
        }
        public void a2()
        { bgl.ynldrm("stk_gncl"); }
        public void a3()
        { bgl.ynldrm("stk_tmzl"); }
        public void a4()
        { bgl.ynldrm("stk_rpr"); }
        public void a5()
        { bgl.ynldrm("mstr_grs"); }
        public void a6()
        { bgl.ynldrm("mstr_gncl"); }
        public void a7()
        { bgl.ynldrm("mstr_tmzl"); }
        public void a8()
        { bgl.ynldrm("mstr_rpr"); }
        public void a9()
        { bgl.ynldrm("klncr_grs"); }
        public void a10()
        { bgl.ynldrm("klncr_gncl"); }
        public void a11()
        { bgl.ynldrm("klncr_tmzl"); }
        public void a12()
        { bgl.ynldrm("klncr_rpr"); }
        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenlemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silmelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGrişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stokRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTemizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senelikRaporToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

