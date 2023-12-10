using Shared;

namespace RecursiveGenericsFluentBuilder;

public class AdvancedCarBuilder : AdvancedCarBuilder<AdvancedCarBuilder>
{
}

public class AdvancedCarBuilder<TSelf> : CarBuilder<AdvancedCarBuilder<TSelf>>
where TSelf : AdvancedCarBuilder<TSelf>
{
    public TSelf AddDoor(DoorType doorType)
    {
        Car.Doors.Add(new Door { Type = doorType });
        return (TSelf)this;
    }
}