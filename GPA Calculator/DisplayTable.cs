

//Calculate the Gpa



//Display the Calculated GPA
public static class DisplayTable
{
    private static int tableWidth = 120;
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

    public static void PrintTable(List<Courses> courses)
    {
        PrintDash();
        PrintHeadings("COURSE CODE", "COURSE UNIT", "SCORE", "GRADE", "GRADE UNIT", "TOTAL POINT", "REMARK");
        PrintDash();

        foreach (var course in courses)
        {
            var totalPoint = course.CourseUnit * course.GradeUnit;

            PrintHeadings(course.CourseCode, course.CourseUnit.ToString(), course.Score.ToString(), course.Grade, course.GradeUnit.ToString(), totalPoint.ToString(), course.Remarks);
        }

        PrintDash();
    }
    private static void PrintDash()
    {
        Console.WriteLine(new string('-', tableWidth));
    }

    private static void PrintHeadings(params string[] columns)
    {
        int columnWidth = (tableWidth - columns.Length) / columns.Length;
        const string columnSeperator = "|";

        string row = columns.Aggregate(columnSeperator, (seperator, columnText) => seperator + GetCenterAlignedText(columnText, columnWidth) + columnSeperator);

        Console.WriteLine(row);
    }

    private static string GetCenterAlignedText(string text, int columnWidth)
    {
        text = text.Length > columnWidth ? text.Substring(0, columnWidth - 3) + "..." : text;

        return string.IsNullOrEmpty(text)
            ? new string(' ', columnWidth)
            : text.PadRight(columnWidth - ((columnWidth - text.Length) / 2)).PadLeft(columnWidth);
    }
}
