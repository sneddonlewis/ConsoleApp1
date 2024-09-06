namespace ConsoleApp1;

public static class Funcs
{
    public static Func<T2, T1, R> SwapArgs<T1, T2, R>(this Func<T1, T2, R> f) =>
        (t1, t2) => f(t2, t1);

    public static string Concat(string f, string s) => f + s;

    public static Func<int, bool> IsMod(int n) => i => i % n == 0;

    public static Func<T, bool> NegatePredicate<T>(this Func<T, bool> pred) =>
        (input) => !pred(input);
}