// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using static System.Linq.Enumerable;
using static ConsoleApp1.Funcs;

var thing = Enumerable.Range(1, 100)
    .Where(i => i % 10 == 0)
    .OrderBy(i => -i)
    .Select(i => $"{i}%");

var pair = "EURUSD".AsPair();
Console.WriteLine(pair.Base);
Console.WriteLine(pair.Quote);

Console.WriteLine(Concat("hello, ", "world"));

Console.WriteLine(Funcs.SwapArgs<string, string, string>(Concat)("hello, ", "world"));

var even = Range(1, 20).Where(Funcs.IsMod(2));
foreach (var n in even)
{
    Console.WriteLine(n);
}
