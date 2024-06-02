using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_based_programming
{
    public class MathWork
    {
        //AsalSayıToplami(12);

        public static void AsalSayıToplami(int sayı)
        {
            int toplam = 0;

            if (sayı <= 0)
            {
                Console.WriteLine("sayı negatif");
                return;
            }

            for (int i = 2; i <= sayı - 1; i++)
            {
                if (sayı % i == 0)
                {
                    Console.WriteLine("Bu asal sayı değildir");
                    return;
                }
            }

            for (int i = 2; i <= sayı; i++)
            {
                if (SayımAsalmı(i))
                {
                    toplam += i;
                }
            }

            Console.WriteLine("Asıl sayısının toplamı : {0}", toplam);
        }

        public static bool SayımAsalmı(int sayı)
        {
            for (int i = 2; i * i <= sayı; i++)
            {
                if (sayı % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
