public class InvoiceLine
{
    public string Description { get; set; } = "";
    public decimal Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    // public decimal Total()
    // {
    //     return Quantity * UnitPrice;
    // }
    // Shorter version of the above method using expression-bodied member syntax
    public decimal Total() => Quantity * UnitPrice;
}