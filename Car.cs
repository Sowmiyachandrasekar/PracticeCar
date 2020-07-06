using System;
public class Car : IVehicle
{
    public string Start()
    {
        return string.Format("Car is Started");
    }
    public string Accelerate()
    {
        return string.Format("---The Car is moving---");
    }
    public string Stop()
    {
        return string.Format("Car is Stopped");
    }
    
}