using System.ComponentModel.Design;

namespace _06_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BANKAMATİK
            //            /*   
            //             *   25000 tl parası olacak 
            //            Bir bankamatik düşünülerek tasarlanacak bir program  için 
            //            Kartlı işlem    1
            //            Kartsız işlem   2
            //            //********Kartlı işlem bölümü
            //            Şifre istenecek=> Şifre:ab18
            //            ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
            //            //*******************Ana Menü 
            //            Para Çekmek için    1
            //            Para yatırmak için  2
            //            Para Transferleri   3
            //            Eğitim Ödemeleri    4
            //            Ödemeler            5
            //            Bilgi Güncelleme    6
            //            //*********************Seçim 1************
            //            Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
            //            Ana meüye dönmek için   9
            //            Çıkmak için             0
            //            //******************Seçim 2***********************
            //            Kredi Kartına   1
            //            Kendi Hesabınıza yatırmak için  2
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //------------------------------------
            //            //----1
            //            Kredi kardı için en az 12 haneli kart numarasını girsin
            //            bakiye yeterli ise hesaptan kredi kartına para yatırılaca
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //--------------------------
            //            //---2
            //            hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //*****************************Seçim 3
            //            Başka Hesaba EFT    1
            //            Başka Hesaba Havale 2
            //            //---------------------------------
            //            //--1
            //            EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            //            yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //-----------------------------
            //            //---2
            //            hesap için 11 haneli hesap numarası işlemler doğru ise
            //            gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //****************Seçim 4
            //            Eğitim Ödemeleri sayfası arızalı
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //****************************Seçim 5
            //            Elektrik Faturası       1
            //            Telefon Faturası        2
            //            İnternet faturası       3
            //            Su Faturası             4
            //            OGS Ödemeleri           5
            //            //-----------------------------------------
            //            //---1 => bütün faturala için aşağıdaki şart yeterli
            //            fatura tutarı istenir, hesap uygun ise yatırılır değilse
            //            Ana Menü        9
            //            Çıkmak için     0
            //            //-----------------------------------
            //            //***************Seçim 6
            //            Şifre değiştirmek için 1
            //            Şifre değiştirme işlemi gerçekleştirilir
            //            Ana Menü        9
            //            Çıkmak için     0



            //            //********Kartsız işlem bölümü

            //            //*******************Ana Menü 
            //            CepBank Para Çekmek 1
            //             Para yatırmak için  2
            //             Kredi Kartı Ödeme   3
            //             Eğitim Ödemeleri    4
            //             Ödemeler            5

            //             //*********************Seçim 1************
            //             TC kimlik no ve cep telefonu numarasını girsin doğruysa kişiye 1000 ödeme
            //             Yapın yanlış ise 3 kere daha denetin Hakkı bittiğinde 1 saat kilitleyin.
            //Ana menüye dönmek için   9
            //             Çıkmak için              0
            //             //******************Seçim 2***********************
            //             Nakit ödeme     1
            //             Hesaptan ödeme  2
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //------------------------------------
            //             //----1
            //          Kredi kartı için en az 12 haneli kart numarasını girsin

            //          Tc kimlik numarasını girsin. 11 hane olup olmadığını kontrol edin.
            //             Nakit olarak ödeme gerçekleştirin.
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //--------------------------
            //             //---2
            //             Kredi kartı için en az 12 haneli kart numarasını girsin
            // Hesap numarasını girsin

            //             Ana Menü        9
            //             Çıkmak için     0
            //             //*****************************Seçim 3
            //             Başka Hesaba EFT    1
            //             Başka Hesaba Havale 2
            //             //---------------------------------
            //             //--1
            //             EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            //             yatılacak para istenir, hesap uygun ise işlem gerçekleşir değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //-----------------------------
            //             //---2
            //             hesap için 11 haneli hesap numarası işlemler doğru ise
            //             gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************Seçim 4
            //             Eğitim Ödemeleri sayfası arızalı
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************************Seçim 5
            //             Elektrik Faturası       1
            //             Telefon Faturası        2
            //             İnternet faturası       3
            //             Su Faturası             4
            //             OGS Ödemeleri           5
            //             //-----------------------------------------
            //             //---1 => bütün faturala için aşağıdaki şart yeterli
            //             fatura tutarı istenir, hesap uygun ise yatırılır değilse
            //            */
            #endregion

            //long.TryParse(): Girilen string değerin tamamen sayılardan oluşup oluşmadığını kontrol
            //Substring: String bir değeri parçalara ayırır.

            #region BenimBankamatik

            int bakiye = 25000;
            string password = "ab18";
            int hak = 3;
        Bankamatik:

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi belirleyiniz");
            Console.WriteLine("Kartlı işlem için 1'e basınız");
            Console.WriteLine("Kartsız işlem için 2'ye basınız");
            int islem = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                Console.WriteLine("Kartlı İşlem Menüsünü Seçtiniz");
                Console.WriteLine("Şifre Bölümüne Aktarılıyorsunuz");
            Sifre:
                if (hak > 0)
                {
                    Console.WriteLine("Şifre:");
                    string sifre = Console.ReadLine();
                    if (sifre == password)
                    {
                        Console.WriteLine("Şifre Doğru Ana Menüye Aktarılıyorsunuz");
                        hak = 3;
                    AnaMenu:
                        Console.WriteLine("------Ana Menü-------");
                        Console.WriteLine("Bakiyeniz:"+bakiye);
                        Console.WriteLine("Para Çekmek için    1");
                        Console.WriteLine("Para yatırmak için  2");
                        Console.WriteLine("Para Transferleri   3");
                        Console.WriteLine("Eğitim Ödemeleri    4");
                        Console.WriteLine("Ödemeler            5");
                        Console.WriteLine("Bilgi Güncelleme    6");
                        int secim = Convert.ToInt32(Console.ReadLine());

                        if (secim == 1)
                        {
                        Cekim:
                            Console.WriteLine("Çekmek istediğiniz Tutarı Giriniz.En Az 10Tl Çekebilirsiniz");
                            Console.WriteLine("Ana Menüye Dönmek İçin 9'a Basınız");
                            int cekim = Convert.ToInt32(Console.ReadLine());
                            if (cekim == 9)
                            {
                                Console.WriteLine("Ana Menüye Aktarılıyorsunuz");
                                goto AnaMenu;
                            }
                            else if (cekim < 10)
                            {
                                Console.WriteLine("En Az 10TL Çekim İşlemi Yapabilirsiniz");
                                goto Cekim;
                            }
                            else if (cekim > bakiye)
                            {
                                Console.WriteLine("Çekmek istediğiniz Tutar Bakiyenizden Yüksek");
                                goto Cekim;
                            }
                            else if (cekim <= bakiye && cekim >= 10)
                            {
                                bakiye = bakiye - cekim;
                                Console.WriteLine("Paranızı Alabilirsiniz");
                                goto AnaMenu;
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Geçerli Bir Miktar Girin");
                                goto Cekim;
                            }
                        }
                        else if (secim == 2)
                        {
                        Tus2:
                            Console.WriteLine("Hangi Hesaba Para Yatıracağınız Seçin");
                            Console.WriteLine("Kredi Kartına                       1");
                            Console.WriteLine("Kendi Hesabınıza yatırmak için      2");
                            Console.WriteLine("Ana Menü                            9");
                            Console.WriteLine("Çıkmak için                         0");
                            int tus2 = Convert.ToInt32(Console.ReadLine());
                            if (tus2 == 0)
                            {
                                Console.WriteLine("Çıkış Yapılıyor");
                            }
                            else if (tus2 == 9)
                            {
                                Console.WriteLine("Ana Menüye Dönülüyor");
                                goto AnaMenu;
                            }
                            else if (tus2 == 1)
                            {
                            kartno:
                                Console.WriteLine("Lütfen en az 12 haneli Kredi Kartı Numaranızı Girin");
                                Console.WriteLine("Ana Menü                                    9");
                                Console.WriteLine("Çıkmak için                                 0");
                                string kartno = Console.ReadLine();
                                if (kartno == "9")
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if (kartno == "0")
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }
                                else if (kartno.Length <= 16 && long.TryParse(kartno, out _))
                                {
                                Yatırma:
                                    Console.WriteLine("Kart Numarası Doğru");
                                    Console.WriteLine("Yatırmak istediğiniz Tutarı Girin");
                                    Console.WriteLine("Ana Menü                        9");
                                    Console.WriteLine("Çıkmak için                     0");
                                    int yatan = Convert.ToInt32(Console.ReadLine());
                                    if (yatan == 0)
                                    {
                                        Console.WriteLine("Çıkış Yapılıyor");
                                    }
                                    else if (yatan == 9)
                                    {
                                        Console.WriteLine("Ana Menüye Dönülüyor");
                                        goto AnaMenu;
                                    }
                                    else if (yatan <= bakiye && yatan>0)
                                    {
                                        Console.WriteLine("Kredi Kartına Para Yatırılmıştır");
                                        bakiye = bakiye - yatan;
                                        Console.WriteLine(bakiye);
                                        goto AnaMenu;
                                    }
                                    else if (yatan > bakiye)
                                    {
                                        Console.WriteLine("Yatırmak İstediğiniz Tutar Bakiyenizden Fazla Lütfen Tekrar Deneyin");
                                        goto Yatırma;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lütfen Geçerli Bir Miktar Giriniz");
                                        goto Yatırma;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen Geçerli Bir Kart Numarası Giriniz");
                                    goto kartno;
                                }
                            }
                            else if (tus2 == 2)
                            {
                            Mıktar:
                                Console.WriteLine("Lütfen Yatırmak İstedğiniz Tutarı Girin");
                                Console.WriteLine("Ana Menü                              9");
                                Console.WriteLine("Çıkmak için                           0");
                                int mıktar= Convert.ToInt32(Console.ReadLine());
                                if(mıktar==0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }
                                else if(mıktar==9)
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if(mıktar>0)
                                {
                                    Console.WriteLine("Hesabınıza Para Yatırılıyor");
                                    Console.WriteLine(bakiye=bakiye+mıktar);
                                    goto AnaMenu;
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen Geçerli Bir Miktar Giriniz");
                                    goto Mıktar;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Geçerli Bir İşlem Giriniz");
                                goto Tus2;
                            }
                        }
                        else if (secim == 3)
                        {
                        ParaTransferi:
                            Console.WriteLine("Başka Hesaba EFT    1");
                            Console.WriteLine("Başka Hesaba Havale 2");
                            Console.WriteLine("Ana Menü            9");
                            Console.WriteLine("Çıkmak için         0");
                            int tus3= Convert.ToInt32(Console.ReadLine());
                            if(tus3==1) 
                            {
                                Console.WriteLine("EFT Numarasını Giriniz");
                                Console.WriteLine("Ana Menü             9");
                                Console.WriteLine("Çıkmak için          0");
                                string EFT=Console.ReadLine().ToUpper();//tr küçük olursa sıkıntı çıkmasın diye otomatik büyük yazdırıyoruz
                                if (EFT=="0")
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }
                                else if(EFT=="9")
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if (EFT.StartsWith("TR") && EFT.Length == 14 && long.TryParse(EFT.Substring(2), out _))
                                {
                                EFT:
                                    Console.WriteLine("Geçerli EFT Numarası");
                                    Console.WriteLine("Göndermek İstediğiniz Tutarı Girin:");
                                    Console.WriteLine("Ana Menü                          9");
                                    Console.WriteLine("Çıkmak için                       0");
                                    int gideneft=Convert.ToInt32(Console.ReadLine());
                                    if (gideneft == 0)
                                    {
                                        Console.WriteLine("Çıkış Yapılıyor");
                                    }
                                    else if (gideneft == 9)
                                    {
                                        Console.WriteLine("Ana Menüye Dönülüyor");
                                        goto AnaMenu;
                                    }
                                    else if (gideneft>bakiye)
                                    {
                                        Console.WriteLine("Lütfen Bakiyenizden Fazla Miktar Girmeyiniz");
                                        goto EFT;
                                    }
                                    else if(gideneft<=bakiye && gideneft>0)
                                    {
                                        Console.WriteLine("EFT Gönderilmiştir");
                                        Console.WriteLine(bakiye = bakiye - gideneft);
                                        goto ParaTransferi;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lütfen Geçerli Bir Miktar Yazınız");
                                        goto EFT;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz EFT Numarası");
                                    goto ParaTransferi;
                                }
                            }
                            else if(tus3==2)
                            {
                            HesapNo:
                                Console.WriteLine("11 Haneli Hesap Numarasını Giriniz");
                                Console.WriteLine("Ana Menü                         9");
                                Console.WriteLine("Çıkmak için                      0");
                                string hesapno=Console.ReadLine();
                                if (hesapno == "0")
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }
                                else if (hesapno == "9")
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if (hesapno.Length == 11 && long.TryParse(hesapno, out _))
                                {
                                Havale:
                                    Console.WriteLine("Geçerli Hesap Numarası");
                                    Console.WriteLine("Göndermek İstediğiniz Tutarı Girin:");
                                    Console.WriteLine("Ana Menü                          9");
                                    Console.WriteLine("Çıkmak için                       0");
                                    int gidenhavale = Convert.ToInt32(Console.ReadLine());
                                    if (gidenhavale == 0)
                                    {
                                        Console.WriteLine("Çıkış Yapılıyor");
                                    }
                                    else if (gidenhavale == 9)
                                    {
                                        Console.WriteLine("Ana Menüye Dönülüyor");
                                        goto AnaMenu;
                                    }
                                    else if (gidenhavale > bakiye)
                                    {
                                        Console.WriteLine("Lütfen Bakiyenizden Fazla Miktar Girmeyiniz");
                                        goto Havale;
                                    }
                                    else if (gidenhavale <= bakiye && gidenhavale>0)
                                    {
                                        Console.WriteLine("Havale Gönderilmiştir");
                                        Console.WriteLine(bakiye = bakiye - gidenhavale);
                                        goto ParaTransferi;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lütfen Geçerli Bir Miktar Yazınız");
                                        goto Havale;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Hesap numarası tam 11 haneli ve sadece sayılardan oluşmalıdır.");
                                    goto HesapNo;
                                }
                            }
                            else if (tus3 == 9)
                            {
                                Console.WriteLine("Ana Menüye Dönülüyor");
                                goto AnaMenu;
                            }
                            else if (tus3 == 0)
                            {
                                Console.WriteLine("Çıkış Yapılıyor");
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                                goto ParaTransferi;
                            }
                        }
                        else if (secim == 4)
                        {
                        Sec4:
                            Console.WriteLine("Eğitim Ödemeleri Sayfası Arızalıdır.");
                            Console.WriteLine("Ana Menü        9");
                            Console.WriteLine("Çıkmak için     0");
                            int cıktı=Convert.ToInt32(Console.ReadLine());
                            if(cıktı==9)
                            {
                                Console.WriteLine("Ana Menüye Dönülüyor");
                                goto AnaMenu;
                            }
                            else if(cıktı==0)
                            {
                                Console.WriteLine("Çıkış Yapılıyor");
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Geçerli Bir Sayı Girin");
                                goto Sec4;
                            }
                        }
                        else if (secim == 5)
                        {
                        Odeme:
                            Console.WriteLine("Lütfen Yapmak İstediğiniz Ödemeyi Seçiniz");
                            Console.WriteLine("Elektrik Faturası       1");
                            Console.WriteLine("Telefon Faturası        2");
                            Console.WriteLine("İnternet faturası       3");
                            Console.WriteLine("Su Faturası             4");
                            Console.WriteLine("OGS Ödemeleri           5");
                            Console.WriteLine("Ana Menü                9");
                            Console.WriteLine("Çıkmak için             0");
                            int ödeme=Convert.ToInt32(Console.ReadLine());
                            if (ödeme==1)
                            {
                            Efo:
                                Console.WriteLine("Elektrik Fatura Tutarını Giriniz:");
                                Console.WriteLine("Ana Menü                        9");
                                Console.WriteLine("Çıkmak için                     0");
                                int efo=Convert.ToInt32(Console.ReadLine());
                                if (efo==0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }
                                
                                else if (efo==9)
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if(efo>bakiye)
                                {
                                    Console.WriteLine("Yetersiz Bakiye");
                                    goto AnaMenu;
                                }
                                else if(efo<=bakiye && efo > 0)
                                {
                                    Console.WriteLine("Ödeme Alınıyor Yeni Bakiye");
                                    Console.WriteLine(bakiye=bakiye-efo);
                                    goto Efo;
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen Geçerli Bir Miktar Giriniz");
                                    goto Efo;
                                }
                            }
                            else if (ödeme==2)
                            {
                            Tft:
                                Console.WriteLine("Telefon Fatura Tutarını Giriniz:");
                                Console.WriteLine("Ana Menü                        9");
                                Console.WriteLine("Çıkmak için                     0");
                                int tft = Convert.ToInt32(Console.ReadLine());
                                if (tft == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }

                                else if (tft == 9)
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if (tft > bakiye)
                                {
                                    Console.WriteLine("Yetersiz Bakiye");
                                    goto AnaMenu;
                                }
                                else if (tft <= bakiye && tft > 0)
                                {
                                    Console.WriteLine("Ödeme Alınıyor Yeni Bakiye");
                                    Console.WriteLine(bakiye = bakiye - tft);
                                    goto Tft;
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen Geçerli Bir Miktar Giriniz");
                                    goto Tft;
                                }
                            }
                            else if (ödeme == 3)
                            {
                            Internet:
                                Console.WriteLine("Internet Fatura Tutarını Giriniz:");
                                Console.WriteLine("Ana Menü                        9");
                                Console.WriteLine("Çıkmak için                     0");
                                int ınternet = Convert.ToInt32(Console.ReadLine());
                                if (ınternet == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }

                                else if (ınternet == 9)
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if (ınternet > bakiye)
                                {
                                    Console.WriteLine("Yetersiz Bakiye");
                                    goto AnaMenu;
                                }
                                else if (ınternet <= bakiye && ınternet > 0)
                                {
                                    Console.WriteLine("Ödeme Alınıyor Yeni Bakiye");
                                    Console.WriteLine(bakiye = bakiye - ınternet);
                                    goto Internet;
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen Geçerli Bir Miktar Giriniz");
                                    goto Internet;
                                }
                            }
                            else if (ödeme == 4)
                            {
                            Su:
                                Console.WriteLine("Su Fatura Tutarını Giriniz:");
                                Console.WriteLine("Ana Menü                  9");
                                Console.WriteLine("Çıkmak için               0");
                                int su = Convert.ToInt32(Console.ReadLine());
                                if (su == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }

                                else if (su == 9)
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if (su > bakiye)
                                {
                                    Console.WriteLine("Yetersiz Bakiye");
                                    goto AnaMenu;
                                }
                                else if (su <= bakiye && su>0)
                                {
                                    Console.WriteLine("Ödeme Alınıyor Yeni Bakiye");
                                    Console.WriteLine(bakiye = bakiye - su);
                                    goto Su;
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen Geçerli Bir Miktar Giriniz");
                                    goto Su;
                                }
                            }
                            else if (ödeme == 5)
                            {
                            OGS:
                                Console.WriteLine("OGS Fatura Tutarını Giriniz:");
                                Console.WriteLine("Ana Menü                        9");
                                Console.WriteLine("Çıkmak için                     0");
                                int ogs = Convert.ToInt32(Console.ReadLine());
                                if (ogs == 0)
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }

                                else if (ogs == 9)
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if (ogs > bakiye)
                                {
                                    Console.WriteLine("Yetersiz Bakiye");
                                    goto AnaMenu;
                                }
                                else if (ogs <= bakiye && ogs > 0)
                                {
                                    Console.WriteLine("Ödeme Alınıyor Yeni Bakiye");
                                    Console.WriteLine(bakiye = bakiye - ogs);
                                    goto OGS;
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen Geçerli Bir Miktar Giriniz");
                                    goto OGS;
                                }
                            }
                            else if (ödeme == 9)
                            {
                                Console.WriteLine("Ana Menüye Dönülüyor");
                                goto AnaMenu;
                            }
                            else if (ödeme == 0)
                            {
                                Console.WriteLine("Çıkış Yapılıyor");
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                                goto Odeme;
                            }
                        }
                        else if (secim == 6)
                        {
                        Secim6:
                            Console.WriteLine("Şifre Değiştirmek İçin 1");
                            Console.WriteLine("Ana Menü        9");
                            Console.WriteLine("Çıkmak için     0");
                            string tus6 =Console.ReadLine();
                            if (tus6 == "0")
                            {
                                Console.WriteLine("Çıkış Yapılıyor");
                            }
                            else if (tus6 == "9")
                            {
                                Console.WriteLine("Ana Menüye Dönülüyor");
                                goto AnaMenu;
                            }
                            else if (tus6 == "1")
                            {
                                Console.WriteLine("Yeni Şifrenizi Girin:");
                                Console.WriteLine("Ana Menü        9");
                                Console.WriteLine("Çıkmak için     0");
                                string yenisifre = Console.ReadLine();
                                if (yenisifre == "9")
                                {
                                    Console.WriteLine("Ana Menüye Dönülüyor");
                                    goto AnaMenu;
                                }
                                else if (yenisifre == "0")
                                {
                                    Console.WriteLine("Çıkış Yapılıyor");
                                }
                                else
                                {
                                    Console.WriteLine("Yeni Şifreniz Oluşturuldu");
                                    password = yenisifre;
                                    goto Bankamatik;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                                goto Secim6;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                            goto AnaMenu;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Şifre Yanlış");
                        hak--;
                        goto Sifre;
                    }
                }
                else
                {
                    Console.WriteLine("Hakkınız Bitti Sistemden Atıldınız");
                }
            }
            else if (islem == 2)
            {
                Console.WriteLine("Şuan Çalışmıyor");
                goto Bankamatik;

            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                goto Bankamatik;
            }

            #endregion
        }
    }
}



