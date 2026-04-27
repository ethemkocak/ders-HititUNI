namespace proje15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Metni Giriniz : ");
                string Metin = Console.ReadLine();

                string Sonuc = "";

                for (int i = 0; i < Metin.Length; i++)
                {
                    Sonuc += Metin[i].ToString();
                    Console.WriteLine(Sonuc);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
