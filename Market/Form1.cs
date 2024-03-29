﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public bool satisAcik = false;
        public bool urunYonetimiAcik = false;
        public bool satinalmaAcik = false;
        public bool raporlarAcik = false;
        public bool barkodUretAcik = false;
        Baglanti baglanti = new Baglanti();

        public static string okunanBarkod = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //urunYonetimi1.Visible = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (satisAcik)
            {
                //timer1.Enabled = true;
                // Satış Ekranı Açık
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    barkodlaUrunGetir(okunanBarkod);
                    //timer1.Enabled = false;
                }
                if (true)
                {
                    okunanBarkod = okunanBarkod + e.KeyChar.ToString();
                }
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ekranBelirle("satisAcik");
        }

        public void ekranBelirle(string ekranIsmi)
        {
            if (ekranIsmi == "satisAcik")
            {
                urunYonetimiAcik = false;
                satinalmaAcik = false;
                raporlarAcik = false;
                barkodUretAcik = false;
                satisAcik = true;
                groupBox1.Visible = true;
            }
            else if (ekranIsmi == "satinalmaAcik")
            {
                urunYonetimiAcik = false;
                satisAcik = false;
                raporlarAcik = false;
                barkodUretAcik = false;
                satinalmaAcik = true;
            }
            else if(ekranIsmi== "raporlarAcik")
            {
                urunYonetimiAcik = false;
                satisAcik = false;
                satinalmaAcik = false;
                barkodUretAcik = false;
                raporlarAcik= true;
            }
            else if (ekranIsmi == "barkodUretAcik")
            {
                urunYonetimiAcik = false;
                satisAcik = false;
                satinalmaAcik = false;
                raporlarAcik = false;
                barkodUretAcik= true;
            }
            else if (ekranIsmi == "urunYonetimiAcik")
            {
                barkodUretAcik = false;
                satisAcik = false;
                satinalmaAcik = false;
                raporlarAcik = false;
                urunYonetimiAcik= true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            barkodlaUrunGetir(metroTextBox1.Text);
        }

        public void barkodlaUrunGetir(string barkod)
        {
            String sorgu = "call market.barkod_ile_urun_getir('" + barkod + "');";
            baglanti.Basla(sorgu);
            if (baglanti.reader.Read())
            {
                bool yenimi = true;
                foreach (DataGridViewRow satir in metroGrid1.Rows)
                {
                    if (satir.Cells[0].Value.ToString() == baglanti.reader[0].ToString())
                    {
                        yenimi = false;
                        Double miktar = Convert.ToDouble(satir.Cells[4].Value.ToString());
                        miktar++;
                        satir.Cells[4].Value = miktar.ToString();
                        Double vergiYuzdesi = Convert.ToDouble(satir.Cells[6].Value.ToString());
                        Double birimFiyat = Convert.ToDouble(satir.Cells[5].Value.ToString());
                        Double toplamTutar = (birimFiyat * miktar);
                        toplamTutar = toplamTutar + (toplamTutar * vergiYuzdesi / 100);

                        satir.Cells[7].Value = toplamTutar.ToString("0.##");
                        Double satisToplam = 0;
                        foreach (DataGridViewRow str in metroGrid1.Rows)
                        {
                            satisToplam = satisToplam + Convert.ToDouble(str.Cells[7].Value.ToString());
                        }
                        metroLabel2.Text = satisToplam.ToString("0.##") + " TL";
                    }

                }
                if (yenimi)
                {
                    Double toplamTutar = Convert.ToDouble(baglanti.reader[4].ToString()) + (Convert.ToDouble(baglanti.reader[4].ToString()) * Convert.ToDouble(baglanti.reader[5].ToString()) / 100);
                    metroGrid1.Rows.Add(baglanti.reader[0].ToString(), Base64ToImage(baglanti.reader[1].ToString()), baglanti.reader[2].ToString(),
                    baglanti.reader[3].ToString(), "1", baglanti.reader[4].ToString(), baglanti.reader[5].ToString(), toplamTutar.ToString("0.##"));
                    Double satisToplam = 0;
                    foreach (DataGridViewRow str in metroGrid1.Rows)
                    {
                        satisToplam = satisToplam + Convert.ToDouble(str.Cells[7].Value.ToString());
                    }
                    metroLabel2.Text = satisToplam.ToString("0.##") + " TL";
                }

            }
            baglanti.Bitir();
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {               
                try
                {
                    Image image = Image.FromStream(ms, true);
                    return (Image)ResizeImage(image, 50, 50);
                }
                catch
                {
                    return Properties.Resources.delete_sign_30px;
                }
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            try
            {
                metroGrid1.Rows.RemoveAt(metroGrid1.SelectedRows[0].Index);
                Double satisToplam = 0;
                foreach (DataGridViewRow str in metroGrid1.Rows)
                {
                    satisToplam = satisToplam + Convert.ToDouble(str.Cells[7].Value.ToString());
                }
                metroLabel2.Text = satisToplam.ToString("0.##") + " TL";
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (okunanBarkod.Length > 7)
            {
                okunanBarkod = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 700;
            timer1.Start();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            if (metroGrid1.RowCount > 0)
            {
                bool ilkKontrol = false;
                String sonSatisNumarasi="";
                Double vergiliToplam = 0;
                Double vergiTutari = 0;
                Double vergisizToplam = 0;
                foreach(DataGridViewRow satir in metroGrid1.Rows)
                {
                    vergiTutari = vergiTutari+(Convert.ToDouble(satir.Cells[5].Value.ToString())* Convert.ToDouble(satir.Cells[4].Value.ToString()) * Convert.ToDouble(satir.Cells[6].Value.ToString()) / 100);
                    vergiliToplam = vergiliToplam + Convert.ToDouble(satir.Cells[7].Value.ToString());
                }
                vergisizToplam = vergiliToplam - vergiTutari;
                //son satış numarası al
                String sorgu = "call market.son_satis_numarasi_ver();";
                baglanti.Basla(sorgu);
                if (baglanti.reader.Read())
                {
                    sonSatisNumarasi = baglanti.reader[0].ToString();
                }
                sonSatisNumarasi = (Convert.ToUInt32(sonSatisNumarasi) + 1).ToString();
                baglanti.Bitir();
                //satış ekle
                string trh = DateTime.Now.ToString("dd/MM/yyyy");
                string st = DateTime.Now.ToString("HH:mm");
                sorgu = "call market.satis_ekle('"+trh+"','"+st+"','"+vergiliToplam.ToString()+"','" + vergiTutari.ToString() +"','"+vergisizToplam.ToString()+"');";
                baglanti.Basla(sorgu);
                if (baglanti.reader.Read())
                {
                    if (baglanti.reader[0].ToString() == sonSatisNumarasi)
                        ilkKontrol = true;
                }
                baglanti.Bitir();
                //gelen id numarası, son satış numarasından 1 fazla ise 
                if (ilkKontrol)
                {
                    //faturasiz satış kalemleri ekle
                    String satis_no = "";
                    String urun_id = "";
                    String urun_ismi = "";
                    String birim = "";
                    String miktar = "";
                    String birim_fiyat = "";
                    String vergi_yuzdesi = "";
                    String vergisiz_toplam_tutar = "";
                    String vergili_toplam_tutar = "";
                    foreach (DataGridViewRow satir in metroGrid1.Rows)
                    {
                        satis_no = sonSatisNumarasi.ToString();
                        urun_id = satir.Cells[0].Value.ToString();
                        urun_ismi = satir.Cells[2].Value.ToString();
                        birim = satir.Cells[3].Value.ToString();
                        miktar = satir.Cells[4].Value.ToString();
                        birim_fiyat = satir.Cells[5].Value.ToString();
                        vergi_yuzdesi = satir.Cells[6].Value.ToString();
                        vergisiz_toplam_tutar = (Convert.ToDouble(miktar) * Convert.ToDouble(birim_fiyat)).ToString();
                        vergili_toplam_tutar = satir.Cells[7].Value.ToString();
                        sorgu = "call market.faturasiz_satis_kalemi_ekle('"+satis_no+"','"+urun_id+"','"+urun_ismi+"','"+birim+"','"+
                            miktar+"','"+birim_fiyat+"','"+vergi_yuzdesi+"','"+
                            vergisiz_toplam_tutar+"','"+vergili_toplam_tutar+"');";
                        baglanti.Basla(sorgu);
                        if (baglanti.reader.RecordsAffected > 0)
                        {

                        }
                        else
                        {
                            mesaj("Ürün Adı: " + urun_ismi, "Satış Gerçekleştirilemedi");
                        }
                        baglanti.Bitir();
                    }
                    mesaj("", "Satış Tamamlandı");
                    metroGrid1.Rows.Clear();
                    metroLabel2.Text = "0 TL";
                }
                else
                {
                    mesaj("Lütfen tekrar deneyiniz", "Beklenmeyen Hata");
                }
                
                

            }
            else
            {
                mesaj("Lütfen ürün seçiniz", "Ürün Yok");
            }
        }

        public void mesaj(string aciklama, string baslik)
        {
            MetroFramework.MetroMessageBox.Show(this, aciklama, baslik);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            if(metroGrid1.RowCount > 0)
            {
                if (!EkranAktiflestir.Acikmi("FaturaKes"))
                {
                    FaturaKes.idVeMiktarlar.Clear();
                    foreach (DataGridViewRow satir in metroGrid1.Rows)
                    {
                        FaturaKes.idVeMiktarlar.Add(satir.Cells[0].Value.ToString(), satir.Cells[4].Value.ToString());
                        
                    }
                    FaturaKes fk = new FaturaKes();
                    fk.Show();
                }
                else
                {
                    mesaj("Lütfen açık olan fatura ekranını kapatınız.", "Fatura Kesme Ekranı Açık");
                    EkranAktiflestir.Aktiflestir("FaturaKes");
                }
            }
            else
            {
                mesaj("Lütfen ürün seçiniz", "Ürün Yok");
            }

        }
    }
}
