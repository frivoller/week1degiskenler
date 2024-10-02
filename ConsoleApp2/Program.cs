using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bilgileri al
        Console.Write("T.C. Kimlik Numaranızı giriniz: ");
        string tcKimlikNo = Console.ReadLine();

        Console.Write("Adınızı giriniz: ");
        string ad = Console.ReadLine();

        Console.Write("Soyadınızı giriniz: ");
        string soyad = Console.ReadLine();

        // Telefon numarası uzun bir sayı olabileceği için string kullanıldı
        Console.Write("Telefon numaranızı giriniz: ");
        string telefonNo = Console.ReadLine();

        Console.Write("Yaşınızı giriniz: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        Console.Write("İlk aldığınız ürünün fiyatını giriniz: ");
        decimal urun1Fiyat = Convert.ToDecimal(Console.ReadLine());

        // Ürün fiyatlarında ondalıklı değerler olabileceği için decimal kullanıldı
        Console.Write("İkinci aldığınız ürünün fiyatını giriniz: ");
        decimal urun2Fiyat = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"\n{tcKimlikNo} numaralı {ad} {soyad}, kaydınız başarıyla tamamlanmıştır.");
        Console.WriteLine($"Telefon numaranız {telefonNo} bilgi sms yoluyla iletilmiştir.");

        decimal toplamFiyat = urun1Fiyat + urun2Fiyat;
        Console.WriteLine($"Aldığınız iki ürünün toplam fiyatı: {toplamFiyat} TL");
    }
}
