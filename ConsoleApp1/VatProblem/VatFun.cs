namespace ConsoleApp1.VatProblem;

public static class VatFun
{
    public static decimal Vat(Address address, Order order) =>
        address switch
        {
            UsAddress(var state) => Vat(RateByState(state), order),
            { Country: "de" } => DeVat(order),
            { Country: var country } => Vat(RateByCountry(country), order),
        };

    private static decimal RateByCountry(string country) =>
        country switch
        {
            "it" => 0.22m,
            "jp" => 0.08m,
            _ => throw new ArgumentException($"Missing rate for {country}")
        };

    private static decimal RateByState(string state) =>
        state switch
        {
            "ca" => 0.1m,
            "ma" => 0.0625m,
            "ny" => 0.085m,
            _ => throw new ArgumentException($"Missing rate for {state}")
        };

    private static decimal Vat(decimal rate, Order order) => order.NetPrice * rate;
    
    private static decimal DeVat(Order order) => order.NetPrice * (order.Item.IsFood ? 0.08m : 0.2m);
}