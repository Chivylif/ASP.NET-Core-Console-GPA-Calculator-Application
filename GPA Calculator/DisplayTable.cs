

//Calculate the Gpa



//Display the Calculated GPA
public static class DisplayTable
{
    private static int tableWidth = 140;
    public static void Display(List<Courses> courses)
    {
        // Display the courses and their components
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("| COURSE CODE\t| COURSE UNIT\t| SCORE\t| GRADE\t| GRADE UNIT\t| TOTALPOINT\t| REMARK\t|");
        Console.WriteLine("-------------------------------------------------------------------------------------------------");

        foreach (var course in courses)
        {
            var totalPoint = course.CourseUnit * course.GradeUnit;

            Console.WriteLine($"| {course.CourseCode}\t| {course.CourseUnit}\t\t| {course.Score}\t| {course.Grade}\t| {course.GradeUnit}\t\t| {totalPoint}\t\t| {course.Remarks}\t|");
        }

        Console.WriteLine("-------------------------------------------------------------------------------------------------");
    }


    private static void PrintDash()
    {
        Console.WriteLine(new string('-', tableWidth));
    }

    private static void PrintHeadings(params string[] values)
    {
        var columnWidth = (tableWidth * values.Length) / values.Length;

        foreach (var value in values)
            Console.WriteLine();
    }
}