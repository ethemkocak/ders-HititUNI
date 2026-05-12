namespace proje23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\ethem\\Desktop\\hititüni\\ders\\projects\\sample.txt");
                sw.WriteLine("Hello World!!");
                sw.WriteLine("From the StreamWriter class");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı.");
            }
        }
    }
}
