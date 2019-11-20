﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class UrunEkle : MetroFramework.Forms.MetroForm
    {
        Baglanti baglanti = new Baglanti();
        String sorgu = "";
        Dictionary<string, string> raflar = new Dictionary<string, string>();
        Dictionary<string, string> gruplar = new Dictionary<string, string>();
        Dictionary<string, string> firmalar = new Dictionary<string, string>();
        Dictionary<string, string> alt_gruplar = new Dictionary<string, string>();
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);
        String resimVeri = "";
        String barkodOkuyucuVerisi = "";
        Boolean veriAl = false;
        public static bool veri_yenile = false;
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            //file.Filter = "jpeg |*.jpeg| jpg|*.jpg png|*.png";  
            file.FilterIndex = 3;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Yüklenecek resmi seçiniz";
            file.Multiselect = false;

            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string DosyaYolu = file.FileName;
                    string DosyaAdi = file.SafeFileName;
                    Image resim = Image.FromFile(DosyaYolu);
                    MemoryStream m = new MemoryStream();
                    resim.Save(m, resim.RawFormat);
                    pictureBox1.Image = Image.FromStream(m);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    byte[] resimByte = m.ToArray();
                    string base64resim = Convert.ToBase64String(resimByte);
                    resimVeri = base64resim;
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Lütfen geçerli bir resim seçiniz.", "Resim Yüklenemedi");
                }
                
            }
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
            basla();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (veri_yenile)
            {
                veri_yenile = false;
                basla();
            }
            barkodOkuyucuVerisi = "";
        }

        public void basla()
        {
            //raflar
            sorgu = "call market.urun_raflari_listele();";
            raflar.Clear();
            metroComboBox8.Items.Clear();
            metroComboBox8.Refresh();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                metroComboBox8.Items.Add(baglanti.reader[1].ToString());
                raflar.Add(baglanti.reader[1].ToString(), baglanti.reader[0].ToString());
            }
            baglanti.Bitir();

            //gruplar
            sorgu = "call market.urun_gruplari_listele();";
            gruplar.Clear();
            metroComboBox7.Items.Clear();
            metroComboBox7.Refresh();
            metroComboBox6.Items.Clear();
            metroComboBox6.Refresh();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                metroComboBox7.Items.Add(baglanti.reader[1].ToString());
                gruplar.Add(baglanti.reader[1].ToString(), baglanti.reader[0].ToString());
            }
            baglanti.Bitir();

            //firmalar
            sorgu= "call market.uretici_firmalari_listele();";
            firmalar.Clear();
            metroComboBox5.Items.Clear();
            metroComboBox5.Refresh();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                metroComboBox5.Items.Add(baglanti.reader[1].ToString());
                firmalar.Add(baglanti.reader[1].ToString(), baglanti.reader[1].ToString());
            }
            baglanti.Bitir();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            UreticiFirmaEkle ufe = new UreticiFirmaEkle();
            ufe.Show();
        }

      

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.add_480px;
            pictureBox5.Refresh();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.add2_480px;
            pictureBox4.Refresh();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.add_480px;
            pictureBox4.Refresh();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.add2_480px;
            pictureBox5.Refresh();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.add2_480px;
            pictureBox3.Refresh();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.add_480px;
            pictureBox3.Refresh();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UrunGrubuEkle uge = new UrunGrubuEkle();
            uge.Show();
        }


        private void UrunEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                metroTextBox5.Text=barkodOkuyucuVerisi;
            }
            if (true)
            {
                barkodOkuyucuVerisi = barkodOkuyucuVerisi + e.KeyChar.ToString();
            }
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UrunRafEkle ure = new UrunRafEkle();
            ure.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UrunAltGrubuEkle uage = new UrunAltGrubuEkle();
            uage.Show();
        }
    }
}
