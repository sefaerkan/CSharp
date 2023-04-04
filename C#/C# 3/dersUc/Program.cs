using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersUc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random zar = new Random(); //Random ile rastgele sayı

            int birinciAtis = zar.Next(1, 21); //Next sayı aralığında rastgele sayı
            int ikinciAtis = zar.Next(1, 21);
            int ucuncuAtis = zar.Next(1, 21);
            int dorduncuAtis = zar.Next(1, 21);
            int besinciAtis = zar.Next(1, 21);

            float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis) / 3f;
            
            if(ortalama > 15)
            {
                Console.WriteLine("Büyük zarar verdin"); 
            } else if(ortalama > 10 && ortalama <=15 )
            {
                Console.WriteLine("Orta zarar verdin");
            } else if (ortalama > 5 && ortalama <= 10)
            {
                Console.WriteLine("Zarar yok");
            } else if(ortalama < 5 && ortalama > 2)
            {
                Console.WriteLine("Kendine Zarar Verdin");
            } else
            {
                Console.WriteLine("2 den küçük olduğunda çalışır");
            }

            if(ortalama >= 10)
            {
                if(birinciAtis > 12)
                {
                    if(ikinciAtis > 15)
                    {
                        Console.WriteLine("Nested if orneği");
                    }
                }
            }


            if (dorduncuAtis >= 10 || besinciAtis >= 5)
            {
                Console.WriteLine("Ek zarar verdin");
            }

            Console.WriteLine(ortalama);
            Console.ReadLine();

        }
    }
}
