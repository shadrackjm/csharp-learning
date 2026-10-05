public interface IGradingScheme
{
    string Name { get; }
    string GetGrade(decimal score);
}