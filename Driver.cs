using System;
public class Driver
{
    public static void Main()
    {
        // Car ciaz=new Engine();
        // ciaz.engine = new DieselEngine();
        // // engine = new Engine();
        // Console.WriteLine(engine.Start());
        Car ciaz=new Car();
        Engine engine= new DieselEngine();
        Console.WriteLine(engine.Start());
        Console.WriteLine(engine.engineType());
        Console.WriteLine(ciaz.Start());

    }
}