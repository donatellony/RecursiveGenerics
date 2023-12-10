namespace RecursiveGenericsFluentBuilder;

public class VeryAdvancedCarBuilder : VeryAdvancedCarBuilder<VeryAdvancedCarBuilder>
{
    
}

public class VeryAdvancedCarBuilder<TSelf> : AdvancedCarBuilder<VeryAdvancedCarBuilder<TSelf>>
    where TSelf : VeryAdvancedCarBuilder<TSelf>
{
    public TSelf AddColor(string color)
    {
        Car.Colors.Add(color);
        return (TSelf)this;
    }
}