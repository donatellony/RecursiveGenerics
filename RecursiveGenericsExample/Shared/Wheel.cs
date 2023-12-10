namespace Shared;

public class Wheel
{
    public int Radius { get; set; }

    public override string ToString()
    {
        return $"{nameof(Radius)}: {Radius}";
    }
}