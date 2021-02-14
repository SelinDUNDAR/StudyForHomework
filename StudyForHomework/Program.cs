using System;
// 
namespace StudyForHomework
{   //0 girilene kadar sayıların toplamını  bulan program 18-01-21
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 1;
            //int toplam = 0;
            
         
           // while (sayi != 0)
            //{
               
                //Console.Write("sayı gir emmi");
                //sayi = Convert.ToInt32(Console.ReadLine());
               

                //toplam  =toplam + sayi;

            //}
            //Console.WriteLine("toplam:"+toplam + "ediyor ");
            //Console.ReadKey();


            // ekrana 0 girilene kadar yazdıran kod
            int sayi = 1;
            while (sayi!= 0) ;
            {
                Console.Write("please,enter a number---> ");
                Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("entered number= {0}", sayi);
            }








        }
    }

}