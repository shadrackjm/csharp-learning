public class ZeroRatedVat : ITaxCalculator
{
    public string Name => "Zero-rated VAT 0%";

    public decimal CalculateTax(decimal amount) => 0m; // I have not times it by 0 as it will bring zero 
}