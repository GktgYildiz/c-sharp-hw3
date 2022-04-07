using System;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (bilinçsiz Dönüşüm)
            Console.WriteLine("***** Implicit Conversion *****");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c ;
            Console.WriteLine("d:"+d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "goktug";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:"+g);

            // Explicit Conversion (Bilinçli Dönüşüm)

            // -----Convert & Parse-----//

            Console.WriteLine("***** Explicit Conversion *****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            int z = 100;
            byte t=(byte)z;
            Console.WriteLine("t:"+t);

            float w = 10.3f;
            byte v=(byte)w;
            Console.WriteLine("v:" + v); //float olan 10.3 sayısını byte'a çevirdiğimiz için .3 kısmı yuvarlanıyor
                                         //ve karşımıza direkt olarak  10 diye çıkıyor.

            // **** ToString Methodu **** //

            Console.WriteLine("****ToString Methodu ****");

            int xx = 6;
            string yy=xx.ToString();
            Console.WriteLine("yy:" + yy); //sayıyı yazıya çevirdik. bundan sonraki yy üzerinde işlem yaparken
                                           //çarpım toplama gibi matematiksel ifadeleri kullanamyız. o artık metin yani string

            string zz =12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            //system.convert
            Console.WriteLine("****system.convert sınıfı*****");
            string s1="10",s2 = "20";    //string olarak s1 ataması yaptık. buradaki 10 ve 20 metinsel
            int sayi1, sayi2;           //sayi1 ve sayi2 integer olarak tanımlandı. yani karşılıkları birer sayı olucak
            int Toplam;

            sayi1 = Convert.ToInt32(s1);    //sayi1'i şu yap --> s1'de yazan metinsel sayıyı metin olmaktan çıkar ve sayıya dönüştür
            sayi2 = Convert.ToInt32(s2);    // aynı şekilde s2 içinde bunu yap. Convert etmek yani dönüştürmek

            Toplam = sayi1 + sayi2;         //yukarıda toplam ifadesininde integer olucağını belirtmiştik. artık sayısala dönüştürülen ifadeler toplanadabilir
            Console.WriteLine("Toplam:" + Toplam);


            //Parse
            Console.WriteLine("*****Parse ****");

            ParseMethod();



        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("Rakam1 :"+rakam1);
            Console.WriteLine("Double1 :" + double1);

        }
    }   
}
