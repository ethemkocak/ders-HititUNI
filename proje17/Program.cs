namespace proje17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Metni Giriniz: ");
                String Metin = Console.ReadLine();

                string Sonuc1 = "";
                string Sonuc2 = "";

                String TersMetin = "";
                for (int i = Metin.Length - 1; i >= 0; i--)
                {
                    TersMetin += Metin[i].ToString();
                }
                for (int i = 0; i < Metin.Length; i++) 
                {
                    Sonuc1 = Sonuc1 + Metin[i];
                    Sonuc2 = Metin[i] + Sonuc2;
                    Console.WriteLine(Sonuc2 + " " + Sonuc1);
                }

 
            }


            catch (Exception ex)
            {
                Console.WriteLine("HATA: {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
