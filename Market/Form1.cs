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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            urunYonetimi1.Visible = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, e.KeyChar.ToString());
            MessageBox.Show(e.KeyChar.ToString());
        }
    }
}
