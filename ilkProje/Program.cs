namespace ilkProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            string metin1;
            string metin2;
            int sonuc;

            Console.Write("1. sayıyı giriniz: ");
            metin1 = Console.ReadLine();
            sayi1 = Convert.ToInt32(metin1);

            Console.Write("2. sayıyı giriniz: ");
            metin2 = Console.ReadLine();
            sayi2 = Convert.ToInt32(metin2);

            sonuc = sayi1 + sayi2;

            Console.WriteLine("Sonuç: "+sonuc.ToString());

        }
    }
}
