using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kautajal sisestada PIN-koodi
            //programm võrdleb sisustatud PIN-koodi arvuga 1234
            //kui sisestatud PIN-kood on 1234,
            //programm kuvab konsoolis "Tere tulemast!
            //kui sisustatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti"

            Console.WriteLine("Palun, sisesta PIN:");
            int userPIN = Convert.ToInt32(Console.ReadLine());

            if(userPIN != 1234) //!= ei võrdu
            {
                Console.WriteLine("Vale PIN. Proovi uuesti.");
            }
            else
            {
                 Console.WriteLine("Tere tulemast!");
            }


        }
    }
}
