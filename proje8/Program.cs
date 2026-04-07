using System.Runtime.Serialization.Formatters;

namespace proje8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                string sonuc = "";
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0) {
                        sonuc += i.ToString() + " ";
                    }

                }
            Console.WriteLine("1 ile 10 arasındaki 3 veya 5'e tam bölünebilen sayılar: {0} " , sonuc.Trim());
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
