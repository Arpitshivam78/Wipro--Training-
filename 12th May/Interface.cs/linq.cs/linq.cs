using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] name = { "John", "Jane", "Jack", "Jill", "James" };

        UsingLinq(name);
    }

    /*private static void UsingLinq(string[] name)
    {
        IEnumerable<string> query = from n in name
                                    where n.Length == 4 
                                    orderby n
                                    select n;

        foreach (string n in query)
            Console.WriteLine(n);

        Console.Read();
    }
}
/* 
function myfun(string s){
return s.Length == 5
}


(s) => {s.Length == 5}

s => s.Length == 5
*/  

private static void UsingLinq(string[] name) 
{ 
    Func<string, bool> myfun = s => s.Length == 4; 
    Func<string, string> extract = s => s; 
    Func<string, string> project = s => s.ToUpper(); 

    IEnumerable<string> query = name
        .Where(myfun)
        .Select(extract)
        .OrderBy(project); 

    foreach (string n in query) 
        Console.WriteLine(n); 

    Console.Read();      
}
