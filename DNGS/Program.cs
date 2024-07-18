using System;

namespace DNGS
{
    class Program
    {
        static void Main(string[] args)
        {
          //for (int i = 1; i <= 100; i++)
          //{
          //Console.WriteLine("{0}->{1}", i, i * i);
          //}


            int tekToplam = 0, ciftToplam = 0;
            Console.WriteLine( "Limit:");
            int limit=Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("Tek Sayılar");
            for (int i = 1; i < limit; i+=2)
            {
                Console.WriteLine("{0,5}", i);
                tekToplam += i; //tekToplam = tekToplam + i;
            }

            Console.WriteLine("/n /n Çift Sayılar");
            for (int i = 2; i < limit; i += 2)
            {
                Console.WriteLine("{0,5}", i);
                ciftToplam += i; //ciftToplam = ciftToplam + i;
            }

            Console.WriteLine("/n /n Tek Toplam : {0:5} \n Çift Toplam:{1,5}", tekToplam, ciftToplam);
        }
    }
}
