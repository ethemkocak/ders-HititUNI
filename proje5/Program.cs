namespace proje5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                
                Console.WriteLine("bir sayı giriniz: ");
                
                string sayi = Console.ReadLine();
                long toplam = 1;      
                long sayi1 = Convert.ToInt64(sayi);

                for (long i = 1; i <= sayi1; i++) {
                    toplam *= i;
                }
                Console.WriteLine("{0} sayısının faktoryeli: {1}",sayi1,toplam);

            }
                 
            catch (Exception ex) {
                Console.WriteLine(ex.Message); 
            }
            finally {
                Console.ReadKey(); 
            }
        }
    }
}
