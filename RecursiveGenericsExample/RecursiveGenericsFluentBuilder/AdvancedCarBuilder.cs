using Shared;

namespace RecursiveGenericsFluentBuilder;

public class AdvancedCarBuilder<TSelf> : CarBuilder<AdvancedCarBuilder<TSelf>>
where TSelf : AdvancedCarBuilder<TSelf>
{
    // Bonus example with another level of inheritance ;)
    // Take a look at the "VeryAdvancedCarBuilder" class as well!
    public TSelf AddDoor(DoorType doorType)
    {
        Car.Doors.Add(new Door { Type = doorType });
        return (TSelf)this;
    }
}

public class AdvancedCarBuilder : AdvancedCarBuilder<AdvancedCarBuilder>
{
}

/*
// Post's example
public class AdvancedCarBuilder : CarBuilder<AdvancedCarBuilder>
{ 
    // Once more, read it as "which returns ...",
    // public class AdvancedCarBuilder : CarBuilder (which returns AdvancedCarBuilder)
    // This way, methods inherited from CarBuilder, will return AdvancedCarBuilder.
    // And AdvancedCarBuilder's methods will return AdvancedCarBuilder.
    public AdvancedCarBuilder AddDoor(DoorType doorType)
    { 
        Car.Doors.Add(new Door { Type = doorType });
        return this;
    }
}
*/