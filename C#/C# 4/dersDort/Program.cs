using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersDort
{
    internal class Program
    {
        public static int sayi2;
        static void Main(string[] args)
        {
            //string[] siparisNo = new string[3]; //memory

            //siparisNo[0] = "INZ123";
            //siparisNo[1] = "GOG123";
            //siparisNo[2] = "SES123";

            //siparisNo[0] = "INZ345"; //degisiklik  


            //string[] siparisNo = { "birincisiparis", "ikincisiparis", "ucuncusiparis" };
            //int[] fiyat = { 250, 300, 700 };
            //int toplamfiyat = 0;
            //int say = 0;

            //foreach (string siparis in siparisNo)
            //{
            //    Console.WriteLine(siparis); //3 kere dönecek
            //}

            //foreach (var tekilFiyat in fiyat)
            //{
            //    toplamfiyat += tekilFiyat;
            //    say++;
            //}




            //int sayi = 5;
            //string isim = "Sefa Erkan";
            //Console.WriteLine("a" == "a"); // 2 tane string karşılaştırması
            //Console.WriteLine("b" == "B"); // 2 tane string karşılaştırması
            //Console.WriteLine(1.2f == 1.3f);
            //Console.WriteLine(1 != sayi);
            //Console.WriteLine(isim.Contains("Sef")); //İsimin içinde var mı?
            //Console.WriteLine(sayi == 6 ? "Tolgay" : "Sefa"); //Conditional Operator
            //Console.WriteLine(sayi == 5 ? 1 : 2); //Conditional Operator
            //Console.ReadLine();

            int sayi = 5;
            if(sayi == 5)
            {
                sayi2 = 20;
                
            }
            Console.WriteLine(sayi2);
            Console.ReadLine();

        }
    }
}
