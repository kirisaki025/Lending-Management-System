using System;

namespace LendingManagementSystem
{
    class program
    {
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
                    Console.WriteLine("Account Information:");
                    Console.WriteLine("Customer Name: " + customerName);
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
            Console.WriteLine("Transaction:");
            Console.Write("Repayment: ");
            int repayment1 = Convert.ToInt32(Console.ReadLine());
            if (repayment1 >= 1)
            {
                Console.WriteLine("Successfully Repayment");
            }
            else if (repayment1 <= 1)
            {
                Console.WriteLine("System will Proceed");
            }
            else
            {
                Console.WriteLine("Invalid Input. Please Try Again");
            }
            Console.WriteLine();
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
            else if (withdraw1 <= 1)
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