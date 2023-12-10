using System.Text;

namespace Shared;

public static class ExtensionMethods
{
    internal static void AppendPointedList<T>(this StringBuilder sb, IEnumerable<T> values, string listName)
    {
        sb.AppendLine(listName);
        foreach (var value in values)
        {
            sb.AppendLine($"* {value}");
        }
    }
}