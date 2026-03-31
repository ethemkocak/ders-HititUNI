namespace proje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int toplam = 0;
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        toplam += i;
                    }
                }
                Console.WriteLine("1-10 arası tek sayıların toplamı: {0}", toplam);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
