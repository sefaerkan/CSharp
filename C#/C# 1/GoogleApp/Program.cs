using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu bir satırdır");
            Console.WriteLine("Bu da bir satırdır");
            Console.Write("\nBu bir satırdır");
            Console.Write("\nBu da bir satırdır\n\n"); 
            

            string sehirIsmi =  "İzmir"; //string yerine var da diyebilirdik
            int fiyat=5; //int yerine var da diyebilirdik
            float havaSicakligi=25.5f; //decimal m, string yerine var da diyebilirdik

            Console.Write(sehirIsmi);
            Console.Write("\'de bomba yedim ve tanesi ");
            Console.Write(fiyat);
            Console.Write(" liraydı ve hava sıcaklığı ");
            Console.Write(havaSicakligi);
            Console.Write(" dereceydi.\n\n");
            //Console.ReadLine();

            string birinci = "Sefa";
            string ikinci = "Unity Eğitmeni " + birinci;
            string ucuncu = "Unity Eğitmeni " + birinci + " " + "Erkan"; //Concatanate String Birleştirme
            string dorduncu = $"{birinci} {ikinci} elle yazı yazıyoruz"; //String Interpolation
            string besinci = $@"c:\users\sefa\{ikinci}\veri";
            Console.WriteLine(besinci);
            //Console.ReadLine();

            int bir = 35;
            int iki = 23;
            Console.WriteLine((bir+ 10) + " hello " +iki +10 );
            //Console.ReadLine();

            int ilkSayi = 35;
            int ikinciSayi = 34;
            int top = 35 + 34;
            int cik = 35 - 34;
            int carp = 35 * 3;
            float bol = 36f / 5;
            /*
            int ilkSayi = 35;
            int ikinciSayi = 34;
            float bolmeIki = (float)ilkSayi / ikinciSayi; Casting 
            */
            int mod = 35 % 12;
            //Console.WriteLine("Toplam " + top+"\nCikarma " + cik+"\nCarpma "+carp+"\nBolme "+bol+"\nMod "+mod);
            
            int ucuncuSayi = ilkSayi + 5;
            ucuncuSayi += 10;  //ucuncuSayi = ucuncuSayi + 10;
            ucuncuSayi -= 10;
            ucuncuSayi *= 5;
            ucuncuSayi /= 8;
            Console.WriteLine(ucuncuSayi);

            int dorduncuSayi = 5;
            dorduncuSayi++;
            dorduncuSayi--;


            int agac = 150;
            int alan = 1000;
            
            Console.WriteLine((agac /2.54f) +" inch olan bir agacım " + (alan * 10.764f) +" sqfeet arazimde tek başına duruyor");
            Console.ReadLine();




        }
    }
}
