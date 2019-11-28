using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class MusteriEkle : MetroFramework.Forms.MetroForm
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text.Length>0 && metroTextBox2.Text.Length > 0 && metroTextBox3.Text.Length > 0 &&
                metroTextBox4.Text.Length > 0 && metroTextBox5.Text.Length > 0 && metroTextBox6.Text.Length > 0)
            {
                bool yeniEkle = false;
                Baglanti baglanti = new Baglanti();
                String sorgu = "call market.musteri_ekle('"+metroTextBox1.Text+ "','" + metroTextBox2.Text + "','" + metroTextBox3.Text +
                    "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroTextBox7.Text +
                    "','" + metroTextBox8.Text + "','" + metroTextBox9.Text + "','" + metroTextBox10.Text + "');";
                baglanti.Basla(sorgu);
                if (baglanti.reader.RecordsAffected > 0)
                {
                    DialogResult dr= MetroFramework.MetroMessageBox.Show(this, "Başka bir müşteri eklemek istermisiniz?", "Müşteri Başarıyla Eklendi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        yeniEkle = true;
                        metroTextBox1.Text = "";
                        metroTextBox2.Text = "";
                        metroTextBox3.Text = "";
                        metroTextBox4.Text = "";
                        metroTextBox5.Text = "";
                        metroTextBox6.Text = "";
                        metroTextBox7.Text = "";
                        metroTextBox8.Text = "";
                        metroTextBox9.Text = "";
                        metroTextBox10.Text = "";
                        FaturaKes.yeniMusteriVar = true;
                    }
                    else
                    {
                        yeniEkle = false;
                    }
                }                
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Müşteri Eklenemedi", "Bağlantı Hatası");
                }
                baglanti.Bitir();
                if (!yeniEkle)
                {
                    if (EkranAktiflestir.Acikmi("FaturaKes"))
                    {
                        FaturaKes.yeniMusteriVar = true;
                        EkranAktiflestir.Aktiflestir("FaturaKes");
                    }
                    this.Close();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Lütfen zorunlu alanların tamamını doldurunuz", "Eksik Alan Var");
            }
            
        }
    }
}
