using System.ComponentModel;

namespace proje6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
                int toplam = 0;

                for (int i = 1; i <= 10; i++) {
                    if(i%2==0 && i%3==0)
                    {
                        Console.WriteLine("2'ye ve 3'e tam bölünen sayılar {0},", i);
                        toplam += i;
                    }else {
                        Console.WriteLine("{0} :  2'ye ve 3'e tam bölünemez",i ); 
                    }
                }Console.WriteLine("2'ye ve 3'e tam bölünen sayıların toplamı:{1}",toplam);
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA: {0}",ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
