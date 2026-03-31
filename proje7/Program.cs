namespace proje7
{
    internal class Program
    {
        static void Main(string[] args)
        {

			try{

                Console.WriteLine("lütfen bir sayı giriniz : ");
                string metin1 =Console.ReadLine();
                int sayi = Convert.ToInt32(metin1);
                int toplam=1;

                for (int i = 1; i <= sayi; i++) { 

                    toplam *= sayi;
                }
                Console.WriteLine("{0} sayısının kendisi kadar kuvveti {1}", sayi,toplam);
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
