using OS_Projekt.DatotecniSustav;
using OS_Projekt.Kriptosustavi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Projekt
{
    public partial class Form1 : Form
    {
        private byte[] digitalniPotpis;

        public Form1()
        {
            InitializeComponent();
        }

        private void PostaviTekst(string tekst)
        {
            txtUlazniPodaci.Text = tekst;
        }

        private void OsvjeziLabele()
        {
            lblTajniKljuc.Text = "Tajni ključ: " + AES.DohvatiTajniKljuc();
            lblPrivatniKljuc.Text = "Privatni ključ: " + RSA.DohvatiPrivatniKljuc().Substring(0, 50) + "...";
            lblJavniKljuc.Text = "Javni ključ: " + RSA.DohvatiJavniKljuc().Substring(0, 50) + "...";
        }

        private void OsvjeziFormu()
        {
            txtDirektorij.Text = Datoteka.DohvatiRadniDirektorij();
        }
        private void OsvjeziGumboveNakonOdabiraDirektorija()
        {
            this.btnGenerirajKljuceve.Enabled = true;
            this.btnDirektorij.Enabled = false;
        }
        private void OdaberiRadniDirektorij()
        {
            Datoteka.OdaberiRadniDirektorij();
            OsvjeziFormu();
            if (Datoteka.ProvjeriPostojanostDatoteka())
            {
                Datoteka.IzbrisiDatoteke();
            }
            OsvjeziGumboveNakonOdabiraDirektorija();
        }

        private void btnDirektorij_Click(object sender, EventArgs e)
        {
            try
            {
                OdaberiRadniDirektorij();
                
            }
            catch (Exception poruka)
            {
                MessageBox.Show(poruka.Message);
            }
        }
        private void OtkljucajGumboveNakonGeneriranja()
        {
            this.btnAsimetricnoDekriptiraj.Enabled = true;
            this.btnAsimetricnoKriptiraj.Enabled = true;
            this.btnSimetricnoDekriptiraj.Enabled = true;
            this.BtnSimetricnoKriptiraj.Enabled = true;
        }
        private void btnGenerirajKljuceve_Click(object sender, EventArgs e)
        {
            Datoteka.KreirajDatoteke();
            OsvjeziLabele();
            this.btnGenerirajKljuceve.Enabled = false;
            this.btnIzracunajSazetak.Enabled = true;
            this.btnDigitalnoPotpisi.Enabled = true;
            this.btnProvjeriDigitalniPotpis.Enabled = true;            
            this.btnOdaberiUlaznuDatoteku.Enabled = true;
        }

        private void btnOdaberiUlaznuDatoteku_Click(object sender, EventArgs e)
        {
            
            try
            {
                OdaberiUlaznuDatoteku();
            }
            catch (Exception poruka)
            {
                MessageBox.Show(poruka.Message);
            }
        }
        private void OdaberiUlaznuDatoteku()
        {
            string putanjaDatoteke = "";
            putanjaDatoteke = Datoteka.UcitajSadrzajKriptiranja();
            if (putanjaDatoteke.Length > 0 && putanjaDatoteke != "")
            {
                txtUlazniPodaci.Text = Datoteka.UcitajSadrzajDatoteke(putanjaDatoteke);
                OtkljucajGumboveNakonGeneriranja();
            }
        }

        private void BtnSimetricnoKriptiraj_Click(object sender, EventArgs e)
        {
            string putanjaDatoteke = Datoteka.KreirajAesKriptiraniSadrzajDatoteke();
            byte[] kriptiraniSadrzaj = AES.KriptirajSadrzaj(txtUlazniPodaci.Text);
            string sadrzaj = Convert.ToBase64String(kriptiraniSadrzaj);
            Datoteka.ZapisiUDatoteku(putanjaDatoteke, sadrzaj);
            PostaviTekst(sadrzaj);
        }

        private void btnSimetricnoDekriptiraj_Click(object sender, EventArgs e)
        {
            string putanjaDatotke = Datoteka.KreirajAesDekriptiraniSadrzajDatoteke();
            string putanjaKriptiraneDatoteke = Datoteka.DohvatiRadniDirektorij() + @"/kriptirani_sadrzaj.txt";
            string kriptiraniSadrzaj = Datoteka.UcitajSadrzajDatoteke(putanjaKriptiraneDatoteke);
            string dekripitaniSadrzaj = AES.DekriptirajSadrzaj(kriptiraniSadrzaj);
            Datoteka.ZapisiUDatoteku(putanjaDatotke, dekripitaniSadrzaj);
            PostaviTekst(dekripitaniSadrzaj);
        }

        private void btnAsimetricnoKriptiraj_Click(object sender, EventArgs e)
        {
            string putanjaDatoteke = Datoteka.KreirajRsaDatotekuZaKriptiranje();
            byte[] sadrzajKriptiranja = Encoding.UTF8.GetBytes(txtUlazniPodaci.Text);
            string kriptiraniSadrzaj = RSA.Krpitiraj(sadrzajKriptiranja);
            Datoteka.ZapisiUDatoteku(putanjaDatoteke, kriptiraniSadrzaj);
            PostaviTekst(kriptiraniSadrzaj);
        }

        private void btnAsimetricnoDekriptiraj_Click(object sender, EventArgs e)
        {
            string putanjaDatoteke = Datoteka.KreirajRsaDatotekuZaDekriptiranje();
            string radniDirektorij = Datoteka.DohvatiRadniDirektorij();
            string putanja = radniDirektorij + @"/RSAkriptirani_sadrzaj.txt";
            string kriptiraniSadrzaj = Datoteka.UcitajSadrzajDatoteke(putanja);
            byte[] tekst = Convert.FromBase64String(kriptiraniSadrzaj);
            string dekriptiraniSadrzaj = RSA.Dekriptiraj(tekst);
            Datoteka.ZapisiUDatoteku(putanjaDatoteke, dekriptiraniSadrzaj);
            PostaviTekst(dekriptiraniSadrzaj);
        }

        private void btnIzracunajSazetak_Click(object sender, EventArgs e)
        {
            string putanjaDatoteke = "";
            byte[] sadrzajDatoteke;

            try
            {
                putanjaDatoteke = Datoteka.UcitajDatotekuDigitalnogPotpisivanje();
            }
            catch (Exception poruka)
            {
                MessageBox.Show(poruka.Message);
            }

            try
            {
                sadrzajDatoteke = Datoteka.UcitajOdredenuDatoteku(putanjaDatoteke);
                IzracunavanjeSazetkaOdabraneDatoteke(sadrzajDatoteke);
            }
            catch (Exception poruka)
            {
                MessageBox.Show(poruka.Message);
            }
        }
        private void IzracunavanjeSazetkaOdabraneDatoteke(byte[] sadrzajDatoteke)
        {
            byte[] sazetakDatoteke = RSA.IzracunajSazetakDatoteke(sadrzajDatoteke);
            string putanjaSazetka = Datoteka.KreirajDatotekuSazetka();
            string izracunatSazetak = Convert.ToBase64String(sazetakDatoteke);
            Datoteka.ZapisiUDatoteku(putanjaSazetka, izracunatSazetak);
            txtUlazniPodaci.Text = izracunatSazetak;
        }

        private void btnDigitalnoPotpisi_Click(object sender, EventArgs e)
        {
            string putanjaDatotekeDigitalnogPotpisa = Datoteka.KreirajDatotekuDigitalnogPotpisa();
            string datotekaPotpisivanja = "";
            OpenFileDialog ucitanaDatoteka = new OpenFileDialog();
            if (ucitanaDatoteka.ShowDialog() == DialogResult.OK)
            {
                datotekaPotpisivanja = ucitanaDatoteka.FileName;
            }
            byte[] sadrzajUcitaneDatoteke = Datoteka.UcitajOdredenuDatoteku(datotekaPotpisivanja);
            byte[] sadrzajDigitalnogPotpisa = RSA.DigPotpis(sadrzajUcitaneDatoteke);
            string strSadrzajDigitalnogPotpisa = Convert.ToBase64String(sadrzajDigitalnogPotpisa);
            Datoteka.ZapisiUDatoteku(putanjaDatotekeDigitalnogPotpisa, strSadrzajDigitalnogPotpisa);
            txtUlazniPodaci.Text = strSadrzajDigitalnogPotpisa;
            digitalniPotpis = sadrzajDigitalnogPotpisa;
        }

        private void btnProvjeriDigitalniPotpis_Click(object sender, EventArgs e)
        {
            string putanjaOdabranaDatoteka = "";
            OpenFileDialog odabranaDatoteka = new OpenFileDialog();
            if (odabranaDatoteka.ShowDialog() == DialogResult.OK)
            {
                putanjaOdabranaDatoteka = odabranaDatoteka.FileName;
            }
            string radniDirektorij = Datoteka.DohvatiRadniDirektorij();
            string sadrzajDigPotpisa = Datoteka.UcitajSadrzajDatoteke(radniDirektorij + @"/digitalni_potpis.txt");
            byte[] DigPot = Convert.FromBase64String(sadrzajDigPotpisa);
            byte[] sadrzajDatoteke = Datoteka.UcitajOdredenuDatoteku(putanjaOdabranaDatoteka);
            bool ispravnostPotpisa = RSA.ProvjeriDigPotpis(sadrzajDatoteke, DigPot);
            if (ispravnostPotpisa)
            {
                MessageBox.Show("Datoteka vrijedi!");
            }
            else
            {
                MessageBox.Show("Datoteka se ne podudara s prijasnjom!");
            }
        }
    }
}
