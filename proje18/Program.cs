using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace proje18
{
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

            // Sonsuz döngü başlatıyoruz
            while (true)
            {
                Console.WriteLine("--- TDK Kişi Adları Sözlüğü ---");
                Console.Write("Sorgulamak istediğiniz isim (Çıkış için 'q' yazın): ");
                string isim = Console.ReadLine();

                // Çıkış kontrolü
                if (isim?.ToLower() == "q")
                {
                    Console.WriteLine("Program kapatılıyor...");
                    break;
                }

                Console.Write("Cinsiyet seçin (1: Kız, 2: Erkek): ");
                string cinsiyetKod = Console.ReadLine();

                string encodedIsim = Uri.EscapeDataString(isim);
                string url = $"https://sozluk.gov.tr/adlar?ara={encodedIsim}&gore=1&cins={cinsiyetKod}";

                try
                {
                    string responseBody = await client.GetStringAsync(url);
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
                    Console.WriteLine($"\nBir hata oluştu: {ex.Message}");
                }

                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("Yeni bir sorgu için bir tuşa basın...");
                Console.ReadKey();

                // Ekranı temizle ki görüntü kirliliği olmasın
                Console.Clear();
            }
        }
    }
}