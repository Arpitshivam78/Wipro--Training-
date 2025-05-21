/* 
Exercise 5: Recursion - Tower of Hanoi

Problem Statement: 
Solve the classic Tower of Hanoi problem using recursion.
Instructions:
1. Write a method:
void TowerOfHanoi(int n, char from, char to, char aux)
2. Input:
Number of disks n
3. Output:
Print the steps to move all disks from source to destination using
auxiliary rod
4. Example for n = 3 :
Move disk 1 from A to C
Move disk 2 from A to B
Move disk 1 from C to B 
*/

using System;
using System.Collections.Generic;

class Assignment_1
{
    static void Main()
    {
        TowerOfHanoi(3, 'A', 'C', 'B');



    }
    static void TowerOfHanoi(int n, char from, char to, char aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move Disk1 {from} to {to} ");
            return;

        }
        
        
            TowerOfHanoi(n - 1, from, aux, to);
            Console.WriteLine($"Move Disk {n} from {from} to {to} ");
            TowerOfHanoi(n - 1, aux, to, from);

        

       

    } 
    
}