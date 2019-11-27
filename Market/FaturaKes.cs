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
        String sorgu = "";
        Baglanti baglanti = new Baglanti();
        public FaturaKes()
        {
            InitializeComponent();
        }

        private void FaturaKes_Load(object sender, EventArgs e)
        {
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
                    metroGrid1.Rows.Add(id,baglanti.reader[0].ToString(), baglanti.reader[1].ToString(),
                        idVeMiktarlar[id],baglanti.reader[2].ToString(), baglanti.reader[3].ToString(),toplamFiyat.ToString());
                }
                baglanti.Bitir();
            }
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
    }
}
