using System; 

namespace Consoleapp2{ 
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

// same way diff code   

namespace Consoleapp2 
{ 
    class Program 
    { 
        static void Main() 
        { 
            Student student1 = new Student { rollno = 1, Name = "John", Marks = 90  }; 

            Student student2 = new Student { rollno = 4, Name = "johattan", Marks = 90 };  
            
            student1.PrintDetials(); 
            student2.PrintDetials(); 
        }
    }
} 

