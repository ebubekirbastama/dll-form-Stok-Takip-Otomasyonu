using e_Stok_Takip_Otomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace Stok_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            this.a1();
        }
        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            this.a5();
        }
        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            this.a9(); 
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.a1();
        }
        private void müşteriGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a5();
        }
        private void kullanıcıGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a9();
        }
        private void stokGrişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a2();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.a3();
        }

        private void stokRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a4();
        }

        private void müşteriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a6();
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a7();
        }

        private void müşteriRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a8();
        }

        private void kullanıcıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a10();
        }

        private void kullanıcıTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a11();
        }

        private void kullanıcıRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.a12();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
    }

}
