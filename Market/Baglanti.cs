using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    class Baglanti
    {

        public MySqlDataReader reader;
        public static MySqlConnection baglanti;

        public void Basla(string sorgu)
        {
            try
            {
                // 85.105.97.223
                baglanti = new MySqlConnection("server=192.168.1.249;user id=root;password=E77c7d6a**;database=market");
                MySqlCommand sql = baglanti.CreateCommand();
                sql.CommandText = sorgu;
                baglanti.Open();
                reader = sql.ExecuteReader();

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                MessageBox.Show(Ex.ToString());
            }


        }

        public string Bitir()
        {
            try
            {
                reader.Close();
                baglanti.Close();
                return "1";
            }
            catch (Exception Ex)
            {
                //Console.WriteLine(Ex.ToString());
                return "0";

            }


        }

    }
}
