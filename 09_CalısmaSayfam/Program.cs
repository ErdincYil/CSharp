using System.Numerics;
using System.Threading.Channels;

namespace _09_CalısmaSayfam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calısma

            #region BasitAlıştırma(1)
            //Console.WriteLine("Lütfen Sayı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi < 10)
            //{
            //    Console.WriteLine("Sayı 10'dan Küçük");
            //}
            //else if (sayi > 10)
            //{
            //    Console.WriteLine("Sayı 10'dan Büyük");
            //}
            //else
            //{
            //    Console.WriteLine("Sayınız 10");
            //}
            #endregion

            #region BasitAlıştırma(2)
            //Console.WriteLine("Lütfen Adınızı Girin");
            //string ad = Console.ReadLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(ad);
            //}
            #endregion

            #region BasitAlıştırma(3)
            //for(int i=1; i<=20; i++)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region BasitAlıştırma(4)
            //for(int i=1;i<=50;i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 1'den 30'a kadar sayılar içinde 3'ün katı olanların kaç tane olduğunu ekrana yaz.
            //int adet = 0;
            //for(int i=1; i<=30;i++)
            //{
            //    if(i%3==0)
            //    {
            //        adet++;
            //    }
            //}
            //Console.WriteLine("3'ün katı sayısı: " + adet);
            #endregion

            #region Kullanıcıdan bir üst sınır al. 1'den o sayıya kadar 7'nin katlarının kaç tane olduğunu yaz.
            //int adet = 0;
            //Console.WriteLine("Lütfen kaç tane 7'nin katı olduğunu merak ettiğiniz sayıyı giriniz");
            //int sınır = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<=sınır;i++)//i=0 olursa onu da adete ekler ondan adet 1 fazla çıkar
            //{
            //    if(i%7==0)
            //    {
            //        adet++;
            //    }

            //}
            //Console.WriteLine("7'nin katı sayısı:"+adet);
            #endregion

            #region Kullanıcıdan sayı al.1'den o sayıya kadar hem 2'ye hem 3'e bölünen sayıların kaç tane olduğunu yaz.
            //int adet = 0;
            //Console.WriteLine("Lütfen Üst Sınırı Giriniz");
            //int sınır = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<=sınır;i++)
            //{
            //    if (i % 2 == 0 && i % 3 == 0)
            //    {
            //        adet++;
            //    }
            //}
            //Console.WriteLine("2 ve 3'e bölünen sayı adedi: " + adet);            
            #endregion

            #region Kullanıcıdan bir üst sınır al. 1'den o sayıya kadar 5'in katı olan sayıların toplamını yaz.
            //int toplam = 0;
            //Console.WriteLine("ÜSt Sınır Girin");
            //int sınır = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<=sınır;i++)
            //{
            //    if(i%5==0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);
            #endregion

            #region Çarpmaİşlemi

            //Console.WriteLine("Lütfen bir sayı girin:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hangi sayıya kadar çarpılmasının istiyorsunuz?");
            //int limit = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //while (i <= limit)
            //{
            //    Console.WriteLine(sayi + " x " + i + " = " + i * sayi);
            //    i++;
            //}

            //for (i = 1; i <= limit; i++)
            //{
            //    Console.WriteLine(sayi + " x " + i + " = " + i * sayi);
            //}

            #endregion

            #region FaktoriyelHesaplama

            //Console.WriteLine("Lütfen Sayı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktoriyel = 1;

            //while (sayi >= 1)
            //{
            //    faktoriyel = faktoriyel * sayi;
            //    sayi--;
            //}
            //Console.WriteLine(faktoriyel);

            #endregion

            #region ÜsAlma
            //Console.WriteLine("Üssü Alınacak Sayıyı Girin");
            //int alt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Üssü Giriniz");
            //int üs = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;

            //for(int i=1; i<=üs;i++)
            //{
            //    sonuc = sonuc * alt;
            //}
            //Console.WriteLine(sonuc);
            #endregion

            #region Fibonacci(Kuramadım)

            //Console.WriteLine("Fibonacci Adım Sayısını Girin");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //int onceki = 1;
            //int simdiki = 1;

            //for (int i=1;i<=adet;i++)
            //{
            //    Console.WriteLine(onceki);

            //    int yeni = onceki + simdiki;

            //    onceki = simdiki;
            //    simdiki = yeni;
            //}

            #endregion

            #region Fibonacci
            //int ilk = 1;
            //int iki = 1;
            //Console.WriteLine("Lütfen fibonacci adım sayısnı girin");
            //int adım = Convert.ToInt32(Console.ReadLine());
            //for(int i=0;i<adım;i++)
            //{
            //    Console.WriteLine(ilk);
            //    int yeni = ilk + iki;
            //    ilk = iki;
            //    iki = yeni;
            //}

            #endregion

            #region Tribonacci(Sadece Değişkenleri Uyarladım)

            //Console.WriteLine("Fibonacci Adım Sayısını Girin");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //int ilk = 1;
            //int iki = 1;
            //int üc = 1;

            //for (int i = 1; i <= adet; i++)
            //{
            //    Console.WriteLine(ilk);

            //    int yeni = ilk + iki + üc;

            //    ilk = iki;
            //    iki = üc;
            //    üc = yeni;
            //}

            #endregion

            #region Üst sınır al. 1'den o sayıya kadar çift sayıların toplamını ve tek sayıların toplamını ayrı yaz.
            //int tektoplam = 0;
            //int cifttoplam = 0;
            //Console.WriteLine("Lütfen Bir Sınır Girin");
            //int sınır = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<=sınır;i++)
            //{
            //    if(i%2==0)
            //    {
            //        cifttoplam += i;
            //    }
            //    else
            //    {
            //        tektoplam += i;
            //    }
            //}
            //Console.WriteLine("Çift Sayıların Toplamı:"+cifttoplam);
            //Console.WriteLine("Tek Sayıların Toplamı:"+tektoplam);
            #endregion

            #region Alışveriş Sepeti
            //int adet = 0;
            //double toplam = 0;
            //while(true)
            //{
            //    Console.WriteLine("Lütfen aldığınız ürünün fiyatını giirniz");
            //    double fiyat = Convert.ToDouble(Console.ReadLine());
            //    if(fiyat>0)
            //    {
            //        adet++;
            //        toplam=toplam+fiyat;
            //    }
            //    else if(fiyat<0)
            //    {
            //        Console.WriteLine("Lütfen Geçerli Bir Fiyat Giriniz");
            //        continue;//Burada yazmamıza gerek yok ama kullanımı doğru
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Aldığınız Ürün Miktarı:"+adet);
            //Console.WriteLine("Ürünlerinizin Fiyatı:"+toplam);
            #endregion

            #region Ders adı ve notunu girsin.Ders adı olarak “çıkış” yazılınca giriş bitsin. Sonunda ders sayısını, not ortalamasını ve en yüksek notu yazdır.

            //int derssayisi = 0;
            //double toplam = 0;

            //while (true)
            //{
            //    Console.WriteLine("Lütfen Ders Adını Girin(Bitirmek için cikis yazınız):");
            //    string dersad = Console.ReadLine();
            //    if (dersad.ToLower() == "cikis")
            //    {
            //        Console.WriteLine("Ders Sayısı:" + derssayisi);
            //        if (derssayisi > 0)
            //        {
            //            Console.WriteLine("****HESAPLANIYOR****");
            //            Console.WriteLine("Ders Sayısı:" + derssayisi);
            //            Console.WriteLine("Not Ortalaması:" + toplam / derssayisi);
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen Sınav notunuzuzu girin:");
            //        double sınavnotu = Convert.ToDouble(Console.ReadLine());
            //        toplam = toplam + sınavnotu;
            //        derssayisi++;
            //    }
            //}

            #endregion

            #region Dikdörtgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Sayılardan oluşan dikdörtgen
            //for(int i=1;i<=4;i++)
            //{
            //    for(int j=1;j<=6;j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Sayılı dik üçgen

            //for(int i=1;i<=5;i++)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //Ters Döngü Hali

            //for(int i=5;i>=1;i--)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Çarpım tablosu (iç içe)
            //for(int i=1;i<=5;i++)
            //{
            //    for (int j=1;j<=5;j++)
            //    {
            //        Console.Write(i*j+" ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Sağa Dayalı Üçgen

            //for(int i=1;i<=5;i++)
            //{
            //    for(int j=1;j<=5-i;j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1;k<=i;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

        }
    }
}
