namespace proje12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Metni Giriniz: ");
                String Metin = Console.ReadLine();

                String TersMetin = "";
                for(int i = Metin.Length - 1; i >= 0; i --) 
                { 
                    TersMetin += Metin[i].ToString();
                }
                Console.WriteLine("Girilen \"{0}\" Metnin Tersten Yazılışı \"{1}\".",Metin,TersMetin);
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
