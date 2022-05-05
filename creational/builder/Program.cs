using builder;
using builder.ConcreteImplementations;

AircraftBuilder builder = new F16Builder();
builder.BuildCockpit();
builder.BuildEngine();
builder.BuildWings();

IAircraft aircraft = builder.Build();

