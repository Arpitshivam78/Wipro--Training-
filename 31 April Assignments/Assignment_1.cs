// Palindrome  


using System;

class Program
{
    static bool IsPalindrome(string name)
    {
        int i = 0;
        int j = name.Length - 1;

        while (i < j)
        {
            if (name[i] != name[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }

    static void Main()
    {
        string name = "racecar"; 

        if (IsPalindrome(name))
        {
            Console.WriteLine($"\"{name}\" is a palindrome.");
        }
        else
        {
            Console.WriteLine($"\"{name}\" is not a palindrome.");
        }
    }
}
