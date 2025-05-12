interface Ishape 
{ 
    view Draw(); 
} 

class Circle : Ishape 
{ 
    public void Draw(); 
    { 
        Console.WriteLine("Drawing Circle"); 
    } 

    static void Main() 
    { 
        Circle circle = new Circle(); 
        circle.Draw(); 
        
    }
}