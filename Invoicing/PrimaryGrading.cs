public class PrimaryGrading : IGradingScheme
{
    public string Name => "Primary grading";

    public string GetGrade(decimal score)
    {
        if (score < 0 || score > 100)
            throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");
        if(score >= 80) 
            return "A";
        if(score >= 60) 
            return "B";
        if(score >= 40) 
            return "C";
        if(score >= 20) 
            return "D";

        return "F";
    }
}