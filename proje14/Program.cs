namespace proje14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] SayiDizisi = new int[3];

                for (int i = 0; i < SayiDizisi.Length; i++)
                {
                    Console.Write("Dizinin {0}. Elemanını Giriniz : ", i);
                    string Metin = Console.ReadLine();
                    SayiDizisi[i] = Convert.ToInt32(Metin);
                }

                int EnBuyuk = 0;
                string SayiMetin = "";

                foreach (int Sayi in SayiDizisi)
                {
                    if (Sayi > EnBuyuk)
                    {
                        EnBuyuk = Sayi;
                    }

                    SayiMetin += Sayi.ToString() + "-";
                }

                Console.WriteLine("Girilen {0} sayıları arasındaki en büyük sayı {1} sayısıdır.",
                    SayiMetin.Trim('-'), EnBuyuk);
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
