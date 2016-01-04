//Bu Yapı By Ebubekir Bastama tarından dizayn edilmiş'dir.
//Soru ve görüşleriniz için online 05554128854
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Stok_Takip_Otomasyonu
{//desing by Ebubekir bastama(c.)
    public class baglanti
    {
        private string server_name;
        StreamReader sr;
        private string ms_box;
        private string s;
        public void ayr()
        {
            sr = File.OpenText(@"C:\ayar.txt");
            si = sr.ReadLine();
            svr = si;
            sr.Close();
        }
        public string svr
        {
            get
            {

                return server_name;
            }
            set
            {
                server_name = value;
            }
        }
        public string si
        {
            get
            {

                return s;
            }
            set
            {
                s = value;
            }
        }
        public string msg
        {
            get
            {
                return ms_box;
            }
            set
            {
                ms_box = value;
            }

        }
        public SqlConnection baglantim()
        {
            //ebubekirbastama
            SqlConnection con = new SqlConnection(@"Server=" + svr + "; Integrated Security=true; Database=e_stok");//Bağlantı cümlemiz

            if (con.State == ConnectionState.Closed) // System.Data.SqlClient.ConnectionState using System.Data; kütüphanesinden gelir
            {
                con.Open();//Bağlantıyı Aç
            }
            return con;//con döndür
        }
        public DataTable tablo(string sqlCumlem, MetroGrid veridatagrid)
        {
            SqlConnection con = baglantim();
            SqlDataAdapter adap = new SqlDataAdapter(sqlCumlem, baglantim());
            DataTable dt = new DataTable();
            try
            {
                baglantim();
                adap.Fill(dt);
                veridatagrid.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ebubekir Otomasyon");
            }
            adap.Dispose();
            con.Close();
            return dt;
        }
        public void mesajlar(string mesaj, string smg_baslik)
        {
            MessageBox.Show(mesaj, smg_baslik);
        }
        public void mesajlar_p(string cml, string smg_baslik)
        {
            switch (cml)
            {
                case "Ekle":
                    MessageBox.Show("Ekleme İşlemi Başarılı", smg_baslik);
                    break;
                case "Sil":
                    MessageBox.Show("Silme İşlemi Başarılı", smg_baslik);
                    break;
                case "Güncelle":
                    MessageBox.Show("Güncelleme İşlemi Başarılı", smg_baslik);
                    break;
                default:
                    break;
                   

            }
        }
        public void ynldrm(string cml)
        {
            switch (cml)
            {
                case "stk_grs":
                    stk_ekle se = new stk_ekle();
                    se.ShowDialog();
                    break;
                case "stk_gncl":
                    stk_gncl sg = new stk_gncl();
                    sg.ShowDialog();
                    break;
                case "stk_tmzl":
                    stk_tmzl st = new stk_tmzl();
                    st.ShowDialog();
                    break;
                case "stk_rpr":
                    stk_rpr sr = new stk_rpr();
                    sr.ShowDialog();
                    break;
                case "mstr_grs":
                    mstr_ekle ms = new mstr_ekle();
                    ms.ShowDialog();
                    break;
                case "mstr_gncl":
                    mstr_gncl mg = new mstr_gncl();
                    mg.ShowDialog();
                    break;
                case "mstr_tmzl":
                    mstr_tmzl mt = new mstr_tmzl();
                    mt.ShowDialog();
                    break;
                case "mstr_rpr":
                    mstr_rpr mr = new mstr_rpr();
                    mr.ShowDialog();
                    break;
                case "klncr_grs":
                    Kullanicilar k = new Kullanicilar();
                    k.ShowDialog();
                    break;
                case "klncr_gncl":
                    klnc_gncl kg = new klnc_gncl();
                    kg.ShowDialog();
                    break;
                case "klncr_tmzl":
                    klnc_tmzl kt = new klnc_tmzl();
                    kt.ShowDialog();
                    break;
                case "klncr_rpr":
                    klnc_rpr kr = new klnc_rpr();
                    kr.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        public void sp1(string sp_name, string txt1, string param1, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }
        public void sp2(string sp_name, string txt1, string txt2, string param1, string param2, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz.
                kmt.Parameters.AddWithValue(param2, txt2.Trim());//Parametreleri giriyoruz.
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }
        public void sp3(string sp_name, string txt1, string txt2, string txt3, string param1, string param2, string param3, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param2, txt2.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param3, txt3.Trim());//Parametreleri giriyoruz
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.	
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }
        public void sp4(string sp_name, string txt1, string txt2, string txt3, string txt4, string param1, string param2, string param3, string param4, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param2, txt2.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param3, txt3.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param4, txt4.Trim());//Parametreleri giriyoruz
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }
        public void sp5(string sp_name, string txt1, string txt2, string txt3, string txt4, string txt5, string param1, string param2, string param3, string param4, string param5, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz.
                kmt.Parameters.AddWithValue(param2, txt2.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param3, txt3.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param4, txt4.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param5, txt5.Trim());//Parametreleri giriyoruz
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.	
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }
        public void sp6(string sp_name, string txt1, string txt2, string txt3, string txt4, string txt5, string txt6, string param1, string param2, string param3, string param4, string param5, string param6, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz.
                kmt.Parameters.AddWithValue(param2, txt2.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param3, txt3.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param4, txt4.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param5, txt5.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param6, txt6.Trim());//Parametreleri giriyoruz
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }
        public void sp7(string sp_name, string txt1, string txt2, string txt3, string txt4, string txt5, string txt6, string txt7, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param2, txt2.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param3, txt3.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param4, txt4.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param5, txt5.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param6, txt6.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param7, txt7.Trim());//Parametreleri giriyoruz
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }
        public void sp8(string sp_name, string txt1, string txt2, string txt3, string txt4, string txt5, string txt6, string txt7, string txt8, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param2, txt2.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param3, txt3.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param4, txt4.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param5, txt5.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param6, txt6.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param7, txt7.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param8, txt8.Trim());//Parametreleri giriyoruz
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.	
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }
        public void sp9(string sp_name, string txt1, string txt2, string txt3, string txt4, string txt5, string txt6, string txt7, string txt8, string txt9, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param2, txt2.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param3, txt3.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param4, txt4.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param5, txt5.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param6, txt6.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param7, txt7.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param8, txt8.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param9, txt9.Trim());//Parametreleri giriyoruz
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.	
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }
        public void sp10(string sp_name, string txt1, string txt2, string txt3, string txt4, string txt5, string txt6, string txt7, string txt8, string txt9, string txt10, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10, string cml, string smg_baslik)
        {
            try
            {
                SqlConnection con = baglantim();//Bağlantımızı açıyoruz
                SqlCommand kmt = new SqlCommand(sp_name, con);//Store procedurumuzun ismini yazıyoruz
                kmt.CommandType = CommandType.StoredProcedure;//Procedurumuzu tanıtıyoruz.
                kmt.Parameters.AddWithValue(param1, txt1.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param2, txt2.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param3, txt3.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param4, txt4.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param5, txt5.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param6, txt6.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param7, txt7.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param8, txt8.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param9, txt9.Trim());//Parametreleri giriyoruz
                kmt.Parameters.AddWithValue(param10, txt10.Trim());//Parametreleri giriyoruz
                kmt.ExecuteNonQuery();//Procedurumuzu çalıltırıyorum.
                con.Close();//Bağlantımzı kapatıyoruz.	
                mesajlar_p(cml, smg_baslik);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj başlığı");
            }

        }     
    }
}
