using System;
namespace Uppgift2_2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hur långt hoppade Elin, mätt i meter");
            string Elin = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma, mätt i meter");
            string Alma = Console.ReadLine();
            int A = int.Parse(Elin);
            int B = int.Parse(Alma);
            int skillnad = A - B;

            Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma");




        }





    }








}