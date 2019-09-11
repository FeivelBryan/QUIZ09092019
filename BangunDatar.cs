using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
   
        public void LuasPersegi()
        {
             int sisi, luas;

             Console.WriteLine("--Luas Persegi--");
        
             Console.Write("SISI = ");
             sisi = Convert.ToInt32(Console.ReadLine());

             luas = sisi * sisi;

             Console.WriteLine("Jadi, luas Persegi adalah "+luas);



        }

        public void LuasSegitiga()
        {
            int alas, tinggi, luas;

            Console.WriteLine("--Luas Segitiga--");

            Console.Write("alas = ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas * tinggi / 2;

            Console.WriteLine("Jadi, luas segitiga adalah "+luas);
        }

        public void LuasLingkaran()
        {
            int jari, luas;

            Console.WriteLine("--Luas Lingkaran--");
            
            Console.Write("Jari = ");
            jari = Convert.ToInt32(Console.ReadLine());

            luas = 22/7 * jari * jari;

            Console.WriteLine("Jadi, lingkaran adalah "+luas);



        }
        
    }

}