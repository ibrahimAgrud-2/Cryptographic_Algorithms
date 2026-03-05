using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypt
{
    public class clsDecrypt
    {
        public static string buyukHarfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        Dictionary<int, char> buyukHarflerListe = new Dictionary<int, char>();
        public static string kaydirmaliDesifreleme(string sifreliMetin, int anahtar)
        {

            string sonuc = "";
            int n = buyukHarfler.Length;

            foreach (var item in sifreliMetin)
            {
                int index = buyukHarfler.IndexOf(item);

                if (index == -1)
                {
                    sonuc += item;
                    continue;
                }

                int yeniIndex = (index - anahtar) % n;

                if (yeniIndex < 0)
                    yeniIndex += n;

                sonuc += buyukHarfler[yeniIndex];
            }

            return sonuc;
        }

        public static int ModInverse(int a, int m)
        {
            a = a % m;

            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                    return x;
            }

            throw new Exception("Modüler ters yok. 'a' ve m aralarında asal değil.");
        }
        public static string dogrusalDesifreleme(string sifreliMetin, int a, int b)
        {
            string sonuc = "";
            int m = 29;

            int aTers = ModInverse(a, m);

            foreach (var item in sifreliMetin)
            {
                int index = buyukHarfler.IndexOf(item);

                if (index == -1)
                {
                    sonuc += item;
                    continue;
                }

                int yeniIndex = aTers * (index - b);

                yeniIndex = ((yeniIndex % m) + m) % m;

                sonuc += buyukHarfler[yeniIndex];
            }

            return sonuc;
        }
        public static string yerDegistirmeDesifreleme(string sifreliMetin)
        {
            string sonuc = "";
            string buyukHarfler2 = "FGRSŞELMNOYZĞHİIJKAÖPTUÜVBCÇD";

            foreach (var item in sifreliMetin)
            {
                int index = buyukHarfler2.IndexOf(item);

                if (index == -1)
                {
                    sonuc += item;
                    continue;
                }

                sonuc += buyukHarfler[index];
            }

            return sonuc;
        }


        public static string sayiAnahtarliDesifreleme(string sifreliMetin, int sutunSayisi)
        {
            sutunSayisi = 3; // test için sabit
            int satirSayisi = sifreliMetin.Length / sutunSayisi;

            char[,] matris = new char[satirSayisi, sutunSayisi];

            int[] okumaSirasi = { 0, 2, 1 };

            int harfSayaci = 0;

            // Şifreli metni sütun bloklarına ayırıp doğru sütuna yerleştirme
            foreach (int sutunIndis in okumaSirasi)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    matris[i, sutunIndis] = sifreliMetin[harfSayaci++];
                }
            }

            // Matrisi satır satır okuyarak düz metni elde etme
            string sonuc = "";

            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    sonuc += matris[i, j];
                }
            }

            return sonuc.TrimEnd('X'); // padding temizleme
        }

        public static string PermutasyonDesifrele(string sifreliMetin)
        {
            const int blokUzunlugu = 5;
            int[] anahtar = { 3, 1, 0, 2, 4 };

            if (sifreliMetin.Length % blokUzunlugu != 0)
                throw new Exception("Şifreli metin blok uzunluğunun katı değil.");

            int[] tersAnahtar = new int[blokUzunlugu];
            for (int i = 0; i < blokUzunlugu; i++)
                tersAnahtar[anahtar[i]] = i;

            StringBuilder sonuc = new StringBuilder();

            for (int i = 0; i < sifreliMetin.Length; i += blokUzunlugu)
            {
                string blok = sifreliMetin.Substring(i, blokUzunlugu);
                char[] duzBlok = new char[blokUzunlugu];

                for (int j = 0; j < blokUzunlugu; j++)
                {
                    duzBlok[j] = blok[tersAnahtar[j]]; // DÜZELTME
                }

                sonuc.Append(new string(duzBlok));
            }

            return sonuc.ToString().TrimEnd('X');
        }
        public static string rotaDesifrele(string sifreliMetin, int anahtar)
        {
            int satir = anahtar;
            int sutun = (sifreliMetin.Length + anahtar - 1) / anahtar;
            char[,] matris = new char[satir, sutun];

            int ust = 0, alt = satir - 1, sol = 0, sag = sutun - 1;
            int idx = 0;

            while (ust <= alt && sol <= sag)
            {
                // Üst satır
                for (int i = sol; i <= sag; i++) matris[ust, i] = sifreliMetin[idx++];
                ust++;

                // Sağ sütun
                for (int i = ust; i <= alt; i++) matris[i, sag] = sifreliMetin[idx++];
                sag--;

                // Alt satır
                if (ust <= alt)
                    for (int i = sag; i >= sol; i--) matris[alt, i] = sifreliMetin[idx++];
                alt--;

                // Sol sütun
                if (sol <= sag)
                    for (int i = alt; i >= ust; i--) matris[i, sol] = sifreliMetin[idx++];
                sol++;
            }

            // Matrisi satır satır oku
            StringBuilder sonuc = new StringBuilder();
            for (int i = 0; i < satir; i++)
                for (int j = 0; j < sutun; j++)
                    sonuc.Append(matris[i, j]);

            return sonuc.ToString().TrimEnd('X'); // padding temizleme
        }

        public static string zigzagDesifrele(string sifreliMetin, int anahtar)
        {
            if (anahtar == 1) return sifreliMetin; // tek satırsa değişmez

            int n = sifreliMetin.Length;
            int[] satirIndex = new int[n];
            bool asagi = false;
            int satir = 0;

            // Her karakterin hangi satıra ait olduğunu belirle
            for (int i = 0; i < n; i++)
            {
                satirIndex[i] = satir;

                if (satir == 0 || satir == anahtar - 1)
                    asagi = !asagi;

                satir += asagi ? 1 : -1;
            }

            // Her satırda kaç karakter var?
            int[] satirSayaci = new int[anahtar];
            for (int i = 0; i < n; i++)
                satirSayaci[satirIndex[i]]++;

            // Satırları doldur
            string[] satirlar = new string[anahtar];
            int idx = 0;
            for (int r = 0; r < anahtar; r++)
            {
                satirlar[r] = sifreliMetin.Substring(idx, satirSayaci[r]);
                idx += satirSayaci[r];
            }

            // Orijinal sırayı geri oluştur
            int[] poz = new int[anahtar]; // her satırın okunacak indexi
            StringBuilder sonuc = new StringBuilder();
            satir = 0;
            asagi = false;

            for (int i = 0; i < n; i++)
            {
                sonuc.Append(satirlar[satir][poz[satir]++]);

                if (satir == 0 || satir == anahtar - 1)
                    asagi = !asagi;

                satir += asagi ? 1 : -1;
            }

            return sonuc.ToString();
        }


    }
}
