using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, 
            //siis ta võib Instagram'i kasutada
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor.

            Console.WriteLine("Sisesta oma sünniaasta:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge >= 13)
            {
                Console.WriteLine("Tere tulemast Instargam'i.");
            } 
            else
            {
                Console.WriteLine("oled liiga noor.");
            }


        }
    }
}
