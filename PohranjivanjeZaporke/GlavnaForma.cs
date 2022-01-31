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

namespace PohranjivanjeZaporke
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void buttonZadatak_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tekstZadatka, "Opis Zadatka");
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            SakrijRezultat();
            if (textBoxZaporka.Text == String.Empty)
            {
                MessageBox.Show("Unesite zaporku prije pritiska na gumb!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //prilagodi format string u format byte[] koji zahtjeva hashing algoritam
                var textBoxZaporkaBytes = Encoding.UTF8.GetBytes(textBoxZaporka.Text);
                zaporka = shaM.ComputeHash(textBoxZaporkaBytes);
                textBoxZaporka.Text = String.Empty;

                //prikaži gumb za provjeru tek kad je neka zaporka postavljena
                buttonProvjeri.Visible = true;
            }
        }

        private void buttonProvjeri_Click(object sender, EventArgs e)
        {
            if (textBoxZaporka.Text == String.Empty)
            {
                PrikaziRezultat(false);
                MessageBox.Show("Unesite zaporku prije pritiska na gumb!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (zaporka.SequenceEqual(shaM.ComputeHash(Encoding.UTF8.GetBytes(textBoxZaporka.Text))))
            {
                PrikaziRezultat(true);
                MessageBox.Show("Čestitke! Zaporka je ispravna.", "Uspjeh");
            }
            else
            {
                PrikaziRezultat(false);
                MessageBox.Show("Nažalost, zaporka nije ispravna.\nViše sreće drugi put!", "Krivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrikaziRezultat(bool ispravnaZaporka)
        {
            labelBravo.Visible = ispravnaZaporka;
            labelPogreska.Visible = !ispravnaZaporka;
        }

        private void SakrijRezultat()
        {
            labelBravo.Visible = false;
            labelPogreska.Visible = false;
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
