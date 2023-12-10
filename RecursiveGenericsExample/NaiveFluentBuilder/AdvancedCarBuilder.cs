using Shared;

namespace NaiveFluentBuilder;

public class AdvancedCarBuilder : CarBuilder
{
    public AdvancedCarBuilder AddDoor(DoorType doorType)
    {
        Car.Doors.Add(new Door { Type = doorType });
        return this;
    }
}