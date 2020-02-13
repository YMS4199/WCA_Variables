

using System;

namespace WCA_Variables
{
    class Program
    {
        static void Main(string[] args)
        {    /*
            Çoklu yorum satırı 
             */

            // Tekli yorum satırı

            // Ctrl + K + D     => Kodları Düzenle
            // Ctrl + E + W    
            // Ctrl + K + C     => Yorum satırına al
            // Ctrl + K + U     => Yorum satırından al
            // Ctrl + Shift + B => Build Etmek
            // Ctrl + D         => Duplicate


            // Tam sayılar
            // byte, sbyte, short, ushort, int, uint, long, ulong

            // byte => 8 bit 
            // MaxValue = 255;
            // MinValue = 0; 
            byte sayi1 = 56;


            // sbyte => 8 bit 
            // MaxValue = 127 
            // MinValue = -128
            sbyte sayi2 = 12;

            // short => 16 bit
            // MaxValue = 32767 
            // MinValue = -32768 
            short sayi3 = 134;

            // ushort => 16 bit
            // MaxValue = 65535
            // MinValue = 0 
            ushort sayi4 = 123;


            // int => 32 bit 
            // MaxValue = 2147483647  
            // MinValue = -2147483648
            int sayi5 = 324;


            // unit => 32 bit
            // MaxValue = 4294967295
            // MinValue = 0
            uint sayi6 = 21432432;

            // long => 64 bit
            // MaxValue = 9223372036854775807 
            // MinValue = -9223372036854775808 
            long sayi7 = 324234;


            // ulong => 64 bit
            // MaxValue = 18446744073709551615
            // MinValue = 0 
            ulong sayi8 = 23424;


            // Ondalıklı sayılar
            // float, double, decimal

            float sayi9 = 12.0F;
            double sayi10 = 12.0;
            decimal sayi11 = 12.0M;

            // Metinsel
            //char, string

            // char => 16 bit
            char karakter = 'A';


            // string
            string metin = "Bilge\nAdam\nBeşiktaş\nYazılım\nDersleri";

            string tekKarakter = "A";
            string bos = "";

            // string nesnelerde kullanılan kaçış karakterleri
            // \n => yeni bir satır oluştur
            // \t => bir tab boşluk
            Console.WriteLine(metin);
             
            string tabBosluk = "Bilge\tAdam";
            Console.WriteLine(tabBosluk);


            //  =>   Bilge Adam Beşiktaş "Yazılım" Dersleri

            string metin2 = "Bilge Adam Beşiktaş \"Yazılım\" Dersleri";
            Console.WriteLine(metin2);

            // Mantıksal
            // bool

            bool sonuc = false;
            bool result = 10 > 2;

            Console.WriteLine(result); 
            Console.ReadKey();
        }
    }
}














































































































































































































































