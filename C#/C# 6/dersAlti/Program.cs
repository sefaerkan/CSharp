using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersAlti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i ++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            string[] siparisNo =
            {
                "INZ001",
                "GOG256",
                "APP021"
            };

            for (int i = siparisNo.Length; i > 0; i--)
            {
                Console.WriteLine(siparisNo[i-1]);
            }
            Console.ReadLine();*/

            int sayi = 0;
            
            /*do
            {
                sayi++;
                if (sayi == 7) continue;
                Console.WriteLine(sayi);
            }while(sayi < 10);*/

            while(sayi < 10)
            {
                sayi++;
                if (sayi == 7) continue;
                Console.WriteLine(sayi);
            }
            
            Console.ReadLine();

        }
    }
}
