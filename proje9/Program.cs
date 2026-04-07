namespace proje9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                
                int[] sayilar=new int[3];
                
                for(int i=0; i < sayilar.Length; i++)
                {
                    Console.WriteLine("sayı dizisinin {0}. elemanını giriniz: ",i);
                    string metin = Console.ReadLine();
                    sayilar[i] = Convert.ToInt32(metin);
                }
                int toplam = 0;
                for(int i=0; i< sayilar.Length; i++)
                {
                    toplam += sayilar[i];
                }
                Console.WriteLine("Sayı Dizisine Girdiğiniz elemanların toplamı: {0}",toplam);
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
