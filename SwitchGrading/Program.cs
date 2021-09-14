using System;

namespace SwitchGrading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma hinne");
            int userGrade = Convert.ToInt32(Console.ReadLine());

            switch (userGrade)
            {
                case 5:
                    Console.WriteLine("Suurepärane!");
                    break;
                case 4:
                    Console.WriteLine("Väga hea!");
                    break;
                case 3:
                    Console.WriteLine("Hea!");
                    break;
                case 2:
                    Console.WriteLine("Rahuldav!");
                    break;
                case 1:
                    Console.WriteLine("Puudulik!");
                    break;
                default:
                    Console.WriteLine("Kordad kursust");
                    break;

            }


        }
    }
}
