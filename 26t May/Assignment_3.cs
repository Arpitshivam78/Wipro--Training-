/* 
3. Composition + File I/O – Bank Account Logger
 Task:
 Create BankAccount class with Deposit() and Withdraw().
 Store all transactions in a List<Transaction>.
 Save and load transaction history from a .txt file.
 Display summary on restart
*/

using System;
using System.Collection.Generic;
using System.Linq;

class Program
{
    static void Deposit(double amount)
    {
        Console.WriteLine("Deposited: " + amount);
    }

    static void Withdraw(double amount)
    {
        Console.WriteLine("Withdrawn: " + amount);
    }

    static void Main(string[] args)
    {
        // Initialize the list of transactions
        List<Transaction> transactions = new List<Transaction>();

        // Deposit and withdraw some money
        Deposit(100.0);
        Withdraw(50.0);

        // Save transactions to a file
        SaveTransactions(transactions, "transactions.txt");

        // Load transactions from a file
        List<Transaction> loadedTransactions = LoadTransactions("transactions.txt");

        // Display summary
        DisplaySummary(loadedTransactions);

        Console.ReadLine(); 
        
        
    }
}