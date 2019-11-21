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
    public partial class UrunGrubuEkle : MetroFramework.Forms.MetroForm
    {
        Baglanti baglanti = new Baglanti();
        String sorgu = "";

        public UrunGrubuEkle()
        {
            InitializeComponent();
        }

        private void UrunGrubuEkle_Load(object sender, EventArgs e)
        {
            basla();
        }

        public void basla()
        {
            sorgu = "call market.urun_gruplari_listele();";
            metroGrid1.Rows.Clear();
            baglanti.Basla(sorgu);
            while (baglanti.reader.Read())
            {
                metroGrid1.Rows.Add(baglanti.reader[0].ToString(), baglanti.reader[1].ToString());
            }
            baglanti.Bitir();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Ürün grubunu silmek istediğinize eminmisiniz?", "Grup ismi: " + metroGrid1.SelectedRows[0].Cells[1].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    String id = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
                    String sorgu = "call market.urun_grubu_sil('" + id + "');";
                    baglanti.Basla(sorgu);
                    if (baglanti.reader.RecordsAffected > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Grup başarıyla silindi");
                        basla();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Grup silinemedi", "Bağlantı Hatası");
                    }
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
                String sorgu = "call market.urun_grubu_ekle('" + metroTextBox1.Text + "');";
                baglanti.Basla(sorgu);
                if (baglanti.reader.RecordsAffected > 0)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Başka grup eklemek istermisiniz?", "Grup başarıyla eklendi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        metroTextBox1.Text = "";
                        basla();
                    }
                    else
                    {
                        UrunEkle.veri_yenile = true;
                        UrunYonetimi.yenile = true;
                        EkranAktiflestir.Aktiflestir("UrunEkle");
                        this.Close();
                    }
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Grup ismi en az 3 haneli olmalıdır");
            }
        }
    }
}
