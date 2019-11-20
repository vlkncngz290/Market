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
    public partial class UrunRafEkle : MetroFramework.Forms.MetroForm
    {
        Baglanti baglanti = new Baglanti();
        String sorgu = "";
        public UrunRafEkle()
        {
            InitializeComponent();
        }

        private void UrunRafEkle_Load(object sender, EventArgs e)
        {
            basla();
        }

        private void basla()
        {
            sorgu = "call market.urun_raflari_listele();";
            metroGrid1.Rows.Clear();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                metroGrid1.Rows.Add(baglanti.reader[0].ToString(), baglanti.reader[1].ToString());                

            }
            baglanti.Bitir();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 1)
            {
                sorgu = "call market.urun_rafi_ekle('"+metroTextBox1.Text+"');";
                baglanti.Basla(sorgu);
                if (baglanti.reader.RecordsAffected > 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Raf başarıyla eklendi");
                    metroTextBox1.Text = "";
                    basla();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Bağlantı hatası, raf eklenemedi");
                }
                baglanti.Bitir();

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Raf ismi en az 2 karakterli olmalıdır.");
            }
            UrunEkle.veri_yenile = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Seçilen rafı silmek istediğinize eminmisiniz?", "Raf: " + metroGrid1.SelectedRows[0].Cells[0].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    sorgu = "call market.urun_rafi_sil('" + metroGrid1.SelectedRows[0].Cells[0].Value.ToString() + "');";
                    baglanti.Basla(sorgu);
                    if (baglanti.reader.RecordsAffected > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Raf başarıyla silindi");
                        basla();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Bağlantı hatası, raf silinemedi");
                    }
                }
                catch
                {

                }
                UrunEkle.veri_yenile = true;
            }
            
        }
    }
}
