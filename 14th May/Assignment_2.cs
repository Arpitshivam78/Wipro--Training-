/* 
Exercise 2: Interface - Banking Operations
💡 Problem Statement:
Create an interface to perform basic banking operations.
Instructions:
Create an interface IBankAccount with methods:
Deposit(double amount)
Withdraw(double amount)
CheckBalance()
Implement the interface in two classes:
SavingsAccount: Implements all methods with basic print statements
CurrentAccount: Implements all methods with basic print statements
In the Main() method:
Create objects of SavingsAccount and CurrentAccount using the IBankAccount reference.
Perform deposit, withdrawal, and balance check for both accounts.


*/ 


class IBankAccount 
{ 
    public void Deposit(double amount) 
    { 
        Console.WriteLine("Deposited: " + amount); 
    }  

    public void Withdraw(double amount) 
    { 
        Console.WriteLine("Withdrawn: " + amount); 
    } 

    public void CheckBalance() 
    { 
        Console.WriteLine("Checking balance..."); 
    } 


} 

class SavingsAccount : IBankAccount 
{ 
    public void Deposit(double amount) 
    { 
        Console.WriteLine("Deposited: " + amount + " in Savings Account"); 
    } 

    public void Withdraw(double amount) 
    { 
        Console.WriteLine("Withdrawn: " + amount + " from Savings Account"); 
    } 

    public void CheckBalance() 
    { 
        Console.WriteLine("Checking balance in Savings Account..."); 
    }  
} 

class CurrentAccount : IBankAccount 
{ 
    public void Deposit(double amount) 
    { 
        Console.WriteLine("Deposited: " + amount + " in Current Account"); 
    } 

    public void Withdraw(double amount) 
    { 
        Console.WriteLine("Withdrawn: " + amount + " from Current Account"); 
    } 

    public void CheckBalance() 
    { 
        Console.WriteLine("Checking balance in Current Account..."); 
    }  
}

class Program 
{ 
    static void Main(string[] args) 
    { 
        IBankAccount savingsAccount = new SavingsAccount(); 
        IBankAccount currentAccount = new CurrentAccount(); 

        savingsAccount.Deposit(1000); 
        savingsAccount.Withdraw(500); 
        savingsAccount.CheckBalance(); 

        currentAccount.Deposit(2000); 
        currentAccount.Withdraw(1000); 
        currentAccount.CheckBalance(); 
    } 
} 