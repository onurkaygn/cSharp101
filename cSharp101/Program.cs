using System;

namespace cSharp101
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler ve Veri Tiplerş
            int year = 1955;
            string name = "Bill";
            String surname = "Gates";
            byte age = 67;
            DateTime today = DateTime.Now;
            Console.WriteLine("I am " + name + surname + " and my year of birth is " + year + " so my age is " + age + ".");
            Console.WriteLine("Wow today is " + today);
            //Operatörler
            int x = 5;
            bool booleanX = x == 4;
            Console.WriteLine(booleanX);
            //Tip Dönüşümleri
            int numberInt = 28;
            double numberDouble;
            numberDouble = numberInt;
            

        }
    }
}