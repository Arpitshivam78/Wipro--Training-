using System;

class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine("Operating Appliance");
    }
}

class WashingMachine : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing Clothes");
    }
}

class Program
{
    static void Main()
    {
        Appliance myAppliance = new Appliance();
        myAppliance.Operate(); // Output: Operating Appliance

        WashingMachine myWashingMachine = new WashingMachine();
        myWashingMachine.Operate(); // Output: Washing Clothes


        Appliance myAppliance2 = new WashingMachine();
        myAppliance2.Operate(); // output: Washing Clothes 
    }
}
