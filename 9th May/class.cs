using System; 

class Student{ 
    public int rollno; 
    public string Name; 
    public int Marks; 

    public void PrintDetials()
    { 
        Console.WriteLine($"Roll No: + {rollno}"); 
        Console.WriteLine($"Name: + {Name}"); 
        Console.WriteLine($"Marks: + {Marks}");  
    }  

      

} 

public class Program 
{ 
    static void Main() 
    { 
        Student s1 = new Student();  

        s1.rollno = 1; 
        s1.Name = "John"; 
        s1.Marks = 90;   

        s1.PrintDetials(); 

    }
}