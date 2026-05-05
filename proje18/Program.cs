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
        public string cinsiyet { get; set; } // TDK'dan dönen cinsiyet kodu
    }

    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("--- TDK Kişi Adları Sözlüğü (Otomatik Cinsiyet) ---");
                Console.Write("Sorgulamak istediğiniz isim (Çıkış için 'q'): ");
                string isim = Console.ReadLine();

                if (string.IsNullOrEmpty(isim)) continue;
                if (isim.ToLower() == "q") break;

                string encodedIsim = Uri.EscapeDataString(isim);
                bool bulundu = false;

                try
                {
                    // 1: Kız, 2: Erkek için döngü
                    for (int i = 1; i <= 2; i++)
                    {
                        string url = $"https://sozluk.gov.tr/adlar?ara={encodedIsim}&gore=1&cins={i}";

                        var response = await client.GetAsync(url);

                        // Eğer sayfa bulunamadıysa veya internet yoksa hataya düşer
                        if (!response.IsSuccessStatusCode) continue;

                        string responseBody = await response.Content.ReadAsStringAsync();

                        // TDK bazen boş veya "null" dönebiliyor, bu durumda deserializer patlar.
                        // Gelen verinin bir liste ( '[' ile başlaması) olduğunu kontrol ediyoruz.
                        if (!string.IsNullOrEmpty(responseBody) && responseBody.Trim().StartsWith("["))
                        {
                            var sonuclar = JsonSerializer.Deserialize<List<IsimSonuc>>(responseBody);

                            if (sonuclar != null && sonuclar.Count > 0)
                            {
                                bulundu = true;
                                string cinsiyetEtiketi = (i == 1) ? "[KIZ]" : "[ERKEK]";

                                foreach (var sonuc in sonuclar)
                                {
                                    Console.WriteLine($"\n{cinsiyetEtiketi}");
                                    Console.WriteLine($"İsim: {sonuc.ad}");
                                    Console.WriteLine($"Anlamı: {sonuc.anlam}");
                                }
                            }
                        }
                    }

                    if (!bulundu)
                    {
                        Console.WriteLine("\nAradığınız isim sözlükte bulunamadı.");
                    }
                }
                catch (JsonException)
                {
                    Console.WriteLine("\nSunucudan geçersiz veri döndü (JSON Hatası).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nBağlantı hatası: {ex.Message}");
                }

                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("Devam etmek için bir tuşa basın...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}