namespace proje16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {

                int[] SayiDizisi = new int[5];

                for (int i = 0; i < SayiDizisi.Length; i++)
                {
                    Console.Write("Dizinin {0}. Elemanını Giriniz : ", i);
                    string Metin = Console.ReadLine();
                    SayiDizisi[i] = Convert.ToInt32(Metin);
                }
                for(int i = 0; i < SayiDizisi.Length; i++)
                {
                    for(int j = 0; j < SayiDizisi.Length - 1; j++)
                    {
                        if(SayiDizisi[j] > SayiDizisi[j + 1])
                        {
                            int Temp = SayiDizisi[j];
                            SayiDizisi[j] = SayiDizisi[j + 1];
                            SayiDizisi[j + 1] = Temp;
                        }
                    }
                }
                string SayiMetin = "";
                foreach (int Sayi in SayiDizisi)
                {
                    SayiMetin += Sayi.ToString() + "-";
                }
                Console.WriteLine("Girilen Sayıların Küçükten büyüğe sıralanmış şekli {0}'dır.", SayiMetin.Trim('-'));
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
