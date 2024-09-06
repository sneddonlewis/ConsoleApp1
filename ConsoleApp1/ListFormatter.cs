namespace ConsoleApp1;

using static System.Linq.Enumerable;

public static class ListFormatter
{
    public static IEnumerable<string> Format(this IEnumerable<string> list)
    {
        var left = list.Select(ToSentenceCase);
        var right = Range(1, list.Count());
        var zipped = Enumerable.Zip(left, right, (s, i) => $"{i}. {s}");
        return zipped.ToList();
    }

    private static string ToSentenceCase(string str) =>
        str == string.Empty
            ? string.Empty
            : char.ToUpperInvariant(str[0]) + str.ToLower()[1..];
}