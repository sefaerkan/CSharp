using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersİki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yeni inst = new Yeni();

            inst.birinci = 10;
            inst.ikinci = 20;
            //Console.WriteLine(inst.toplama());
            
            Console.WriteLine(Math.Pow(10f,2f)); //10 un 2.kuvveti
            Console.WriteLine(Math.Min(20,10)); //En küçük değer
            Console.WriteLine(Math.Abs(-25.4f)); //Mutlak Değer
            Console.ReadLine();

        }

        class Yeni
        {
            public int birinci;
            public int ikinci;

            public int toplama()
            { 
                return birinci+ikinci; 
            }
        }
    }
}
