namespace proje21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int delayTime = 100;
                int screenWidth = 20; 
                
                string[] frames = { "-", "|", "/", "-", "|", "-", "\\", "|" };

                while (true)
                {
                    for (int spaces = 0; spaces < screenWidth; spaces++)
                    {
                        
                        foreach (string frame in frames)
                        {
                            Console.Clear();

                            
                            string padding = new string(' ', spaces);
                            Console.WriteLine(padding + frame);

                            Thread.Sleep(delayTime);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }

        }
    }
}




///ESKİ VERSİYON

/*
 
            try
            {
                int DelayTime = 100;
                for (int i = 1; i <= 100; i++)
                {
       
                    Console.Clear();
                    Console.WriteLine("-");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("|");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("/");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("-");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("|");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("-");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("\\");
                    Thread.Sleep(DelayTime);
                    Console.Clear();
                    Console.WriteLine("|");
                    Thread.Sleep(DelayTime);

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
 
 */