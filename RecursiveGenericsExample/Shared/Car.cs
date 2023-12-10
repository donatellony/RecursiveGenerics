using System.Text;

namespace Shared;

public class Car
{
    private static int _maxId = 1;
    /// <summary>
    /// Support for the doors specification was provided later
    /// </summary>
    public List<Door> Doors { get; } = new();
    public List<Wheel> Wheels { get; } = new();
    /// <summary>
    /// The color has to be provided as a hexadecimal code (#RRGGBB)
    /// </summary>
    public List<string> Colors { get; } = new();

    public int Id { get; } = _maxId++;
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{nameof(Id)}: {Id}");
        sb.AppendPointedList(Doors, nameof(Doors));
        sb.AppendPointedList(Wheels, nameof(Wheels));
        sb.AppendPointedList(Colors, nameof(Colors));
        return sb.ToString();
    }

}