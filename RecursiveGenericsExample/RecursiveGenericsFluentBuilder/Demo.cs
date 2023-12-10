using Shared;

namespace RecursiveGenericsFluentBuilder;

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
        Car car2 = advancedBuilder.AddDoor(DoorType.Butterfly)
            .AddWheelsPair(exampleWheelsRadius)
            .AddWheelsPair(exampleWheelsRadius)
            .AddDoor(DoorType.Butterfly)
            .Build(); // Works now!

        // Bonus section!
        var veryAdvancedBuilder = new VeryAdvancedCarBuilder();
        Car car3 = veryAdvancedBuilder.AddDoor(DoorType.Butterfly)
            .AddWheelsPair(exampleWheelsRadius)
            .AddWheelsPair(exampleWheelsRadius)
            .AddDoor(DoorType.Butterfly)
            .AddColor("#000000")
            .Build(); // Works too!

        Console.WriteLine(car1);
        Console.WriteLine(car2);
        Console.WriteLine(car3);
    }
}