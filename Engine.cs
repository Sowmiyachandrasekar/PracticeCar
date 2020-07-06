using System;
public class Engine : IVehicle
{	
    public virtual string engineType()
    {
        return string.Format("Select Engine");
    }
    public string Start()
    {
        return string.Format("Engine is Starting");
    }
    public string Accelerate()
    {
        return string.Format("---The Car is moving---");
    }
    public string Stop()
    {
        return string.Format("Engine is Stoping");
    }
} 