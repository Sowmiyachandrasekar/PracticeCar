using System;
public class Driver
{
    public static void Main()
    {
        Car ciaz=new Car();
        Engine engine= new DieselEngine();
        Console.WriteLine(engine.Start());
        Console.WriteLine(engine.engineType());
        Console.WriteLine(ciaz.Start());
    }
}