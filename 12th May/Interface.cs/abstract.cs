abstract class Shape 
{ 
    public abtract void Draw(); 

    public void Display() 
    { 
      Console.WriteLine("This is a shape");      
    }  

class Circle : Shape 
{ 
    public void Draw() 
    { 
        Console.WriteLine("Drawing a Circle"); 
    } 


} 

class Program
{ 
    static void Main() 
    { 
        Circle circle = new Circle(); 
        circle.Draw(); 

    } 
     

} 

} 
