/* 
 Exercise 6: Greedy Algorithm - Coin Change
Problem Statement:
Use a greedy algorithm to find the minimum number of coins needed to make a given
amount.
Instructions:
1. Available denominations: {1, 2, 5, 10, 20, 50, 100, 200, 500}
2. Input:
Amount (e.g., 880 )
3. Output:
List of coins used and total count
4. Example:
Coins used: 500, 200, 100, 50, 20, 10
Total coins: 6
*/ 


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int amount = 880;
        int[] denomination = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };

        List<int> usedCoin = new List<int>();

        for (int i = denomination.Length - 1; i >= 0; i--)
        {
            while (amount >= denomination[i])
            {
                amount -= denomination[i];
                usedCoin.Add(denomination[i]);
            }
        }  

        Console.WriteLine("Coins used: " + string.Join(", ", usedCoin));
        Console.WriteLine("Total coins: " + usedCoin.Count);

    }
}