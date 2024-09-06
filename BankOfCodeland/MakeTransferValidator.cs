using System.Text.RegularExpressions;

namespace BankOfCodeland;

public class BicFormatValidator : IValidator<MakeTransfer>
{
    private static readonly Regex _regex = new("^[A-Z]{6}[A-Z1-9{5}]$");

    public bool IsValid(MakeTransfer t) => _regex.IsMatch(t.Bic);
}

public record DateNotPastValidator(Func<DateTime> Clock) : IValidator<MakeTransfer>
{
    private Func<DateTime> Clock { get; } = Clock;
    
    public bool IsValid(MakeTransfer t) => (Clock().Date <= t.Date.Date);
}