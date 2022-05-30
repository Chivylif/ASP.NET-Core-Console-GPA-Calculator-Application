public static class GPACalculator
{
    public static int TotalQuantityPoint(List<Courses> courses)
    {
        var qualityPoint = 0;

        foreach (var item in courses)
            qualityPoint += (item.CourseUnit * item.GradeUnit);

        return qualityPoint;
    }

    public static int TotalGradeUnit(List<Courses> course)
    {
        var totalGradeUnit = 0;

        foreach (var item in course)
            totalGradeUnit += item.GradeUnit;

        return totalGradeUnit;
    }
    public static double Gpa(int points, int unit)
    {
        return (double)points / unit;
    }

    public static void DisplayGpa(double gpa)
    {
        //Round the gpa to 2 decimal places
        if (gpa < 1)
            gpa = 0.00;

        gpa = Math.Round(gpa, 2);
        Console.WriteLine("Your GPA is: " + gpa);
        Console.WriteLine();
        Console.WriteLine("GPA is calculated using the formula below:");
        Console.WriteLine(@"GPA = Total CP / Total CU ");
        Console.WriteLine("Where CP = Course Point and CU = Course Units\n");
    }
}
