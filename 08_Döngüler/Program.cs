using System.ComponentModel;

namespace _08_Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler: Belirli bir işlevi veya işlem kodunu tekrarlı çalıştırmayı sağlar. Bir koşula bağlı olarak(Koşul true olduğu sürece) kod bloğunu tekrar tekrar çalıştırır.
            //1-10 aralığındaki sayıları alt alta ekrana yazdırınız.
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

            #endregion

        }
    }
}
