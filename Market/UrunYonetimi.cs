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
        Baglanti baglanti = new Baglanti();
        String sorgu = "";
        Dictionary<string, string> raflar = new Dictionary<string, string>();
        Dictionary<string, string> gruplar = new Dictionary<string, string>();
        Dictionary<string, string> firmalar = new Dictionary<string, string>();
        Dictionary<string, string> alt_gruplar = new Dictionary<string, string>();
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
            String id = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                //byte[] imageBytes = Convert.FromBase64String(Convert.ToBase64String(resimbase64));
                
            }
            baglanti.Bitir();
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}
