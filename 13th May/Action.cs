class Action
{
    public static void Main()
    {
        Action<int> printActionDel = ConsolePrint;
        Action<int> printToPrinter = PrinterPrint;

        printActionDel(10); 
        printToPrinter(10);
    } 

    public static void ConsolePrint(int i) 
        { Console.WriteLine(i); }  

    public static void PrinterPrint(int i)
    
        {  Console.WriteLine(i); } 
    
    public static void PrintPrinter(int i) { Console.WriteLine("Printer is being Print"); } 
        
}