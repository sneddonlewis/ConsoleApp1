namespace ConsoleApp1.VatProblem;

public readonly record struct Order(Product Item, int Quantity)
{
    public decimal NetPrice => Item.Price * Quantity;
}