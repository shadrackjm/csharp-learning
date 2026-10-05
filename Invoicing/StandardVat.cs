public class StandardVat : ITaxCalculator
{
    public string Name => "Standard VAT 18%";

    public decimal CalculateTax(decimal amount) => amount * 0.18m;
}