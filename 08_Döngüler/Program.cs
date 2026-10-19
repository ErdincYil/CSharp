using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace _08_Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler: Belirli bir işlevi veya işlem kodunu tekrarlı çalıştırmayı sağlar. Bir koşula bağlı olarak(Koşul true olduğu sürece) kod bloğunu tekrar tekrar çalıştırır.

            #region *****While Döngüsü*****

            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;              //Bu satır olmadan her zaman 1 yazar durmaksızın. Bu satırda tabii kuralları değiştirebiliriz.
            //}
            #region //250-50 aralığındaki sayıları ekrana yazdır

            //int a = 250;
            //while(a>=50)
            //{
            //    Console.WriteLine(a);
            //    a--;
            //}

            #endregion

            #region 250-50 aralığındaki 3'ün katı olan sayıları ekrana yazdırınız

            //int a = 250;
            //while(a>0)
            //{
            //    if(a%3==0 && a>50)
            //    {
            //        Console.WriteLine(a);
            //    }
            //    a--;
            //}

            #endregion

            #region Kullanıcıdan başlangıç ve bitiş sayısı al önce bu sayıları yazdır sonra 2 ye ve 3 e bölünen sayıları sırayla ayrı ayrı yazdır.


            //Console.WriteLine("Lütfen Başlangıç Sayısını Girin:");
            //int basi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen Bitiş Sayısını Girin:");
            //int soni = Convert.ToInt32(Console.ReadLine());

            //if (basi <= soni)
            //{
            //    int sayac = basi;
            //    int adet = 0;

            //    while (sayac <= soni)
            //    {
            //        Console.WriteLine(sayac);
            //        adet++;
            //        sayac++;
            //    }

            //    Console.WriteLine("Tüm Sayılar adeti = " + adet);

            //    sayac = basi;
            //    adet = 0;

            //    while (sayac <= soni)
            //    {
            //        if (sayac % 2 == 0)
            //        {
            //            Console.WriteLine(sayac);
            //            adet++;
            //        }

            //        sayac++;
            //    }

            //    Console.WriteLine("Sadece Çift Sayılar adeti = " + adet);

            //    sayac = basi;
            //    adet = 0;

            //    while (sayac <= soni)
            //    {
            //        if (sayac % 3 == 0)
            //        {
            //            Console.WriteLine(sayac);
            //            adet++;
            //        }

            //        sayac++;
            //    }

            //    Console.WriteLine("Sadece 3'e Bölünebilen Sayıların Adeti = " + adet);
            //}
            //else
            //{
            //    int sayac = basi;
            //    int adet = 0;

            //    while (sayac >= soni)
            //    {
            //        Console.WriteLine(sayac);
            //        adet++;
            //        sayac--;
            //    }

            //    Console.WriteLine("Tüm Sayılar adeti = " + adet);

            //    sayac = basi;
            //    adet = 0;

            //    while (sayac >= soni)
            //    {
            //        if (sayac % 2 == 0)
            //        {
            //            Console.WriteLine(sayac);
            //            adet++;
            //        }

            //        sayac--;
            //    }

            //    Console.WriteLine("Sadece Çift Sayılar adeti = " + adet);

            //    sayac = basi;
            //    adet = 0;

            //    while (sayac >= soni)
            //    {
            //        if (sayac % 3 == 0)
            //        {
            //            Console.WriteLine(sayac);
            //            adet++;
            //        }

            //        sayac--;
            //    }

            //    Console.WriteLine("Sadece 3'e Bölünebilen Sayıların Adeti = " + adet);
            //}

            #endregion

            #region 1-10 aralığındaki sayıların toplamını yazdır

            //int i = 1;
            //int toplam = 0;//Başlangıç değeri verilmezse ilk sayının toplanmasında hata alırız
            //while(i<11)
            //{
            //    toplam = toplam + i;
            //    i++;
            //}
            //Console.WriteLine("Toplam:"+toplam);

            #endregion

            #region 1-100 aralığındaki tek sayıları ayrı çift sayıları ayrı toplayarak ekrana yazdırınız

            //int sayi = 1;
            //int cifttoplam = 0;
            //int tektoplam = 0;

            //while (sayi < 101)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        cifttoplam = cifttoplam + sayi;

            //    }
            //    else
            //    {
            //        tektoplam = tektoplam + sayi;
            //    }
            //    sayi++;

            //}
            //Console.WriteLine("Tek Sayıların Toplamı:" + tektoplam);
            //Console.WriteLine("Çek Sayıların Toplamı:" + cifttoplam);


            #endregion

            #region 1-100 aralığındaki tek sayıları ayrı çift sayıları ayrı toplayarak ekrana yazdırınız

            //int sayi = 1;
            //int cifttoplam = 0;
            //int tektoplam = 0;

            //while (sayi < 101)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        cifttoplam = cifttoplam + sayi;

            //    }
            //    else
            //    {
            //        tektoplam = tektoplam + sayi;
            //    }
            //    sayi++;

            //}
            //Console.WriteLine("Tek Sayıların Toplamı:" + tektoplam);
            //Console.WriteLine("Çek Sayıların Toplamı:" + cifttoplam);


            #endregion

            #region Sonsuz Döngü

            //while (1 == 1)

            //while (true)
            //{
            //    Console.WriteLine("Bir Sayı Gir");
            //    int sayi= Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(sayi);
            //}

            #endregion

            #region 1-100 aralığındaki sayıalrın toplamını ekrana yazdırınız
            //Sayı 7'nin katı ise toplama dahil edilmesin.
            //Sayının 3 katının 7 fazlası 37'nin katıysa toplama işlemi bitsin.

            //int i = 1;
            //int toplam = 0;

            //while(i<=100)
            //{
            //    if (i%7==0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    if((i*3+7)%37==0)
            //    {
            //        break;
            //    }
            //    toplam = toplam + i;
            //    i++;
            //}
            //Console.WriteLine(toplam);

            #endregion

            #region Kullanıcıdan 0 girilene kadar pozitif sayılar girmesini isteyin
            //0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın 
            //Kullanıcı 0 girdiğinde döngü bitsin ve toplam, ortalama ekrana yazdırılsın
            //Kullanıcı negatif sayı girdiğinde pozitif girmesini iste.

            //int toplam = 0;
            //int adet = 0;
            //int ortalama = 0;

            //while(true)
            //{
            //    Console.Write("Bir Sayı Giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi < 0)
            //    {
            //        Console.Write("Lütfen Pozitif Bir Sayı Giriniz");
            //    }
            //    else if (sayi > 0)
            //    {
            //        toplam = toplam + sayi;
            //        adet++;
            //        continue;
            //    }
            //    else if (sayi ==0)
            //    {
            //        ortalama=toplam/adet;
            //        break;
            //    }
            //}
            //Console.WriteLine("Sayıların Ortalaması:" + ortalama);


            #endregion

            #region Break ve Contıune
            //break: Döngünün koşul dışında bir sebebten kırılmasını istiyorsak kullanılır.

            //int i = 1;
            //while(i<22)
            //{
            //    Console.WriteLine(i);
            //    if (i == 7)
            //    {
            //        break;//Kendi içinde bulunduğu döngüyü bitirir
            //    }
            //    i++;
            //}

            //Contunıe: Döngü countinue komutunu okuduğu satırdan koşul satırına geri döner.

            //int i = 1;
            //while (i < 22)
            //{
            //    Console.WriteLine(i);
            //    if (i == 7)
            //    {
            //        i++;
            //        Console.WriteLine("7 deyiz");
            //        continue;
            //    }
            //    i++;
            //}


            #endregion

            #endregion

            #region *****For*****

            //int i = 0;

            //while(i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = 0; i < 10; i++ )
            //{
            //    Console.WriteLine(i);
            //}

            #region Başlangıç ve bitiş değerini kullanıcıdan aldığımız ve aralıktaki sayıalrı ekrana yazdırdığınız for döngüsü

            //Console.WriteLine("Başlangıç Değerini Veriniz");
            //int basi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş Değerini Veriniz");
            //int soni=Convert.ToInt32(Console.ReadLine());

            //if(basi>soni)
            //{ 
            //    int temp= basi;
            //    basi= soni;
            //    soni = temp;
            //}

            //for (int i=basi;i<=soni;i++)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Kullanıcının girmiş olduğu sayının faktöriyelini hesaplyan for döngüsü
            //int sonuc = 1;
            //Console.WriteLine("Faktöriyelini öğrenmek istediğiniz sayıyı girin");
            //int sınır = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<=sınır;i++)
            //{
            //    sonuc = sonuc * i;
            //}
            //Console.WriteLine(sonuc);
            #endregion

            #region 1-500 Aralığındaki 13'ün katı oladn kaç adet sayı vardır ve toplamları nedir
            //int adet = 0;
            //int toplam = 0;
            //for(int i=1;i<=500;i++)
            //{
            //    if(i%13==0)
            //    {
            //        adet++;
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("500'e kadar 13'ün katı olan sayı sayısı:"+adet);
            //Console.WriteLine("500'e kadar 13'ün katı olan sayıların toplamı:"+toplam);

            #endregion

            #endregion

            #region *****RANDOM*****
            //Belirtilen aralıkta rastgele int tipinde sayı üretir

            //Random a = new Random(); //Random kılasında bir nesne(örneklem) üretildi 
            //int rastgele=a.Next();
            //int rastgele=a.Next(100);//Belirlediğimiz sınıra kadar rastgele sayı dödürür
            //int rastgele=a.Next(5,7);//Belirlediğimiz aralıkta rastgele sayı oluşturur
            //Console.WriteLine(rastgele);

            #region Bilgisayar 1-100 aralığında rastgele bir sayı üretsin.KUllanıcı 5 hakta bu sayıyı tahmin etmeye çalışsın.Bu haklarda "Lütfen tahmininizi büyültünüz" veya "Lütfen tahmininizi Küçültünüz"gibi yönelndirmeler yapılsın 5 hakkı bittiğinde hakkınız bitti mesajı yazdırılsın
            //int hak = 5;
            //Random i = new Random();
            //int sayi = i.Next(1, 101);

            //for(int hak = 0; hak < 5; hak++)
            //{
            //    Console.WriteLine("Lütfen Tahminizi Girin");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin == sayi)
            //    {
            //        Console.WriteLine("Doğru Tahmin ettiniz");
            //        break;
            //    }
            //    else if (hak==4)
            //    {
            //        Console.WriteLine("Hakkınız Bitti");
            //        break;
            //    }
            //    else if (tahmin < sayi)
            //    {
            //        Console.WriteLine("Tahmininizi Yükseltin");
            //    }
            //    else if (tahmin > sayi)
            //    {
            //        Console.WriteLine("Tahmininizi Düşürün"); 
            //    }  
            //}


            //while(true)
            //{
            //    Console.WriteLine("Lütfen Tahminizi Girin");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (hak > 0)
            //    {
            //        if (tahmin < sayi)
            //        {
            //            Console.WriteLine("Tahmininizi Yükseltin");
            //            hak--;
            //        }
            //        else if (tahmin > sayi)
            //        {
            //            Console.WriteLine("Tahmininizi Düşürün");
            //            hak--;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Doğru Tahmin ettiniz");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hakkınız Bitti");
            //        break;
            //    }
            //}


            #endregion
            #endregion

            
            //Dik Üçgen
            //for(int i=1;i<8;i++)
            //{
            //    for(int j=i;j>0;j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            
            //Kare
            //for(int i=0;i<7;i++)
            //{
            //    if(i==0||i==6)
            //    {
            //        Console.WriteLine("***************");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*              *");
            //    }
            //}

            
            //İçi Dolu Üçgen
            //int bosluk = 10;
            //for(int i =1;i<12;i+=2)
            //{
            //    for(int j=0;j<bosluk;j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int yıldız=0;yıldız<i;yıldız++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    bosluk--;
            //}

            
            //Kum Saati
            //int bosluk = 0;
            //for (int i = 13; i > 0; i -= 2)
            //{
            //    for (int j = bosluk; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int yıldız = i; yıldız >0; yıldız--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    bosluk++;
            //}
            //int bosluk2 = 6;
            //for (int i = 1; i < 12; i += 2)
            //{
            //    for (int j = 0; j < bosluk2; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int yıldız = 0; yıldız < i; yıldız++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    bosluk2--;
            //}


            //Çarpım Tablosu Yapılacak
        }
    }
}
