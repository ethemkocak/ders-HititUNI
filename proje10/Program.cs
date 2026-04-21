namespace proje10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Metni Giriniz: ");
                string Metin = Console.ReadLine();
                String[] KelimeDizisi = Metin.Split(' ');
                String Kisaltma = "";
                foreach (String kelime in KelimeDizisi)
                {
                    Kisaltma += kelime[0].ToString() + ".";

                }
                Console.WriteLine("Kısaltma: " + Kisaltma.ToUpper());
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
