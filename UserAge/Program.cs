using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //"Oled sündinud aastal {2001}"
            
            Console.WriteLine("Palun, sisesta oma vanus.");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - userAge;

            //string interpolation

            Console.WriteLine($"Oled sündinud {yearOfBirth} aastal.");     
        }
    }
}
