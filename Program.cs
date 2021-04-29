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

            int i = 0
            for (; i < 3; i++)
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
                }
            }
            if (i == 3)
            {
                Console.WriteLine("Application will Exit.");
                Environment.Exit(0);
            }
            
            Console.WriteLine();
            Console.WriteLine("Recently Loans");
            string[,] bankloans =
            {
                {
                    "5/25/2016","1/10/2018","4/13/2019","1/25/2020","11/10/2022"
                },
                {
                    "6,000","5,000","7,000","10,000","4,500"
                }
            };
            for (int titleIndex = 0; titleIndex < bankloans.GetLength(0) - 1; titleIndex++)
            {
                for (int loansIndex = 0; loansIndex < bankloans.GetLength(1); loansIndex++)
                {
                    Console.WriteLine($"{bankloans[titleIndex, loansIndex]}" +
                        $" - {bankloans[titleIndex + 1, loansIndex]}");
                }    
            }
            
            Console.WriteLine();
            Console.WriteLine("Transaction");
            Console.Write("Repayment: ");
            int repayment = Convert.ToInt32(Console.ReadLine());
            if (repayment >= 1)
            {
                Console.WriteLine("Successfully Repayment");
            }
            else if (repayment <= 1)
            {
                Console.WriteLine("System will Proceed");
            }
            else
            {
                Console.WriteLine("Invalid Input. Please Try Again");
            }
            
            Console.WriteLine();
            Console.Write("Deposit: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            if (deposit >= 1)
            {
                Console.WriteLine("Successfully Deposit");
            }
            else if (deposit <= 1)
            {
                Console.WriteLine("System will Proceed");
            }
            else
            {
                Console.WriteLine("Invalid Input. Please Try Again");
            }
            
            Console.WriteLine();
            Console.Write("Withdraw: ");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            if (withdraw >= 1)
            {
                Console.WriteLine("Successfully Withdraw");
            }
            else if (withdraw <= 1)
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
