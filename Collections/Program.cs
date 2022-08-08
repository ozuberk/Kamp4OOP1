using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Fırat", "Alper", "Ahmet" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);


            //dizi oluştumak için üstteki gibi yapabiliriz fakat sonradan eleman ekleyemeyiz 
            //alttaki gibi yaparsak daha rahat ederiz
            List<string> isimler2 = new List<string> { "Fırat", "Alper", "Ahmet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Samet");
            Console.WriteLine(isimler2[3]);









        }


    }
}