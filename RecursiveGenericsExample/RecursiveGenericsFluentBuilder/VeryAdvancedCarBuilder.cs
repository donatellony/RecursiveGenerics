namespace RecursiveGenericsFluentBuilder;

public class VeryAdvancedCarBuilder<TSelf> : AdvancedCarBuilder<VeryAdvancedCarBuilder<TSelf>>
    where TSelf : VeryAdvancedCarBuilder<TSelf>
{
    public TSelf AddColor(string color)
    {
        Car.Colors.Add(color);
        return (TSelf)this;
    }
}

public class VeryAdvancedCarBuilder : VeryAdvancedCarBuilder<VeryAdvancedCarBuilder>
{
}