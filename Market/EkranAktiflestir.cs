using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    class EkranAktiflestir
    {
        public static void Aktiflestir(string ekranismi)
        {
            bool acikmi = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name.ToString() == ekranismi)
                {
                    acikmi = true;
                }

            }
            if (acikmi)
            {
                foreach (Form frm in fc)
                {
                    if (frm.Name.ToString() == ekranismi)
                    {

                        frm.Activate();
                        frm.Focus();
                    }
                }
            }
        }

        public static bool Acikmi(string ekranismi)
        {
            bool acikmi = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name.ToString() == ekranismi)
                {
                    acikmi = true;
                }

            }
            return acikmi;
        }
    }
}
