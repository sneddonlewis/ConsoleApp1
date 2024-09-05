namespace ConsoleApp1;

public static class Currency
{
    public static (string Base, string Quote) AsPair(this string currencyPair) =>
        currencyPair.SplitAt(3);
    
    private static (string, string) SplitAt(this string s, int at) =>
        (s[..at], s[at..]);
}