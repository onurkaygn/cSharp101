﻿using System;

namespace cSharp101
{
    class Program
    {

        static void Main(string[] args)
        {
            /*

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
            catch (Exception ex)
            {
                Console.WriteLine("Your exception is: " + ex.Message.ToString());

            }
            finally
            {
                Console.WriteLine("");
            }
            //Karar Yapıları
            int newDate = DateTime.Today.Year;
            if (newDate == 2023)
            {
                Console.WriteLine("It's 2023!");
            }
            else
            {
                Console.WriteLine("It's not 2023!");
            }

            Console.WriteLine("Enter a number between 1 and 5...");
            int yourNumberInput = Convert.ToInt32(Console.ReadLine());

            switch (yourNumberInput)
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
                    Console.WriteLine(yourNumberInput + " is not a valid number.");
                    break;
            }
            //Döngüler
            Console.WriteLine("Enter a number for even and odd counter...");
            int userForInput = int.Parse(Console.ReadLine());
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < userForInput; i++)
            {
                if (i % 2 == 0)
                {
                    evenCount += 1;
                }
                else
                {
                    oddCount += 1;
                }
            }
            Console.WriteLine("There is a " + evenCount + " even number between 0 and " + userForInput);
            Console.WriteLine("There is a " + oddCount + " odd number between 0 and " + userForInput);


            Console.Write("Bir sayı girin: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int counter = 1;

            while (counter <= number)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine("Sum of numbers between 0 and " + number + " is " + sum);


            string[] brands = { "ASUS", "ViewSonic", "Samsung", "Lenovo" };

            foreach (var brand in brands)
            {
                Console.WriteLine(brand);
            }
            //Metodlar


            int result = Topla(7, 2);
            Console.WriteLine("Girdiğiniz sayıların toplamı: " + result);

            Calculations powerCalc = new();

            Console.WriteLine(powerCalc.Expo(3, 4));
            Console.WriteLine(powerCalc.Expo(2, 4));
            Console.WriteLine(powerCalc.Expo(7, 2));

            //String Metodları
            */


            //Koleksiyonlar
            List<int> numberList = new List<int>();
            
            numberList.Add(1);
            numberList.Add(3);
            numberList.Add(5);
            numberList.Add(2);


            List<string> colorList = new List<string>();

            colorList.Add("Black");
            colorList.Add("Yellow");
            colorList.Add("Red");
            colorList.Add("Green");
            colorList.Add("Blue");
            colorList.Add("Orange");
            colorList.Add("Salmon");

            Console.WriteLine(numberList.Count());
            Console.WriteLine(colorList.Count());

           
            numberList.Remove(5);
            colorList.RemoveAt(3);
            foreach (var color in colorList)
            {
                Console.WriteLine(color);
            }
            numberList.ForEach(number => Console.WriteLine(number));

            if(colorList.Contains("Yellow"))
            {
                Console.WriteLine("Yellow found!");
            }

            Console.WriteLine(numberList.BinarySearch(3));

            string[] animals = { "Cat", "Dog", "Bird" };

            List<string> animalList = new List<string>(animals);
            Console.WriteLine(animalList[1]);

            List<Users> userList = new List<Users>();
            Users user1 = new Users();
            user1.Name = "user1sName";
            user1.Surname = "user1sSurname";
            user1.Age = 21;

            Users user2 = new Users();
            user2.Name = "user2sName";
            user2.Surname = "user2sSurname";
            user2.Age = 20;

            userList.Add(user1);
            userList.Add(user2);

            List<Users> newUserList = new List<Users>();

            newUserList.Add(new Users()
            {
                Name = "newName",
                Surname = "newSurname",
                Age = 22
            });

            foreach(Users user in userList)
            {
                Console.WriteLine(user.Name);
            }

        }

      
        public class Users
        {
            string name;
            string surname;
            private int age;

            public string Name { get => name; set => name = value; }
            public string Surname { get => surname; set => surname = value; }
            public int Age { get => age; set => age = value; }
        }

        static int Topla(int number1, int number2)
        {
            return (number1 + number2);
        }
        public class Calculations
        {
           public int Expo(int number, int power)
            {
                if (power < 2) return number;
                return Expo(number, power - 1) * number;

            }

        }
    }





    }
    
