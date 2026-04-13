using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmHillDescrypt : Form
    {
  
        private static readonly char[] ALFABE = {
            'A','B','C','Ç','D','E','F','G','Ğ','H',  // 0-9
            'I','İ','J','K','L','M','N','O','Ö','P',  // 10-19
            'R','S','Ş','T','U','Ü','V','Y','Z'        // 20-28
        };

        private const int MOD = 29;

        public frmHillDescrypt()
        {
            InitializeComponent();
        }

        private void frmHillDescrypt_Load(object sender, EventArgs e)
        {
        }

      
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTextToDecrypt.Text))
            {
                MessageBox.Show("Lütfen deşifrelenecek metni girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRow1.Text) ||
                string.IsNullOrWhiteSpace(txtRow2.Text) ||
                string.IsNullOrWhiteSpace(txtRow3.Text))
            {
                MessageBox.Show("Lütfen tüm anahtar satırlarını doldurun.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sonuc = Hazirlik(txtTextToDecrypt.Text, txtRow1.Text, txtRow2.Text, txtRow3.Text);

            if (sonuc != "")
                txtDecryptedText.Text = sonuc;
        }


        private string Hazirlik(string metin, string satir1, string satir2, string satir3)
        {
        
            int[,] anahtar = new int[3, 3];
            string[] satirlar = { satir1, satir2, satir3 };

            for (int i = 0; i < 3; i++)
            {
                string[] elemanlar = satirlar[i].Split(',');

                if (elemanlar.Length != 3)
                {
                    MessageBox.Show($"Satır {i + 1} hatalı!\nDoğru format: '6,22,5'", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

                for (int j = 0; j < 3; j++)
                {
                    if (!int.TryParse(elemanlar[j].Trim(), out anahtar[i, j]))
                    {
                        MessageBox.Show($"Satır {i + 1}, {j + 1}. eleman sayı değil!", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "";
                    }
                }
            }

      
            int[,] tersMatris = MatrisTersiBul(anahtar);
            if (tersMatris == null)
                return ""; 

    
            metin = metin.ToUpper(new System.Globalization.CultureInfo("tr-TR")).Replace(" ", "");

            List<int> sayilar = new List<int>();

            foreach (char harf in metin)
            {
                int index = HarftenSayiya(harf);
                if (index == -1)
                {
                    MessageBox.Show($"'{harf}' harfi Türkçe alfabede yok!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
                sayilar.Add(index);
            }

            if (sayilar.Count % 3 != 0)
            {
                MessageBox.Show("Şifreli metin uzunluğu 3'ün katı olmalıdır!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

          
            return Desifrele(sayilar, tersMatris);
        }


        private string Desifrele(List<int> sayilar, int[,] tersMatris)
        {
            string duzMetin = "";

            for (int blok = 0; blok < sayilar.Count; blok += 3)
            {
               
                int[] blokVektor = new int[3];
                for (int i = 0; i < 3; i++)
                    blokVektor[i] = sayilar[blok + i];

                int[] sonucVektor = new int[3];

                for (int j = 0; j < 3; j++)
                {
                    int toplam = 0;
                    for (int k = 0; k < 3; k++)
                        toplam += blokVektor[k] * tersMatris[k, j];

                    sonucVektor[j] = ((toplam % MOD) + MOD) % MOD;
                }

                // Sayıları harfe çevir
                for (int i = 0; i < 3; i++)
                    duzMetin += SayidanHarfe(sonucVektor[i]);
            }

       
            duzMetin = duzMetin.TrimEnd('A');

            return duzMetin;
        }


        private int[,] MatrisTersiBul(int[,] A)
        {
 
            int det = A[0, 0] * (A[1, 1] * A[2, 2] - A[1, 2] * A[2, 1])
                    - A[0, 1] * (A[1, 0] * A[2, 2] - A[1, 2] * A[2, 0])
                    + A[0, 2] * (A[1, 0] * A[2, 1] - A[1, 1] * A[2, 0]);

            int detMod = ((det % MOD) + MOD) % MOD;

      
            int detTers = CarpımsalTersBul(detMod, MOD);

            if (detTers == -1)
            {
                MessageBox.Show($"Determinant ({detMod}) ile mod {MOD} aralarında asal değil!\nBu anahtar matris için ters matris bulunamaz.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            int[,] kofaktor = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   
                    int minorDet = MinorHesapla(A, i, j);

                    
                    int isaretli = ((i + j) % 2 == 0) ? minorDet : -minorDet;

                    kofaktor[i, j] = isaretli;
                }
            }

            int[,] adjugate = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    adjugate[i, j] = kofaktor[j, i];

            int[,] tersMatris = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tersMatris[i, j] = ((detTers * adjugate[i, j]) % MOD + MOD) % MOD;

            return tersMatris;
        }

     

        private int MinorHesapla(int[,] A, int silSatir, int silSutun)
        {
      
            int[] satirlar = new int[2];
            int[] sutunlar = new int[2];

            int si = 0;
            for (int i = 0; i < 3; i++)
            {
                if (i == silSatir) continue;
                satirlar[si++] = i;
            }

            int sj = 0;
            for (int j = 0; j < 3; j++)
            {
                if (j == silSutun) continue;
                sutunlar[sj++] = j;
            }

            // 2x2 determinant: ad - bc
            return A[satirlar[0], sutunlar[0]] * A[satirlar[1], sutunlar[1]]
                 - A[satirlar[0], sutunlar[1]] * A[satirlar[1], sutunlar[0]];
        }

        private int CarpımsalTersBul(int a, int m)
        {
            
            for (int x = 1; x < m; x++)
                if ((a * x) % m == 1)
                    return x;
            return -1;
        }


        private int HarftenSayiya(char harf)
        {
            for (int i = 0; i < ALFABE.Length; i++)
                if (ALFABE[i] == harf) return i;
            return -1;
        }

       
        private char SayidanHarfe(int sayi)
        {
            return ALFABE[sayi % MOD];
        }
    }
}