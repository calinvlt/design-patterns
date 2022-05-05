namespace builder;

public abstract class AircraftBuilder
{
    public virtual void BuildEngine()
    {
        // add F16 engine
    }

    public virtual void BuildCockpit()
    {
        // add F16 cockpit
    }

    public virtual void BuildWings()
    {
        // add F16 wings
    }
    
    public abstract IAircraft Build();
}