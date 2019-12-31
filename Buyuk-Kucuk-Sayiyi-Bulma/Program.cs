using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyuk_Kucuk_Sayiyi_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write((i + 1).ToString() + ". Sayıyı giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int enbuyuk, enkucuk;
            enkucuk = sayilar[0];
            enbuyuk = sayilar[0];
            for (int i = 1; i < 4; i++)
            {
                if (enbuyuk < sayilar[i])
                {
                    enbuyuk = sayilar[i];
                }
                else if (enkucuk > sayilar[i])
                {
                    enkucuk = sayilar[i];
                }
            }
            Console.WriteLine("En küçük sayı: " + enkucuk);
            Console.WriteLine("En büyük sayı: " + enbuyuk);
            Console.ReadLine();
        }
    }
}
