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
    public partial class FaturaKes : MetroFramework.Forms.MetroForm
    {
        public static Dictionary<String, String> idVeMiktarlar=new Dictionary<string, string>();
        public static Boolean yeniMusteriVar = false;
        Double genelToplam=0;
        Double toplam = 0;
        Double iskonto = 0;
        Double vergiTutari = 0;
        String sorgu = "";
        Baglanti baglanti = new Baglanti();
        Boolean satirDegistir = false;
        public FaturaKes()
        {
            InitializeComponent();
        }

        private void FaturaKes_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            basla();
        }

        public void basla()
        {
            foreach(String id in idVeMiktarlar.Keys)
            {
                sorgu = "call market.fatura_icin_urun_getir('"+id+"');";
                baglanti.Basla(sorgu);
                if (baglanti.reader.Read())
                {
                    Double toplamFiyat = (Convert.ToDouble(baglanti.reader[2].ToString()) * Convert.ToDouble(idVeMiktarlar[id])) + ((Convert.ToDouble(baglanti.reader[2].ToString()) * Convert.ToDouble(idVeMiktarlar[id])) * Convert.ToDouble(baglanti.reader[3].ToString()) / 100);
                    vergiTutari = vergiTutari + ((Convert.ToDouble(baglanti.reader[2].ToString()) * Convert.ToDouble(idVeMiktarlar[id])) * Convert.ToDouble(baglanti.reader[3].ToString()) / 100);
                    genelToplam = genelToplam + toplamFiyat;
                    
                    metroGrid1.Rows.Add(id,baglanti.reader[0].ToString(), baglanti.reader[1].ToString(),
                        idVeMiktarlar[id],baglanti.reader[2].ToString(), baglanti.reader[3].ToString(), (Convert.ToDouble(baglanti.reader[2].ToString()) * Convert.ToDouble(idVeMiktarlar[id])).ToString());
                }
                baglanti.Bitir();
            }
            musterileriGetir();
            toplam =(genelToplam - vergiTutari);
            metroLabel9.Text = toplam.ToString("0.##")+" TL";
            metroLabel10.Text = iskonto.ToString("0.##") + " TL";
            metroLabel11.Text = vergiTutari.ToString("0.##") + " TL";
            metroLabel12.Text = genelToplam.ToString("0.##") + " TL";
            //son fatura numarasi getirip 
        }

        public void mesaj(string aciklama, string baslik)
        {
            MetroFramework.MetroMessageBox.Show(this, aciklama, baslik);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.add2_480px;
            pictureBox2.Refresh();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.add_480px;
            pictureBox2.Refresh();
        }

        public void musterileriGetir()
        {
            String sql = "call market.musteri_unvanlarini_getir();";
            metroComboBox1.Items.Clear();
            baglanti.Basla(sql);
            while (baglanti.reader.Read())
            {
                metroComboBox1.Items.Add(baglanti.reader[0].ToString());
            }
            baglanti.Bitir();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yeniMusteriVar)
            {
                yeniMusteriVar = false;
                musterileriGetir();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MusteriEkle me = new MusteriEkle();
            me.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroGrid1.Rows.Add("0", "İSKONTO", "ADET", "1", "", "0", "");
        }

        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (satirDegistir)
            {
                Double birim_fiyat = Convert.ToDouble(metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString());
                Double miktar = Convert.ToDouble(metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString());
                Double toplam = birim_fiyat * miktar;
                metroGrid1.Rows[e.RowIndex].Cells[6].Value = toplam.ToString();
                toplamYenile();
            }
        }

        public void toplamYenile()
        {
            Double araToplam = 0;
            Double vergi = 0;
            Double iskonto = 0;
            Double gToplam = 0;
            foreach(DataGridViewRow satir in metroGrid1.Rows)
            {
                if (satir.Cells[1].Value.ToString() != "İSKONTO")
                {
                    araToplam = araToplam + (Convert.ToDouble(satir.Cells[3].Value.ToString()) * Convert.ToDouble(satir.Cells[4].Value.ToString()));
                    vergi = vergi + ((Convert.ToDouble(satir.Cells[3].Value.ToString()) * Convert.ToDouble(satir.Cells[4].Value.ToString())) * Convert.ToDouble(satir.Cells[5].Value.ToString()) / 100);

                }
                else
                {
                    iskonto = iskonto + Convert.ToDouble(satir.Cells[4].Value.ToString());
                }
            }
            gToplam = (araToplam + vergi) - iskonto;
            metroLabel9.Text = araToplam.ToString("0.##") + " TL";
            metroLabel10.Text = iskonto.ToString("0.##") + "TL";
            metroLabel11.Text = vergi.ToString("0.##") + " TL";
            metroLabel12.Text = gToplam.ToString("0.##") + " TL";
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satirDegistir = true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //fatura_ekle
            //satis_ekle
            //satis_kalemleri_ekle

        }
    }
}
