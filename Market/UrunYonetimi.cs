using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Market
{
    public partial class UrunYonetimi : UserControl
    {
        public static Boolean yenile = false;
        public static Boolean barkodGeldi = false;
        Baglanti baglanti = new Baglanti();
        Baglanti yedekBaglanti = new Baglanti();
        public String barkodOkuyucuVerisi="";
        String sorgu = "";
        Dictionary<string, string> raflar = new Dictionary<string, string>();
        Dictionary<string, string> gruplar = new Dictionary<string, string>();
        Dictionary<string, string> firmalar = new Dictionary<string, string>();
        Dictionary<string, string> alt_gruplar = new Dictionary<string, string>();
        Dictionary<string, string> alt_gruplar_temp = new Dictionary<string, string>();
        public UrunYonetimi()
        {
            InitializeComponent();
        }

        

        private void metroTile4_Click(object sender, EventArgs e)
        {
            UrunEkle ue = new UrunEkle();
            ue.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            UreticiFirmaEkle ufe = new UreticiFirmaEkle();
            ufe.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            UrunGrubuEkle uge = new UrunGrubuEkle();
            uge.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            UrunRafEkle ure = new UrunRafEkle();
            ure.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            UrunAltGrubuEkle uage = new UrunAltGrubuEkle();
            uage.Show();
        }

        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            timer3.Interval = 500;
            timer3.Start();
            timer2.Interval = 500;
            basla();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yenile)
            {
                basla();
            }
        }

        public void basla()
        {
            //raflar
            sorgu = "call market.urun_raflari_listele();";
            raflar.Clear();
            metroComboBox1.Items.Clear();
            metroComboBox1.Refresh();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                metroComboBox1.Items.Add(baglanti.reader[1].ToString());
                raflar.Add(baglanti.reader[1].ToString(), baglanti.reader[0].ToString());
            }
            baglanti.Bitir();
            //gruplar
            sorgu = "call market.urun_gruplari_listele();";
            gruplar.Clear();
            metroComboBox2.Items.Clear();
            metroComboBox2.Refresh();
            metroComboBox3.Items.Clear();
            metroComboBox3.Refresh();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                metroComboBox2.Items.Add(baglanti.reader[1].ToString());
                gruplar.Add(baglanti.reader[1].ToString(), baglanti.reader[0].ToString());
            }
            baglanti.Bitir();
            //firmalar
            sorgu = "call market.uretici_firmalari_listele();";
            firmalar.Clear();
            metroComboBox4.Items.Clear();
            metroComboBox4.Refresh();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                metroComboBox4.Items.Add(baglanti.reader[1].ToString());
                firmalar.Add(baglanti.reader[1].ToString(), baglanti.reader[0].ToString());
            }
            baglanti.Bitir();

        }

        private void metroComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string secilenGrup = metroComboBox2.GetItemText(metroComboBox2.SelectedItem);
                    //MessageBox.Show(gruplar[secilenGrup]);
                    sorgu = "call market.urun_alt_gruplarini_listele('" + gruplar[secilenGrup] + "');";
                    metroComboBox3.Items.Clear();
                    alt_gruplar.Clear();
                    baglanti.Basla(sorgu);
                    while (baglanti.reader.Read())
                    {
                        metroComboBox3.Items.Add(baglanti.reader[1].ToString());
                        alt_gruplar.Add(baglanti.reader[1].ToString(), baglanti.reader[0].ToString());
                    }
                    baglanti.Bitir();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            sorgu = "call market.urun_ara('%"+metroTextBox1.Text+"%','";
            String SecilenRaf = "";
            try
            {
                SecilenRaf = raflar[metroComboBox1.GetItemText(metroComboBox1.SelectedItem)];
                sorgu = sorgu +SecilenRaf+ "','";
            }
            catch
            {
                sorgu = sorgu + "%','";
            }
            String SecilenGrup = "";
            try
            {
                SecilenGrup = gruplar[metroComboBox2.GetItemText(metroComboBox2.SelectedItem)];
                sorgu = sorgu + SecilenGrup + "','";
            }
            catch
            {
                sorgu = sorgu + "%','";
            }
            String SecilenAltGrup = "";
            try
            {
                SecilenAltGrup = alt_gruplar[metroComboBox3.GetItemText(metroComboBox3.SelectedItem)];
                sorgu = sorgu + SecilenAltGrup + "','";
            }
            catch
            {
                sorgu = sorgu + "%','";
            }
            String SecilenFirma = "";
            try
            {
                SecilenFirma = firmalar[metroComboBox4.GetItemText(metroComboBox4.SelectedItem)];
                sorgu = sorgu + SecilenFirma + "');";
            }
            catch
            {
                sorgu = sorgu + "%');";
            }
            metroGrid1.Rows.Clear();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                String[] liste = {baglanti.reader[0].ToString(), baglanti.reader[1].ToString(), baglanti.reader[2].ToString(), baglanti.reader[3].ToString(), baglanti.reader[4].ToString() };
                metroGrid1.Rows.Add(liste);
            }
            baglanti.Bitir();

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = -1;
            metroComboBox1.Refresh();
            metroComboBox2.SelectedIndex = -1;
            metroComboBox2.Refresh();
            metroComboBox3.SelectedIndex = -1;
            metroComboBox3.Refresh();
            metroComboBox4.SelectedIndex = -1;
            metroComboBox4.Refresh();
            metroTextBox1.Text = "";
        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            urunDetayGetir(metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        

        public void urunDetayGetir(string id)
        {            
            sorgu = "call market.urun_detay_getir('" + id + "');";
            baglanti.Basla(sorgu);
            if (baglanti.reader.Read())
            {
                metroTextBox2.Text = baglanti.reader[1].ToString();
                metroTextBox3.Text = baglanti.reader[4].ToString();
                metroTextBox4.Text = baglanti.reader[9].ToString();
                metroTextBox5.Text = baglanti.reader[8].ToString();
                metroTextBox6.Text = baglanti.reader[10].ToString();
                metroTextBox7.Text = baglanti.reader[11].ToString();
                String resimbase64 = baglanti.reader[7].ToString();
                pictureBox1.Image = Base64ToImage(baglanti.reader[7].ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                metroComboBox8.Items.Clear();
                foreach (var raf in raflar)
                    metroComboBox8.Items.Add(raf.Key);
                metroComboBox8.SelectedIndex = metroComboBox8.FindStringExact(baglanti.reader[5].ToString());
                metroComboBox8.Refresh();

                metroComboBox7.Items.Clear();
                foreach (var grup in gruplar)
                    metroComboBox7.Items.Add(grup.Key);
                String key = "";
                foreach (var grp in gruplar)
                {
                    if (grp.Value == baglanti.reader[2].ToString())
                        key = grp.Key;
                }
                metroComboBox7.SelectedIndex = metroComboBox7.FindStringExact(key);
                metroComboBox7.Refresh();

                sorgu = "call market.urun_alt_gruplarini_listele('" + baglanti.reader[2].ToString() + "');";
                metroComboBox6.Items.Clear();
                alt_gruplar_temp.Clear();
                yedekBaglanti.Basla(sorgu);
                while (yedekBaglanti.reader.Read())
                {
                    metroComboBox6.Items.Add(yedekBaglanti.reader[1].ToString());
                    alt_gruplar_temp.Add(yedekBaglanti.reader[1].ToString(), yedekBaglanti.reader[0].ToString());
                }
                yedekBaglanti.Bitir();
                foreach (var grp in alt_gruplar_temp)
                {
                    if (grp.Value == baglanti.reader[3].ToString())
                        key = grp.Key;
                }
                metroComboBox6.SelectedIndex = metroComboBox6.FindStringExact(key);
                metroComboBox6.Refresh();

                foreach (var grup in firmalar)
                    metroComboBox5.Items.Add(grup.Key);
                foreach (var frm in firmalar)
                {
                    if (frm.Value == baglanti.reader[6].ToString())
                        key = frm.Key;
                }
                metroComboBox5.SelectedIndex = metroComboBox5.FindStringExact(key);
                metroComboBox5.Refresh();
            }
            baglanti.Bitir();
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (barkodGeldi)
            {
                barkodGeldi = false;
                MessageBox.Show(Form1.okunanBarkod);
                Form1.okunanBarkod = "";                
            }
        }
    }
}
