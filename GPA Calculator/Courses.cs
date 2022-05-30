
public class Courses
{
    public int Score { get; set; }
    public int CourseUnit { get; set; }
    public string? Grade { get; set; }
    public int GradeUnit { get; set; }
    public string? Remarks { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }

    public string CourseCode
    {
        get
        {

            return $"{Name} - {Code}";
        }
    }
}
