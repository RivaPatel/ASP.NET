using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Lab_4.Bank;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Write a program using method overloading by changing datatype of arguments to perform addition
            //of two integer numbers and two float numbers.


            //Add Add = new Add();    

            //Console.WriteLine("Choose the type of addition:");
            //Console.WriteLine("1. Integer Addition");
            //Console.WriteLine("2. Float Addition");
            //Console.Write("Enter your choice (1 or 2): ");
            //int choice = int.Parse(Console.ReadLine());

            //if (choice == 1)
            //{
            //    // Get two integers from the user
            //    Console.Write("Enter the first integer: ");
            //    int int1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the second integer: ");
            //    int int2 = int.Parse(Console.ReadLine());

            //    // Perform addition and display the result
            //    int intResult = Add.add(int1, int2);
            //    Console.WriteLine("Addition of two integers: " + intResult);
            //}
            //else if (choice == 2)
            //{
            //    // Get two floats from the user
            //    Console.Write("Enter the first float: ");
            //    float float1 = float.Parse(Console.ReadLine());

            //    Console.Write("Enter the second float: ");
            //    float float2 = float.Parse(Console.ReadLine());

            //    // Perform addition and display the result
            //    float floatResult = Add.add(float1, float2);
            //    Console.WriteLine("Addition of two floats: " + floatResult);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice. Please restart the program and enter 1 or 2.");
            //}




            //2.Write a program using method overloading by changing number of arguments to
            //calculate area of square and rectangle.

            //Area area = new Area(); 


            //Console.WriteLine("Choose the shape to calculate area:");
            //Console.WriteLine("1. Square");
            //Console.WriteLine("2. Rectangle");
            //Console.Write("Enter your choice (1 or 2): ");
            //int choice = int.Parse(Console.ReadLine());

            //if (choice == 1)
            //{
            //    // Get the side length of the square
            //    Console.Write("Enter the side length of the square: ");
            //    int side = Convert.ToInt32(Console.ReadLine());

            //    // Calculate and display the area of the square
            //    int squareArea = area.CalculateArea(side);
            //    Console.WriteLine("The area of the square is: " + squareArea);
            //}
            //else if (choice == 2)
            //{
            //    // Get the length and width of the rectangle
            //    Console.Write("Enter the length of the rectangle: ");
            //    int length = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter the width of the rectangle: ");
            //    int width = Convert.ToInt32(Console.ReadLine());

            //    // Calculate and display the area of the rectangle
            //    int rectangleArea = area.CalculateArea(length, width);
            //    Console.WriteLine("The area of the rectangle is: " + rectangleArea);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice. Please restart the program and choose 1 or 2.");


            //3.Create a class named RBI with calculateInterest() method.
            //Create another classes HDFC, SBI, ICICI which overrides calculateInterest() method.

            //Bank bank = new Bank();

            //// Create instances of each bank class
            //RBI rbi = new RBI();
            //HDFC hdfc = new HDFC();
            //SBI sbi = new SBI();
            //ICICI icici = new ICICI();

            //// Call CalculateInterest() for each bank
            //Console.WriteLine("Interest Calculation:");
            //rbi.CalculateInterest();
            //hdfc.CalculateInterest();
            //sbi.CalculateInterest();
            //icici.CalculateInterest();


            //4.Create a class Hospital with HospitalDetails() method.Create another classes Apollo, Wockhardt,
            //Gokul_Superspeciality which overrides HospitalDetails() method.

            // Create instances of each hospital

            //Hospital hospital = new Hospital();
            //Hospital general = new Hospital();
            //Apollo apollo = new Apollo();
            //Wockhardt wockhardt = new Wockhardt();
            //Gokul_Superspeciality gokul = new Gokul_Superspeciality();

            //// Call HospitalDetails() for each hospital
            //Console.WriteLine("Hospital Details:");
            //general.HospitalDetails();  
            //apollo.HospitalDetails();   
            //wockhardt.HospitalDetails(); 
            //gokul.HospitalDetails();     


            ////5.Write a programs to Find Area of Square, Rectangle and Circle using Method Overloading.
            //Area2 area = new Area2();

            //// Calculate the area of a square
            //Console.Write("Enter the side length of the square: ");
            //double squareSide = double.Parse(Console.ReadLine());
            //double squareArea = area.CalculateArea(squareSide);
            //Console.WriteLine("The area of the square is: " + squareArea);

            //// Calculate the area of a rectangle
            //Console.Write("Enter the length of the rectangle: ");
            //double rectangleLength = double.Parse(Console.ReadLine());
            //Console.Write("Enter the width of the rectangle: ");
            //double rectangleWidth = double.Parse(Console.ReadLine());
            //double rectangleArea = area.CalculateArea(rectangleLength, rectangleWidth);
            //Console.WriteLine("The area of the rectangle is: " + rectangleArea);

            //// Calculate the area of a circle
            //Console.Write("Enter the radius of the circle: ");
            //float circleRadius = float.Parse(Console.ReadLine());
            //float circleArea = area.Calculatearea(circleRadius);
            //Console.WriteLine("The area of the circle is: " + circleArea);



            //6.Create a BankAccount class having constructor accepting initialBalance and accountHolderName.
            //Also create Deposite() and withdraw() overloaded methods by which user can 
            //deposit/withdraw amount using different types of parameters(ex.cash, check).

            Account account = new Account();

            Console.WriteLine("Enter accountHolderName");
            string accountHolderName = Console.ReadLine();

            Console.WriteLine("choose your Process ");
            Console.WriteLine("1.Deposit Cash");
            Console.WriteLine("2.Deposit Check");
            Console.WriteLine("3.Withdraw Cash");
            Console.WriteLine("4.Withdraw check");
            Console.WriteLine("Enter Users Choise from above options : ");
            int Process = Convert.ToInt32(Console.ReadLine());

            if (Process == 0)
            {
                Console.WriteLine("Enter your Deposit Ammount :");
                decimal cashDeposit = Convert.ToDecimal(Console.ReadLine());

                Account.depositcash(decimal cashDeposit);
             }

            






        }

    }
}
