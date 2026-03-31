using System.Runtime.CompilerServices;

namespace proje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
                int toplam = 0;
                for (int i = 1; i <= 10; i++) {
                    toplam += i;
                }
                Console.WriteLine("toplam: {0}",toplam);
            }

            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            finally{
                Console.ReadKey(); 
            }
        }
    }
}
