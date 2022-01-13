using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZadatak_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tekstZadatka, "Opis Zadatka");
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            if (textBoxZaporka.Text == String.Empty)
            {
                MessageBox.Show("Unesite zaporku prije pritiska na gumb!", "Upozorenje");
            }
            else
            {
                //prilagodi format string u format byte[] koji zahtjeva hashing algoritam
                var textBoxZaporkaBytes = Encoding.UTF8.GetBytes(textBoxZaporka.Text);
                zaporka = shaM.ComputeHash(textBoxZaporkaBytes);
                textBoxZaporka.Text = String.Empty;
            }
        }

        private void buttonProvjeri_Click(object sender, EventArgs e)
        {
            if (textBoxZaporka.Text == String.Empty)
            {
                MessageBox.Show("Unesite zaporku prije pritiska na gumb!", "Upozorenje");
            }
            else if (zaporka.SequenceEqual(shaM.ComputeHash(Encoding.UTF8.GetBytes(textBoxZaporka.Text))))
            {
                MessageBox.Show("Čestitke! Zaporka je ispravna.", "Uspjeh");
            }
            else
            {
                MessageBox.Show("Nažalost, zaporka nije ispravna.\nViše sreće drugi put!", "Krivo");
            }
        }

        private string tekstZadatka = "Pohranjivanje zaporke:\nNapraviti program koji će omogućiti sigurnu pohranu zaporki korištenjem nekog" +
                                      " standardnog hash-algoritma. Program treba imati polje u koje se upiše zaporka te tipke \"Spremi\" i " +
                                      "\"Provjeri\". Korisnik treba upisati zaporku i pritiskom na tipku \"Spremi\" program će hashirati upisani" +
                                      " tekst (pretvoriti ga u oblik koji se ne može dešifrirati) korištenjem npr. klase " +
                                      "System.Security.Cryptography.SHA512ManagedClass " +
                                      "iz .NET biblioteke i spremiti ga u tom obliku u datoteku. Sljedeći puta kada korisnik upiše zaporku i pritisne" +
                                      " tipku \"Provjeri\", program treba hashirati upisani tekst, usporediti to sa sadržajem datoteke u koju je " +
                                      "prije toga bila pohranjena zaporka identična izvornoj ili ne.";

        private SHA512 shaM = new SHA512Managed();
        private byte[] zaporka;
    }
}
