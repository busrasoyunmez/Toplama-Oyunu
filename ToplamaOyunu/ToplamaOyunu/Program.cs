using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaOyunu
{
    internal class Program
    {

        //static bool Asal(int sayi)
        //{
        //    bool sonuc;
        //    int sayac = 0;
        //    //sayi = sayac=0;
        //    for (int i = 0; i <= sayi; i++)
        //    {
        //        if (sayi % i == 0)
        //        {
        //            sayac += 1;
        //        }
        //    }
        //    if (sayac == 2)
        //    {
        //        sonuc = true;
        //    }
        //    else
        //    {
        //        sonuc = false;
        //    }
        //    return sonuc;
        //}

        #region MukemmelSayı
        public void MukemmelSayi()
        {
            Console.WriteLine("Bir Tam Sayı Giriniz: ");
            int sayi = Convert.ToInt16(Console.ReadLine());
            int sonuc = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sonuc += i;
                }
            }
            if (sonuc == sayi)
            {
                Console.WriteLine($"{sayi} Sayınız Mükemmel Sayıdır");
            }
            else
            {
                Console.WriteLine($"{sayi} Sayınız Mükemmel Sayı Değildir.");
            }
            Console.ReadLine();
        }
        #endregion
        static void Main(string[] args)
        {
            #region Toplama Oyunu

            //Toplama işlemini öğretmeye çalışan bir oyun programı yazılacaktır. Oyun başladığı zaman rastgele 2 tane 1-100 arasında
            //sayı tutulacak, tutulan sayılar ekrana gösterilecek ve kullanıcıya bu sayıların toplamı nedir diye sorulacaktır. Eğer
            //kullanıcı doğru cevap verirse “Tebrikler Bildiniz” değil ise “Üzgünüm Bilemediniz” diye mesaj verecektir. Her cevaptan
            //sonra “Tekrar Oynamak istiyormusunuz(e/E)?” şeklinde bir soru sorulacak ve eğer kullanıcı “e” veya “E” ile karşılık verirse
            //oyun tekrar başlayacaktır. Kullanıcının puanı her doğru cevap için 5 puan artacak, her yanlış cevap için ise 2 puan azalacaktır.
            //Oyun sonlandığında kullanıcının verdiği doğru cevap sayısı, yanlış cevap sayısı ve puanı ekranda listelenmelidir. Bu işlemleri
            //yapan programın kodlarını yazınız.

            //baslangic2:
            //int toplampuan=0;
            //Random random = new Random();
            //for (int i = 1; i < 2; i++)
            //{
            //    baslangic:
            //    int sayi1=random.Next(1, 100);
            //    Console.WriteLine(sayi1);
            //    int sayi2 = random.Next(1, 100);
            //    Console.WriteLine(sayi2);
            //    toplamayadon:
            //    Console.WriteLine("Toplama işleminin sonucunu giriniz:");
            //    int sonuc = Convert.ToInt32(Console.ReadLine());
            //    //sonuc = sayi1 + sayi2;
            //    //int deger = sonuc;
            //    if (sonuc == (sayi1+sayi2))
            //    {
            //        toplampuan = toplampuan + 5;
            //        Console.WriteLine("Tebrikler Doğru Bildiniz... Puanınız :"+toplampuan);
            //    }
            //    else
            //    {
            //        toplampuan = toplampuan - 2;
            //        Console.WriteLine("Girdiğiniz sonuç yanlış. Puanınız : "+toplampuan+" tekrar deneyiniz: ");
            //        goto toplamayadon;
            //    }
            //    Console.WriteLine("Devam Etmek istiyor musunuz?");
            //    string devam = Convert.ToString(Console.ReadLine());
            //    if (devam=="e" || devam=="E")
            //    {
            //        goto baslangic;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Puanınız : " + toplampuan);
            //        Console.WriteLine("Yeni oyuna başlamak ister misiniz?");
            //        string yenioyun = Convert.ToString(Console.ReadLine());
            //        if (yenioyun== "e" || yenioyun == "E")
            //        {
            //            Console.Clear();
            //            goto baslangic2;
            //        }
            //        else
            //        {
            //            Environment.Exit(0);
            //        }
            //    }
            //}
            #endregion

            #region Otopark Ücreti Hesaplama
            //Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki
            //her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki
            //her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi
            //girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.

            //aracadon:
            //Console.WriteLine("Araç Tipini Giriniz: ");
            //string aractipi = Convert.ToString(Console.ReadLine());
            //saatedon:
            //Console.WriteLine("Kaç Saat Kalacaksınız: ");
            //double saat = Convert.ToDouble(Console.ReadLine());

            //double taksi = 5, minibus = 6, ticari = 6.5;
            //double tutar = 0;


            //if (aractipi == "taksi")
            //{
            //    if (saat > 1)
            //    {
            //        tutar =  ((taksi * 0.2) + taksi)*saat;
            //        Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
            //    }
            //    else if(saat<1)
            //    {
            //        Console.WriteLine("Ödemeniz Gereken Tutar: " + taksi + " TL'dir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı değer girdiniz. Tekrar giriniz: ");
            //        goto saatedon;
            //    }
            //}
            //else if (aractipi == "minibus")
            //{
            //    if (saat != 1)
            //    {
            //        tutar = saat * (minibus * 1.21) + minibus;
            //        Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ödemeniz Gereken Tutar: " + minibus + " TL'dir.");
            //    }
            //}
            //else if (aractipi == "ticari")
            //{
            //    if (saat != 1)
            //    {
            //        tutar = saat * (ticari * 1.25) + ticari;
            //        Console.WriteLine("Ödemeniz gereken tutar: " + tutar);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ödemeniz Gereken Tutar: " + ticari + " TL'dir.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız. Tekrar Giriniz: ");
            //    goto aracadon;
            //}

            #endregion

            #region Parametre Metot
            //Parametre olarak yollanan bir sayının asal sayı olup olmadığını geriye döndüren bir metot yazınız. Eğer sayı asal ise geriye
            //“true” değil ise “false” değeri döndürülecektir.



            /*Console.ReadLine();*/
            #endregion

            #region Mukemmel Sayı

            //Kendisi hariç bütün pozitif çarpanları (tam bölenleri) toplamı, yine kendisine eşit olan sayılara 
            //“mükemmel sayı” denir. Örneğin 6=1+2+3 ve 28=1+2+4+7+14 gibi. Buna göre klavyeden girilen bir tamsayının 
            //“mükemmel sayı” olup olmadığını kontrol eden MukemmelSayi adında bir metot tanımlayınız. Metot eğer sayı 
            //mükemmel sayı ise ekrana “Mükemmel Sayıdır” değilse “Mükemmel Sayı DEĞĠLDĠR” yazan programın kodlarını 
            //yazınız. ( static void MukemmelSayi(int sayi) )

            Program prg = new Program();
            prg.MukemmelSayi();
            Console.ReadLine();

            #endregion

        }
        
    }
}

