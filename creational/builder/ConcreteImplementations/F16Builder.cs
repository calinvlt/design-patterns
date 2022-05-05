namespace builder.ConcreteImplementations;

public class F16Builder : AircraftBuilder
{
    private readonly F16 f16;

    public F16Builder()
    {
        f16 = new F16();
    }

    public override void BuildEngine()
    {
        // add F16 engine
    }

    public override void BuildCockpit()
    {
        // add F16 cockpit
    }

    public override void BuildWings()
    {
        // add F16 wings
    }

    public override IAircraft Build()
    {
        return f16;
    }
}