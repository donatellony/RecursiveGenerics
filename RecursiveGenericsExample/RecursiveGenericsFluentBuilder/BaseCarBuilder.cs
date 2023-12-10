using Shared;

namespace RecursiveGenericsFluentBuilder;

public abstract class BaseCarBuilder
{
    protected readonly Car Car = new();

    public Car Build()
    {
        return Car;
    }
}