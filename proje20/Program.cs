namespace proje20
{
    using System.Threading;
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToString());
                Thread.Sleep(1000);
            }

        }
    }
}
