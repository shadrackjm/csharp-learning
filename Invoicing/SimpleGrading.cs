public class SimpleGrading : IGradingScheme
{
    public string Name => "Simple grading";

    public string GetGrade(decimal score)
    {
        if (score < 0 || score > 100)
            throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");
        if(score >= 80) 
            return "A";
        if(score >= 65) 
            return "B";
        if(score >= 50) 
            return "C";
        if(score >= 40) 
            return "D";
        if(score < 40) 
            return "F";
        return "Fail";
    }
}