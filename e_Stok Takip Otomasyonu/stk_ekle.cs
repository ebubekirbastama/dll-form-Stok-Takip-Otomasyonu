using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace e_Stok_Takip_Otomasyonu
{
    public partial class stk_ekle : MetroForm
    {
        public stk_ekle()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            bgl.sp6("sp_stk_save", txt_brkd.Text, txt_stk_adi.Text, txt_stk_cinsi.Text, txt_stk_adedi.Text, txt_stk_fiyati.Text, txt_krtk_stk.Text, "@stk_brkd", "@stk_adi", "@stk_cinsi", "@stk_adedi", "@stk_fyt", "@stk_kritik_stok", "Ekle","Yazilim Eğitim Stok takip otomasyonu");
        }
    }
}
