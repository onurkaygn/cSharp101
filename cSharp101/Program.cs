using System;

namespace cSharp101
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler ve Veri Tipleri
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
            //Hata Yönetimi ve Kod İzleme
            try
            {
                Console.WriteLine("What is your favorite number?");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your favorite number is: " + input);
            }
            catch(Exception ex) {
                Console.WriteLine("Your exception is: " + ex.Message.ToString());

            }
            finally
            {
                Console.WriteLine("");
            }
            //Karar Yapıları
            int newDate = DateTime.Today.Year;
            if(newDate == 2023)
            {
                Console.WriteLine("It's 2023!");
            }
            else
            {
                Console.WriteLine("It's not 2023!");
            }

            Console.WriteLine("Enter a number between 1 and 5...");
            int yourNumberInput = Convert.ToInt32(Console.ReadLine());
          
          
           
                switch(yourNumberInput)
                {
                    case 1:
                        Console.WriteLine("Your number is: " + yourNumberInput); 
                        break;
                    case 2:
                        Console.WriteLine("Your number is: " + yourNumberInput);
                        break;
                    case 3:
                        Console.WriteLine("Your number is: " + yourNumberInput);
                        break;
                    case 4:
                        Console.WriteLine("Your number is: " + yourNumberInput);
                        break;
                    case 5:
                        Console.WriteLine("Your number is: " + yourNumberInput);
                        break;
                        default:
                    Console.WriteLine( yourNumberInput + " is not a valid number.");
                    break;
                }

            }

        }





    }
    
