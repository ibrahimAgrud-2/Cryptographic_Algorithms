using System;
using System.Collections.Generic;
using System.Text;


namespace Encrypt
{
    public class clsEncrypt
    {
        static string buyukHarfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        Dictionary<int, char> buyukHarflerListe = new Dictionary<int, char>();
        public static string kaydirmaliSifreleme(string metin, int anahtar)
        {
            string sonuc = "";
            int n = buyukHarfler.Length;

            foreach (var item in metin)
            {
                int index = buyukHarfler.IndexOf(item);

                if (index == -1)
                {
                    sonuc += item; // alfabe dışı karakteri aynen bırakmak için ABC sona
                    continue;
                }

                int yeniIndex = (index + anahtar) % n;
                sonuc += buyukHarfler[yeniIndex];
            }

            return sonuc;
        }

        public static string dogrusalSifreleme(string metin, int a, int b)
        {




            string sonuc = "";

            foreach (var item in metin)
            {
                int index = buyukHarfler.IndexOf(item);
                sonuc += buyukHarfler[(a * (index) + b) % 29];
            }
            return sonuc;
        }
        public static string yerDegistirme(string metin)
        {
            string sonuc = "";
            string buyukHarfler2 = "FGRSŞELMNOYZĞHİIJKAÖPTUÜVBCÇD";


            foreach (var item in metin)
            {
                int index = buyukHarfler.IndexOf(item);
                sonuc += buyukHarfler2[index];
            }
            return sonuc;
        }


        public static string sayiAnahtarliSifreleme(string metin, int sutunSayisi)
        { /*sadece test için 3*/
            sutunSayisi = 3;




            // Eğer metni sütunlara ayırdığımızda boşluk olursa diye oraya X ile dolduracak
            while (metin.Length % sutunSayisi != 0)
            {
                metin += "X";
            }

            //metni satır sayısına göre matrisse yerleştirmek için matris boyutunu belirleme
            int satirSayisi = metin.Length / sutunSayisi;
            char[,] matris = new char[satirSayisi, sutunSayisi];

            //metni satır sayısına göre matrisse yerleştirme
            int harfSayaci = 0;
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    matris[i, j] = metin[harfSayaci++];
                }
            }


            //Oluşan sütunları belli bir düzende yerleştirerek toplama
            string sonuc = "";
            int[] okumaSirasi = { 0, 2, 1 };

            foreach (int sutunIndis in okumaSirasi)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    sonuc += matris[i, sutunIndis];
                }
            }

            return sonuc;
        }

        public static string PermutasyonSifrele(string metin)
        {

            // Blok uzunluğunu varsayılan olarak 5 yaptık.
            const int blokUzunlugu = 5;
            //Şifreleme dizisinide varsayılan olarak bu
            int[] anahtar = { 3, 1, 0, 2, 4 };

            StringBuilder sb = new StringBuilder(metin);

            //Boş kalan yerlere X ekliyoz
            while (sb.Length % blokUzunlugu != 0)
            {
                sb.Append('X');
            }
            // StringBuilder ile birleştirme işlemini daha hızlı olmasını sağladım
            string duzenlenmişMetin = sb.ToString();
            StringBuilder sonuc = new StringBuilder();

            //BLok blok ayırıyoruz
            for (int i = 0; i < duzenlenmişMetin.Length; i += blokUzunlugu)
            {
                // Mevcut 5 harfli bloğu alıyoruz
                string blok = duzenlenmişMetin.Substring(i, blokUzunlugu);


                // Her bloğun harflerini anahtar dizisindeki sıraya göre diziyoruz
                foreach (int indeks in anahtar)
                {
                    sonuc.Append(blok[indeks]);
                }
            }

            return sonuc.ToString();
        }
        public static string rotaSifrele(string metin, int anahtar)
        {
            // matirsin boyutlarını burada hesaplıyoruz
            int satir = anahtar;
            // Bölme sonucunu yukarı yuvarlar
            int sutun = (metin.Length + anahtar - 1) / anahtar;
            int kapasite = satir * sutun;


            //Eksik karakterle ekle
            string dolguluMetin = metin.PadRight(kapasite, 'X');
            char[,] matris = new char[satir, sutun];

            for (int i = 0; i < satir; i++)
                for (int j = 0; j < sutun; j++)
                    matris[i, j] = dolguluMetin[i * sutun + j];

            // spiral olarak okumak
            StringBuilder sonuc = new StringBuilder();
            int ust = 0, alt = satir - 1, sol = 0, sag = sutun - 1;

            while (ust <= alt && sol <= sag)
            {

                for (int i = sol; i <= sag; i++) sonuc.Append(matris[ust, i]);
                ust++;


                for (int i = ust; i <= alt; i++) sonuc.Append(matris[i, sag]);
                sag--;

                if (ust <= alt)
                {

                    for (int i = sag; i >= sol; i--) sonuc.Append(matris[alt, i]);
                    alt--;
                }

                if (sol <= sag)
                {

                    for (int i = alt; i >= ust; i--) sonuc.Append(matris[i, sol]);
                    sol++;
                }
            }

            return sonuc.ToString();
        }

        public static string zigzagSİfrele(string metin, int anahtar)
        {


            // Her satır için bir StringBuilder oluşturuyoruz
            StringBuilder[] satirlar = new StringBuilder[anahtar];
            for (int i = 0; i < anahtar; i++) satirlar[i] = new StringBuilder();

            int mevcutSatir = 0;
            bool asagiGidiyormu = false;

            // Metindeki her harfi matisteki konumuna yerleştir
            foreach (char c in metin)
            {
                satirlar[mevcutSatir].Append(c);

                // Matiste en üst veya en alt satırlara geldik mi yön değiştir
                if (mevcutSatir == 0 || mevcutSatir == anahtar - 1)
                    asagiGidiyormu = !asagiGidiyormu;

                mevcutSatir += asagiGidiyormu ? 1 : -1;
            }

            //satırları birleştirerek sonucu döndür
            StringBuilder sonuc = new StringBuilder();
            foreach (var satir in satirlar) sonuc.Append(satir);

            return sonuc.ToString();
        }


    }
}
