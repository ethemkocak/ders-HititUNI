namespace proje22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\ethem\\Desktop\\hititüni\\ders\\projects\\sample.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
