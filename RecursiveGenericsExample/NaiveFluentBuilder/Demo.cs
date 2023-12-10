using Shared;

namespace NaiveFluentBuilder;

public static class Demo
{
    public static void Run()
    {
        const int exampleWheelsRadius = 20;
        var builder = new CarBuilder();
        Car car1 = builder.AddWheelsPair(exampleWheelsRadius)
            .AddWheelsPair(exampleWheelsRadius)
            .Build();

        var advancedBuilder = new AdvancedCarBuilder();
        //Car car2 = 
        advancedBuilder.AddDoor(DoorType.Butterfly)
            .AddWheelsPair(exampleWheelsRadius)
            .AddWheelsPair(exampleWheelsRadius);
        //.AddDoor(DoorType.Butterfly); // Doesn't work!

        Console.WriteLine(car1);
        //Console.WriteLine(car2);
    }
}