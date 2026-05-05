using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace proje18
{
    // TDK'dan dönen JSON yapısını karşılayacak sınıf
    public class IsimSonuc
    {
        public string ad { get; set; }
        public string anlam { get; set; }
        public string cinsiyet { get; set; }
    }

    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- TDK Kişi Adları Sözlüğü ---");
            Console.Write("Sorgulamak istediğiniz isim: ");
            string isim = Console.ReadLine();

            Console.Write("Cinsiyet seçin (1: Kız, 2: Erkek): ");
            string cinsiyetKod = Console.ReadLine();

            // URL Encoding işlemi: Özel karakterleri (ü, ş, ç vb.) web uyumlu hale getirir
            string encodedIsim = Uri.EscapeDataString(isim);
            string url = $"https://sozluk.gov.tr/adlar?ara={encodedIsim}&gore=1&cins={cinsiyetKod}";

            try
            {
                // TDK'ya istek atıyoruz
                string responseBody = await client.GetStringAsync(url);

                // JSON verisini listeye dönüştürüyoruz
                var sonuclar = JsonSerializer.Deserialize<List<IsimSonuc>>(responseBody);

                if (sonuclar != null && sonuclar.Count > 0)
                {
                    Console.WriteLine("\n--- Sonuç ---");
                    foreach (var sonuc in sonuclar)
                    {
                        Console.WriteLine($"İsim: {sonuc.ad}");
                        Console.WriteLine($"Anlamı: {sonuc.anlam}");
                    }
                }
                else
                {
                    Console.WriteLine("\nAradığınız isim sözlükte bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }

            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}