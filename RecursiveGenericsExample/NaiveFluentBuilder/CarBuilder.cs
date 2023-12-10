using Shared;

namespace NaiveFluentBuilder;

public class CarBuilder
{
    private const int WheelsToAddAmount = 2;

    protected readonly Car Car = new();

    public CarBuilder AddWheelsPair(int radius)
    {
        for (int i = 0; i < WheelsToAddAmount; i++)
        {
            Car.Wheels.Add(new Wheel { Radius = radius });
        }

        return this;
    }

    public Car Build()
    {
        return Car;
    }
}