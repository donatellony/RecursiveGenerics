using System.Text;

namespace Shared;

public static class ExtensionMethods
{
    internal static void AppendPointedList<T>(this StringBuilder sb, IEnumerable<T> values, string listName)
    {
        sb.AppendLine($"{listName}:");
        var list = values.ToList();
        if (!list.Any())
        {
            sb.AppendLine("* Empty! *");
            return;
        }
        
        foreach (var value in list)
        {
            sb.AppendLine($"* {value}");
        }
    }
}