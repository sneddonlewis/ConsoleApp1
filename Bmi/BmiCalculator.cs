namespace Bmi;

public static class BmiCalculator
{
    public static decimal ComputeBmi(decimal height, decimal weight) => weight / height;

    public static string BmiCategory(decimal bmi) =>
        bmi switch
        {
            < 18.5m => "underweight",
            > 25 => "overweight",
            _ => "healthy weight",
        };
}