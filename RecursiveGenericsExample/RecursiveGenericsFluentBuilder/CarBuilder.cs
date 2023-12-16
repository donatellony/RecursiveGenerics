using Shared;

namespace RecursiveGenericsFluentBuilder;

// The idea is that we pass a type, that will extend CarBuilder
// As the CarBuilder's generic parameter
public class CarBuilder<TSelf> : BaseCarBuilder
    where TSelf : CarBuilder<TSelf>
{   // For example, imagine that TSelf is "AdvancedCarBuilder".
    // Try to visually replace the <TSelf> with "which returns TSelf".
    // It looks less confusing this way.
    // Like:
    // public class CarBuilder (which returns AdvancedCarBuilder) : BaseCarBuilder
    // where AdvancedCarBuilder : CarBuilder (which returns AdvancedCarBuilder)
    private const int WheelsToAddAmount = 2;

    // Using TSelf to specify the inheritor's return type. 
    public TSelf AddWheelsPair(int radius)
    {
        for (int i = 0; i < WheelsToAddAmount; i++)
        {
            Car.Wheels.Add(new Wheel { Radius = radius });
        }

        // Knowing that TSelf (AdvancedCarBuilder) extends CarBuilder,
        // Parse the return type from CarBuilder back to TSelf (AdvancedCarBuilder)
        return (TSelf)this;
    }
}

// Because we still need the "simple" CarBuilder class to be functional,
// We can provide CarBuilder as the generic parameter to itself.
// Read it as in the example above:
// public class CarBuilder : CarBuilder (which returns CarBuilder)
public class CarBuilder : CarBuilder<CarBuilder>{}