using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string dosyaYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DonanimNotu.txt");

        // Komutları hazırlayalım (Marka, Model ve Kapasite odaklı)
        string komutlar = "/c " +
            "echo --- ISLEMCI --- && wmic cpu get name && " +
            "echo --- EKRAN KARTI --- && wmic path win32_VideoController get name && " +
            "echo --- RAM (Kapasite - Byte) --- && wmic memorychip get manufacturer, capacity && " +
            "echo --- DISK (Model - Kapasite) --- && wmic diskdrive get model, serialnumber, size";

        ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", komutlar)
        {
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Console.WriteLine("Bilgiler çekiliyor...");

        Process proc = Process.Start(psi);
        string sonuc = proc.StandardOutput.ReadToEnd();
        proc.WaitForExit();

        // Sonucu masaüstüne kaydet
        File.WriteAllText(dosyaYolu, sonuc);

        Console.WriteLine("İşlem tamam! Masaüstündeki 'DonanimNotu.txt' dosyasını açabilirsin.");
        Console.ReadKey();
    }
}