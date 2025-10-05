/*
 *  Class name: Banking App
 *  Version 1
 *  Author: Josh Reid
 */

// Function and methods should be verbs.
// With C# Pascal case should be used with function names
// starting with a capital letter for each word.
// Function names should not have underscores.

using System.Xml.Serialization;

void BuildBankingApp()
{
    // Display the menu screen
    int userChoice;
    double depositAmount;
    double accountBalance = 1000.00;

    Console.WriteLine("Please Choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    // Read users choice menu choice
    // Convert the string to an integer
    // using explicit typecasting

    userChoice = Convert.ToInt32(Console.ReadLine());

    if (userChoice == 1 || userChoice == 2)
    {
        // Valid menu choice
        if (userChoice == 1)
        {
            // Deposit or withdraw funds
            Console.WriteLine("You chose to deposit or withdraw funds");
            Console.WriteLine("How much would you like to deposit");
            Console.WriteLine("Enter the amount including pence using a decmal point");

            // Typically a currency value is input as a decimal
            // so the "double" type is required to store the deposit amount
            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance was {accountBalance}");

            accountBalance += depositAmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");
        } else if (userChoice == 2)
        {
            // View current account information
            Console.WriteLine("You chose to view current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
        else
        {
            // View current account information
            Console.WriteLine("You chose to view current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }

    }
    else
    {
        // Invalid menu choice
        Console.WriteLine("Invalid menu choice. Please choose 1 or 2");
    }
}

BuildBankingApp();