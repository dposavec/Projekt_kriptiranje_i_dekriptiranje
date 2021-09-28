using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OS_Projekt.Kriptosustavi
{
    public class AES
    {
        private static Aes aesOperator;
        private static string tajniKljuc;

        public static string KreirajTajniKljuc()
        {
            aesOperator = Aes.Create();
            aesOperator.BlockSize = 128;
            aesOperator.KeySize = 256;
            aesOperator.Mode = CipherMode.CBC;
            aesOperator.Padding = PaddingMode.PKCS7;
            aesOperator.GenerateKey();
            aesOperator.GenerateIV();
            tajniKljuc = Convert.ToBase64String(aesOperator.Key);
            return tajniKljuc;
        }

        public static string DohvatiTajniKljuc()
        {
            return tajniKljuc;
        }

        public static void PostaviTajniKljuc(string kljuc)
        {
            if(kljuc.Length > 0)
            {
                tajniKljuc = kljuc;
            }
        }

        public static byte[] KriptirajSadrzaj(string tekst)
        {
            byte[] kriptiraniSadrzaj;
            ICryptoTransform objKriptiranja = aesOperator.CreateEncryptor(aesOperator.Key, aesOperator.IV);
            using(MemoryStream memorijskoSturjanje = new MemoryStream())
            {
                using (CryptoStream strujanjeKriptiranja = new CryptoStream(memorijskoSturjanje, objKriptiranja, CryptoStreamMode.Write))
                {
                    using(StreamWriter pisacStrujanja = new StreamWriter(strujanjeKriptiranja))
                    {
                        pisacStrujanja.Write(tekst);
                    }
                    kriptiraniSadrzaj = memorijskoSturjanje.ToArray();
                }
            }
            return kriptiraniSadrzaj;
        }

        public static string DekriptirajSadrzaj(string tekst)
        {
            byte[] kriptiraniTekst = Convert.FromBase64String(tekst);
            string dekripitraniTekst;
            ICryptoTransform objDekriptor = aesOperator.CreateDecryptor(aesOperator.Key, aesOperator.IV);
            using (MemoryStream memorijskoSturjanje = new MemoryStream(kriptiraniTekst))
            {
                using (CryptoStream strujanjeDekriptiranja = new CryptoStream(memorijskoSturjanje, objDekriptor, CryptoStreamMode.Read))
                {
                    using (StreamReader citacStrujanja = new StreamReader(strujanjeDekriptiranja))
                    {
                        dekripitraniTekst = citacStrujanja.ReadToEnd();
                    }
                }
            }
            return dekripitraniTekst;
        }
    }
}
