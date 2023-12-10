using Shared;

namespace RecursiveGenericsFluentBuilder;

public class CarBuilder<TSelf> : BaseCarBuilder
    where TSelf : CarBuilder<TSelf>
{
    private const int WheelsToAddAmount = 2;

    public TSelf AddWheelsPair(int radius)
    {
        for (int i = 0; i < WheelsToAddAmount; i++)
        {
            Car.Wheels.Add(new Wheel { Radius = radius });
        }

        return (TSelf)this;
    }
}

public class CarBuilder : CarBuilder<CarBuilder>{}