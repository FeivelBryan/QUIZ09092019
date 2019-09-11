using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
           public void VolumeBalok()
           {
               int panjang, lebar, tinggi, volume;

                Console.WriteLine("--Volume Balok--");

               Console.Write("panjang = ");
               panjang = Convert.ToInt32(Console.ReadLine());

               Console.Write("Lebar = ");
               lebar = Convert.ToInt32(Console.ReadLine());

               Console.Write("Tinggi = ");
               tinggi = Convert.ToInt32(Console.ReadLine());

                volume = panjang * lebar * tinggi;

                    Console.WriteLine("Jadi, volume balok adalah "+volume);

           }

            public void VolumeKubus()
            {
                int sisi, volume;

                Console.WriteLine("--Volume Kubus--");

                Console.Write("SISI = ");
                sisi = Convert.ToInt32(Console.ReadLine());

                volume = sisi * sisi * sisi;

                Console.WriteLine("Jadi, volume kubus adalah "+volume);

            }



    }
}