using BankOfCodeland;
using ConsoleApp1;
using static System.Linq.Enumerable;
using static System.Console;
using static ConsoleApp1.Funcs;

// Range(1, 100)
//     .Where(i => i % 10 == 0)
//     .OrderBy(i => -i)
//     .Select(i => $"{i}%")
//     .ForEach(WriteLine);

var pair = "EURUSD".AsPair();
// WriteLine(pair.Base);
// WriteLine(pair.Quote);

// WriteLine(Concat("hello, ", "world"));

// WriteLine(Funcs.SwapArgs<string, string, string>(Concat)("hello, ", "world"));

// Range(1, 20)
//     .Where(IsMod(2))
//     .ForEach(WriteLine);

var Pred = (int i) => i > 0;

var negated = Pred.NegatePredicate()(1);
// WriteLine(negated);

var list = new List<string>()
{
    "hello", "UNIQUE", "bLaRgH"
};

var output = list.AsParallel().Format().Aggregate((acc, curr) => acc + Environment.NewLine + curr);
WriteLine(output);