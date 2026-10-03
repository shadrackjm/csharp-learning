var invoiceLine1 = new InvoiceLine
{
    Description = "Consulting Services",
    Quantity = 10,
    UnitPrice = 150.00m,
};

var invoiceLine2 = new InvoiceLine
{
    Description = "Rice",
    Quantity = 10,
    UnitPrice = 15.00m,
};

var invoiceLine3 = new InvoiceLine
{
    Description = "Beans",
    Quantity = 10,
    UnitPrice = 20.00m,
};

var invoiceLines = new List<InvoiceLine> { invoiceLine1, invoiceLine2, invoiceLine3 };

foreach (var line in invoiceLines)
{
    Console.WriteLine($"Description: {line.Description}, Quantity: {line.Quantity}, Unit Price: {line.UnitPrice:C}, Total: {line.Total():C}");
}

const decimal vatRate = 0.18m; // 18% tax rate

// foreach (var line in invoiceLines)
// {
//     subtotal += line.Total();
// }
// replacing the above foreach loop with LINQ to calculate the subtotal
var subtotal = invoiceLines.Sum(line => line.Total());

var moreThan200 = invoiceLines.Where(line => line.Total() > 200).ToList();

foreach(var line in moreThan200)
{
    Console.WriteLine($"Description: {line.Description} and Total: {line.Total():C}");
}


var vat = subtotal * vatRate;
var grandTotal = subtotal + vat;

Console.WriteLine($"Subtotal: {subtotal:C}, VAT: {vat:C}, Grand Total: {grandTotal:C}, More than 200: {moreThan200.Count} items");