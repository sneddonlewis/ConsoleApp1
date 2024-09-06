using System.Text.RegularExpressions;

namespace BankOfCodeland;

public class BicFormatValidator : IValidator<MakeTransfer>
{
    private static readonly Regex _regex = new("^[A-Z]{6}[A-Z1-9{5}]$");

    public bool IsValid(MakeTransfer t) => _regex.IsMatch(t.Bic);
}

public delegate DateTime Clock();

public record DateNotPastValidator(Clock Clock) : IValidator<MakeTransfer>
{
    private Clock Clock { get; } = Clock;
    
    public bool IsValid(MakeTransfer t) => (Clock().Date <= t.Date.Date);
}