using System;
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
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Lütfen geçerli bir resim seçiniz.", "Resim Yüklenemedi");
                }
                
            }
        }
    }
}
