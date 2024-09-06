using System.Text.RegularExpressions;

namespace BankOfCodeland;

public class BicFormatValidator : IValidator<MakeTransfer>
{
    private static readonly Regex _regex = new("^[A-Z]{6}[A-Z1-9{5}]$");

    public bool IsValid(MakeTransfer t) => _regex.IsMatch(t.Bic);
}

public record DateNotPastValidator(DateTime Today) : IValidator<MakeTransfer>
{
    private DateTime Today { get; } = Today;
    
    public bool IsValid(MakeTransfer t) => (Today <= t.Date.Date);
}