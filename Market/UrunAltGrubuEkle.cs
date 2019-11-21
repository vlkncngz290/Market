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
    public partial class UrunAltGrubuEkle : MetroFramework.Forms.MetroForm
    {
        Baglanti baglanti = new Baglanti();
        Baglanti yardimciBaglanti = new Baglanti();
        String sorgu = "";
        Dictionary<string, string> gruplar = new Dictionary<string, string>();
        public UrunAltGrubuEkle()
        {
            InitializeComponent();
        }

        private void UrunAltGrubuEkle_Load(object sender, EventArgs e)
        {
            basla();
        }

        private void basla()
        {
            sorgu = "call market.urun_gruplari_listele();";
            metroComboBox1.Items.Clear();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                metroComboBox1.Items.Add(baglanti.reader[1].ToString());
                gruplar.Add(baglanti.reader[1].ToString(), baglanti.reader[0].ToString());
            }
            baglanti.Bitir();
        }

        private void metroComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string secilenGrup = metroComboBox1.GetItemText(metroComboBox1.SelectedItem);
                //MessageBox.Show(gruplar[secilenGrup]);
                sorgu = "call market.urun_alt_gruplarini_listele('" + gruplar[secilenGrup]+"');";
                metroGrid1.Rows.Clear();
                baglanti.Basla(sorgu);
                while (baglanti.reader.Read())
                {
                    metroGrid1.Rows.Add(baglanti.reader[0].ToString(), baglanti.reader[1].ToString());
                }
                baglanti.Bitir();
            }
            catch
            {

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string secilenID = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
                string secilenGrup = metroComboBox1.GetItemText(metroComboBox1.SelectedItem);
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Alt grubu silmek istiyormusunuz?","Alt Grup: "+ metroGrid1.SelectedRows[0].Cells[1].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    sorgu = "call market.urun_alt_grup_sil('" + secilenID + "');";
                    baglanti.Basla(sorgu);
                    if (baglanti.reader.RecordsAffected > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Alt grup başarıyla silindi");
                        sorgu = "call market.urun_alt_gruplarini_listele('" + gruplar[secilenGrup] + "');";
                        metroGrid1.Rows.Clear();
                        yardimciBaglanti.Basla(sorgu);
                        while (yardimciBaglanti.reader.Read())
                        {
                            metroGrid1.Rows.Add(yardimciBaglanti.reader[0].ToString(), yardimciBaglanti.reader[1].ToString());
                        }
                        yardimciBaglanti.Bitir();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Bağlantı hatası, alt grup silinemedi");
                    }
                    baglanti.Bitir();
                    UrunEkle.veri_yenile = true;
                    UrunYonetimi.yenile = true;
                }                              

            }
            catch
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 2)
            {
                try
                {
                    string secilenGrup = metroComboBox1.GetItemText(metroComboBox1.SelectedItem);
                    sorgu= "call market.urun_alt_grup_ekle('" + gruplar[secilenGrup] + "','"+metroTextBox1.Text+"');";
                    baglanti.Basla(sorgu);
                    if (baglanti.reader.RecordsAffected > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Alt grup başarıyla eklendi");
                        sorgu = "call market.urun_alt_gruplarini_listele('" + gruplar[secilenGrup] + "');";
                        metroGrid1.Rows.Clear();
                        yardimciBaglanti.Basla(sorgu);
                        while (yardimciBaglanti.reader.Read())
                        {
                            metroGrid1.Rows.Add(yardimciBaglanti.reader[0].ToString(), yardimciBaglanti.reader[1].ToString());
                        }
                        yardimciBaglanti.Bitir();
                        metroTextBox1.Text = "";
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Bağlantı hatası, alt grup eklenemedi");
                    }
                    baglanti.Bitir();
                    UrunEkle.veri_yenile = true;
                    UrunYonetimi.yenile = true;
                    
                }
                catch
                {

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Alt grup ismi en az 3 haneli olmalıdır.");
            }
        }
    }
}
