// //Exercise 1: Given a month number (1-12), print its name.  


using System; 


class HelloWorld 
{ 
    static int main() 
    { 
        int month = 5; 

        if (month == 1){ 
            Console.WriteLine("January"); 
 
        } 
        elif (month == 2){ 
            Console.WriteLine("February"); 
        } 
        elif (month == 3){ 
            Console.WriteLine("March"); 
        } 
        elif (month == 4){ 
            Console.WriteLine("April"); 
        } 
        elif (month == 5){ 
            Console.WriteLine("May"); 
        } 
        elif (month == 6){ 
            Console.WriteLine("June"); 
        } 
        elif (month == 7){ 
            Console.WriteLine("July"); 
        }
        elif (month == 8){ 
            Console.WriteLine("August"); 
        } 
        elif (month == 9){ 
            Console.WriteLine("September"); 
        } 
        elif (month == 10){ 
            Console.WriteLine("October"); 
        } 
        elif (month == 11){ 
            Console.WriteLine("November"); 
        } 
        elif (month == 12){ 
            Console.WriteLine("December"); 
        } 
        else{ 
            Console.WriteLine("Invalid Month Number:" + month); 
        }
    } 

}