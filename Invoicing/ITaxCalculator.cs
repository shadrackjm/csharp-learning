public interface ITaxCalculator
{
    string Name { get; }
    decimal CalculateTax(decimal amount);
}