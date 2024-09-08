// See https://aka.ms/new-console-template for more information

using static System.Console;
using static Bmi.BmiCalculator;

WriteLine("Enter height in meters");
var height = decimal.Parse(ReadLine()!);
WriteLine("Enter weight in kilograms");
var weight = decimal.Parse(ReadLine()!);

decimal bmi = ComputeBmi(height, weight);
WriteLine(bmi);
string bmiCat = BmiCategory(bmi);

WriteLine(bmiCat);
