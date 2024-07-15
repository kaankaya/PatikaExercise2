using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Bu pratik uygulamasında sizlerden konsol ekranı yardımıyla kullanıcıdan bir sayı değeri almanızı, bu değerin 10'a eşit mi , 10'dan küçük mü, 10'dan büyük mü olduğu durumları kontrol ederek kullanıcıya bir bilgilendirme mesajı yazmanız isteniyor.
             Ardından 2. bir kontrol yapısıyla girilen sayının çift mi yoksa tek mi olduğunu ekrana yazdırınız.
             */

            Console.WriteLine("Lütfen Kontrol Etmek İstediğiniz Sayıyı Giriniz");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 10)
            {
                Console.WriteLine("Sayı 10 a eşittir");
                if (number % 2 == 0)
                {
                    Console.WriteLine("Girilen Sayi Çifttir");
                }
                else
                {
                    Console.WriteLine("Girilen Sayi Tekdir");
                }//End İf
            }
            else if (number < 10)
            {
                Console.WriteLine("Girilen Sayı 10 dan küçük");
                if (number % 2 == 0)
                {
                    Console.WriteLine("Sayı Çift");
                }
                else
                {
                    Console.WriteLine("Sayı Tek");
                }//End İf
            }
            else if (number > 10)
            {
                Console.WriteLine("Sayı 10 dan büyük");
                if (number % 2 == 0)
                {
                    Console.WriteLine("Girilen Sayı çiftdir");
                }
                else
                {
                    Console.WriteLine("Girilen Sayı Tekdir");
                }//End İf
            }
            else
            {
                Console.WriteLine("Girilen Sayı Negatif");
            } //End İf
        }
    }
}