namespace Shared;

public class Door
{
    public DoorType Type { get; set; }

    public override string ToString()
    {
        return $"{nameof(Type)}: {Type}";
    }
}