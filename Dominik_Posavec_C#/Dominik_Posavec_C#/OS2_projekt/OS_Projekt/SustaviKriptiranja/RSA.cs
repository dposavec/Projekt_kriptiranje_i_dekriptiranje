using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OS_Projekt.Kriptosustavi
{
    public class RSA
    {
        private static string privatniKljuc { get; set; }
        private static string javniKljuc { get; set; }
        private static RSACryptoServiceProvider rsaOperator;
        private static RSAParameters rsaParametri;

        public static string[] GenerirajKljuceve()
        {
            string[] generiraniKljucevi = new string[2];
            rsaOperator = new RSACryptoServiceProvider(2048);
            rsaParametri = rsaOperator.ExportParameters(true);
            privatniKljuc = Convert.ToBase64String(rsaParametri.D);
            javniKljuc = Convert.ToBase64String(rsaParametri.Modulus);
            generiraniKljucevi[0] = javniKljuc;
            generiraniKljucevi[1] = privatniKljuc;
            return generiraniKljucevi;
        }

        public static string DohvatiPrivatniKljuc()
        {
            return privatniKljuc;
        }

        public static string DohvatiJavniKljuc()
        {
            return javniKljuc;
        }

        public static void PostaviPrivatniKljuc(string kljuc)
        {
            if(kljuc.Length > 0)
            {
                privatniKljuc = kljuc;
            }
        }

        public static void PostavniJavniKljuc(string kljuc)
        {
            if(kljuc.Length > 0)
            {
                javniKljuc = kljuc;
            }
        }

        public static string Krpitiraj(byte[] sadrzajKriptiranja)
        {
            byte[] kriptiraniSadrzaj = rsaOperator.Encrypt(sadrzajKriptiranja, false);
            return Convert.ToBase64String(kriptiraniSadrzaj);
        }

        public static string Dekriptiraj(byte[] tekst)
        {
            byte[] dekriptiraniTekst = rsaOperator.Decrypt(tekst, false);
            return Encoding.UTF8.GetString(dekriptiraniTekst);
        }

        public static byte[] IzracunajSazetakDatoteke(byte[] sadrzajDatoteke)
        {
            SHA256Managed sha = new SHA256Managed();
            return sha.ComputeHash(sadrzajDatoteke, 0, sadrzajDatoteke.Length);
        }

        public static byte[] DigitalnoPotpisi(byte[] sadrzajDatoteke)
        {
            byte[] izracunatSazetak = IzracunajSazetakDatoteke(sadrzajDatoteke);
            return rsaOperator.SignHash(izracunatSazetak, CryptoConfig.MapNameToOID("SHA256"));
        }

        public static bool ProvjeriValjanostDigitalnogPotpisa(byte[] ucitanaDatotekea, byte[] digitalniPotpisDatoteke)
        {
            byte[] sazetakDatoteke = IzracunajSazetakDatoteke(ucitanaDatotekea);
            return rsaOperator.VerifyHash(sazetakDatoteke, CryptoConfig.MapNameToOID("SHA256"), digitalniPotpisDatoteke);
        }

        public static byte[] DigPotpis(byte[] sadrzajDatoteke)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hash = sha256.ComputeHash(sadrzajDatoteke);

            RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(rsaOperator);
            RSAFormatter.SetHashAlgorithm("SHA256");
            byte[] potpisanHash = RSAFormatter.CreateSignature(hash);
            return potpisanHash;

        }

        public static bool ProvjeriDigPotpis(byte[] sadrzajDatoteke, byte[] digitalniPotpis)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hash = sha256.ComputeHash(sadrzajDatoteke);

            RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(rsaOperator);
            RSAFormatter.SetHashAlgorithm("SHA256");
            byte[] potpisanHash = RSAFormatter.CreateSignature(hash);



            RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(rsaOperator);
            RSADeformatter.SetHashAlgorithm("SHA256");

            if(RSADeformatter.VerifySignature(hash, digitalniPotpis))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
