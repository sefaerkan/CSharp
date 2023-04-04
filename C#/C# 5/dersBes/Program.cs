using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using dersBes.Topla;

namespace dersBes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int sayi = 0;
            sayi = Toplama.Toplam(50);
            Console.WriteLine(sayi);
            Console.ReadLine();*/

            int golSayisi = 0;
            string takimSeviyesi = "";
            Random sayi = new Random();
            golSayisi = sayi.Next(0, 6);

            switch(golSayisi)
            {
                case 1: 
                    takimSeviyesi = "OK";
                    break;
                case 2:
                    takimSeviyesi = "Güzel";
                    break;
                case 3:
                    takimSeviyesi = "Yüksek";
                    break;
                case 4:
                    takimSeviyesi = "Muhtesem";
                    break;
                case 5:
                    takimSeviyesi = "WOW";
                    break;
                default:
                    takimSeviyesi = "Kötü";
                    break;
            }
            Console.WriteLine(takimSeviyesi);
            Console.ReadLine();


        }
    }
}

/*namespace dersBes.Topla //Namespace oluşturup farklı namespaclerde kullanma
{
    class Toplama
    {
        public static int Toplam(int a)
        {
            int b = 10;
            return a + b;
        }
    }
}*/