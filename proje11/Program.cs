namespace proje11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sayiyi Giriniz: ");
                String metin = Console.ReadLine();
                int sayi = Convert.ToInt32(metin);

                bool AsalMi = true;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        AsalMi = false;
                    }
                }
                if (AsalMi == true)
                {
                    Console.WriteLine("{0} Sayi Asaldir.", sayi);
                }
                else
                {
                    Console.WriteLine("{0} Sayi Asal Degildir.", sayi);
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
