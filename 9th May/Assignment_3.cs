using System;

namespace ShapeApp
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape");
        }

        public void Display()
        {
            Console.WriteLine("Displaying Shape");
        }

        public void Area()
        {
            Console.WriteLine("Calculating Area");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Using Shape Reference");
            Shape shapeRef = new Circle(); 
            shapeRef.Draw();     // Will call Circle's Draw() due to override
            shapeRef.Display();  // Will call Shape's Display()
            shapeRef.Area();     // Will call Shape's Area()

            Console.WriteLine("Using Circle Reference ");
            Circle myCircle = new Circle();
            myCircle.Draw();     
            myCircle.Display();  
            myCircle.Area();   
        }
    }
}
