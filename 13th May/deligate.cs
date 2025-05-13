using System;

delegate void customDel(string s);

class Test
{
    static void HELLO(string s)
    {
        Console.WriteLine($"Hello, {s}");
    }

    static void GoodBye(string s)
    {
        Console.WriteLine($"Good Bye, {s}");
    }

    static void Main()
    {
        customDel hiDel, byeDel, multiDel, multiMinusHiDel;

        hiDel = HELLO;
        byeDel = GoodBye;

        // Multicast delegate
        multiDel = hiDel + byeDel;

        // Subtracting byeDel from multiDel
        multiMinusHiDel = multiDel - byeDel;

        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("Arpit");

        Console.WriteLine("Invoking delegate byeDel:");
        byeDel("Arpit");

        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("Arpit");

        Console.WriteLine("Invoking delegate multiMinusHiDel:");
        multiMinusHiDel("Arpit");
    }
}
