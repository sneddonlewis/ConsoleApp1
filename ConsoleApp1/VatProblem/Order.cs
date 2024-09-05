namespace ConsoleApp1.VatProblem;

public record Order(Product Item, int Quantity)
{
    public decimal NetPrice => Item.Price * Quantity;
}