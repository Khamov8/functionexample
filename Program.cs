using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsoleApplication
{
    class Program
    {
        public static string CreateFio(string surname, string name, string otchestvo)
        {
            string fio = surname + " " + name + " " + otchestvo;
            return fio;
        }

        public static string CreateFioInitials(string surname, string name, string otchestvo)
        {
            string fio = surname + " " + name.Substring(0, 1) + ". " + otchestvo.Substring(0, 1) + ".";
            //Временно оставим в стороне код "Substring(0, 1)" - он просто вырезает первый символ из строки.
            return fio;
        }


        static void Main(string[] args)
        {


            string name = "Александр";
            string otchestvo = "Сергеевич";
            string surname = "Пушкин";


            string name2 = "Наталья";
            string otchestvo2 = "Николаевна";
            string surname2 = "Гончарова";

            string name3 = "Sultan";
            string otchestvo3 = "Kaskyruli";
            string surname3 = "Baimukhanov";


            System.Console.WriteLine(CreateFio(surname, name, otchestvo));
            System.Console.WriteLine(CreateFioInitials(surname, name, otchestvo));
            System.Console.WriteLine(CreateFio(surname2, name2, otchestvo2));
            System.Console.WriteLine(CreateFioInitials(surname2, name2, otchestvo2));
            System.Console.WriteLine(CreateFio(surname3, name3, otchestvo3));
            System.Console.WriteLine(CreateFioInitials(surname3, name3, otchestvo3));

            System.Console.ReadLine();

        }

    }
}

