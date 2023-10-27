using System;
using System.Collections;
using System.Runtime.CompilerServices;

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

             ArrayList list = new ArrayList();
             list.Add("Ayşe");
             list.Add(5);
             list.Add(false);
             list.Add('a');

             Dictionary<string,string> employers = new Dictionary<string,string>();

             employers.Add("C#", "Ali");
             employers.Add("Swift", "Ahmet");
             employers.Add("Angular", "Nur");
             Console.WriteLine(employers["Angular"]); 


             Employees employee1 = new Employees("TestName1","TestSurname1",1,"TestDeparment1",1500);
            Employees employee2 = new Employees("TestName2", "TestSurname2", 2, "TestDeparment2");

            employee1.EmployeeInfo();
            employee2.EmployeeInfo(); 


           Student student1 = new Student();
              student1.Name = "TestName";
              student1.Surname = "TestSurname";
              student1.Id = 1;
              student1.Grade = 2;
              student1.StudentInfo();
              student1.IncreaseGrade();
              student1.StudentInfo(); 


             Console.WriteLine(Car.hp); //Static olan preopertielere obje oluşturmadan erişebiliriz.
            Console.Read(); */

            RectangleClass rectangleClass = new RectangleClass();
            rectangleClass.ShortSide = 10;
            rectangleClass.LongSide = 20;
            Console.WriteLine(rectangleClass.FieldMeasurement());

            RectangleStruct rectangleStruct = new RectangleStruct(3,5);
            Console.WriteLine(rectangleStruct.FieldMeasurement());

            Console.Read();

        }


        class RectangleClass
        {
            public int ShortSide;
            public int LongSide;

            public long FieldMeasurement()
            {
                return this.ShortSide * this.LongSide;
            }

            public RectangleClass()
            {
                ShortSide = 3;
                LongSide = 5;
            }

        }

        struct RectangleStruct
        {
            public int ShortSide;
            public int LongSide;

            public long FieldMeasurement()
            {
                return this.ShortSide * this.LongSide;
            }
            public RectangleStruct(int shortside, int longside)
            {
                this.ShortSide = shortside;
                this.LongSide = longside;

            }
        }
























        /*class Car
        {
            private static int Hp;
            public static int hp { get => Hp; set => Hp = value; }
            private string Brand;

            static Car()
            {
                Hp = 75;
                Console.WriteLine(Hp);
            }
            public Car(string brand) { 
                this.Brand = brand;
            }
        */
    










       /* class Student
        {
            private string name;
            private string surname;
            private int id;
            private int grade;

            public string Name {
                get { return name; }
                set { name = value; }
            }

            public string Surname { get => surname; set => surname = value; }
            public int Id { get => id; set => id = value; }
            public int Grade { get => grade; set => grade = value; }

            public Student(string name, string surname, int id, int grade)
            {
                this.name = name;
                this.surname = surname;
                this.id = id;
                this.grade = grade;
            }
            public Student(){}

            public void StudentInfo()
            {
                Console.WriteLine("-------------STUDENT'S INFO-------------");
                Console.WriteLine("Name:    {0}",this.Name);
                Console.WriteLine("Surname: {0}",this.Surname);
                Console.WriteLine("ID:      {0}", this.Id);
                Console.WriteLine("Grade:   {0}", this.Grade);
            }
            public void IncreaseGrade()
            {
                this.Grade += 1;
            }
            public void DecreaseGrade()
            {
                this.Grade -= 1;
            }

        } */




    }








        
       /* class Employees
        {
            public string Name;
            public string Surname;
            public int ID;
            public string Department;
            public int Raise;

            public Employees(string name, string surname, int id, string department,int raise) { 
                Name = name;
                Surname = surname;
                ID = id;
                Department = department; 
                Raise = raise;
            }
            public Employees(string name, string surname, int id, string department)
            {
                this.Name = name;
                this.Surname = surname;
                ID = id;
                Department = department;

            }

            public Employees() { }

            public void EmployeeInfo()
            {
                Console.WriteLine("Employee Name: {0}",Name);
                Console.WriteLine("Employee Surname: {0}", Surname);
                Console.WriteLine("Employee ID: {0}", ID);
                Console.WriteLine("Employee Department: {0}", Department);

                if(Raise == 0)
                {
                    Console.WriteLine("{0}'s salary did not increase", Name);
                }
                else
                {
                    Console.WriteLine("Employee's Raise : {0}", Raise);
                }




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

        } */
    }





    
    
