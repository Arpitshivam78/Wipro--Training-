using System; 

class Array_Vowels 

{ 
    static int CountVowels(string str) 
    { 
        int count = 0; 
        string vowels = "aeiouAEIOU"; 
        foreach (char c in str) 
        { 
            if (vowels.Contains(c))  
            count++; 
        } 
        return count;  
    } 
    static void Main() 
    {
        string sentence = "Programming is fun"; 
        Console.WriteLine("The sentence is: " + CountVowels (sentence)); 
        
    }
}