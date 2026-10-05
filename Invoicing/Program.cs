// ITaxCalculator tax = new ZeroRatedVat();

// decimal subtotal = 1850m;
// decimal vat = tax.CalculateTax(subtotal);

// Console.WriteLine($"{tax.Name}: {vat:C}");

var calculators = new List<ITaxCalculator>{ new StandardVat(), new ZeroRatedVat()};

foreach(var calculator in calculators)
{
    Console.WriteLine($"Calculator's Name: {calculator.Name}, Tax on 1850 will be: {calculator.CalculateTax(amount: 1850m):C}" );
}

var grading = new PrimaryGrading();

try
{
    Console.WriteLine($"Grade for -5 is: {grading.GetGrade(-5)}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


var gradingSchemes = new List<IGradingScheme> { new SimpleGrading(), new PrimaryGrading() };

foreach (var scheme in gradingSchemes)
{
    Console.WriteLine($"Grading Scheme: {scheme.Name}");
    var scores = new List<decimal> { 85m, 80m, 79.5m, 65m, 40m, 39m, -5m, 150m };
    foreach (var score in scores)
    {
        try
        {
            Console.WriteLine($"  Score: {score}, Grade: {scheme.GetGrade(score)}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"  Score: {score}, Error: {ex.Message}");
        }
    }
}