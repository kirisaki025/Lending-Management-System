using System;

namespace LendingManagementSystem
{
    class program
    {
        //Lending Management System
        //>Amount of Loan = 10000
        //>Withdraw = 0
        //>Balance = 5000
        //>Payment
        // >>Montly Payment = 1000
        // >> Number of Payments = 10
        //> Acount Information
        // >>Account Number = XV666A69
        // >>Customer's Name = Patrick Gonzales
        //Password = 05252002

        static void Main(string[] args)
        {
            Console.WriteLine("Lending Management System");
            int amountOfLoan = 10000;
            int balance = 5000;
            int monthlyPayment = 1000;
            int numberOfPayments = 10;
            string accountNumber = "XV666A69";
            string customerName = "Patrick Gonzales";
            string password = "05252002";

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Account Number: ");
                string accountNumberInput = Console.ReadLine();
                Console.Write("Enter Password: ");
                string passwordInput = Console.ReadLine();
                Console.WriteLine();
                if (accountNumberInput == accountNumber && passwordInput == password)
                {
                    Console.WriteLine("Transaction:");
                    Console.WriteLine("Customer's Name: " + customerName);
                    Console.WriteLine("Amount of Loan: " + amountOfLoan);
                    Console.WriteLine("Monthly Payment: " + monthlyPayment);
                    Console.WriteLine("Number of Payments: " + numberOfPayments);
                    Console.WriteLine("Balance: " + balance);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Account Number or Password");
                    Console.WriteLine("Please Try Again");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Input Amount of Money");
            Console.Write("Deposit: ");
            int deposit1 = Convert.ToInt32(Console.ReadLine());
            if (deposit1 >= 1)
            {
                Console.WriteLine("Successfully Deposit");
            }
            else if (deposit1 <= 1)
            {
                Console.WriteLine("System will Proceed");
            }
            else
            {
                Console.WriteLine("Invalid Input. Please Try Again");
            }
            Console.WriteLine();
            Console.Write("Withdraw: ");
            int withdraw1 = Convert.ToInt32(Console.ReadLine());
            if (withdraw1 >= 1)
            {
                Console.WriteLine("Successfully Withdraw");
            }
            else if (deposit1 <= 1)
            {
                Console.WriteLine("System will Proceed");
            }   
            else
            {
                Console.WriteLine("Invalid Input. Please Try Again");
            }    
            Console.WriteLine("Transaction Complete");
        }
    }
}
