using System;
namespace alistirma_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cumleyi giriniz: ");
            string cumle = Console.ReadLine();
            for (int i=0; i<cumle.Length; i++)
            {
                if (cumle[i] == ' ')
                {
                   string yeni = cumle.Substring(0,i);
                   Console.WriteLine(yeni);
                   break;
                }
            }
            
        }
    }
}