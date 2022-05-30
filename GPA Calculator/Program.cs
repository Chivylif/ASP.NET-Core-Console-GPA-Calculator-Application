int totalPoint = 0;
int totalGradeUnit = 0;
double gpa = 0.0;
var toExit = new string[] { "y", "yes" };
var input = "y";
var courseGrade = string.Empty;
var gradeUnit = 0;
var remark = string.Empty;
var studentName = string.Empty;

while (toExit.Contains(input))
{
    List<Courses> courses = StartUp.InitiateCalculator();

    foreach (var course in courses)
    {
        courseGrade = GradingSystem.GetGrade(course.Score);
        gradeUnit = GradingSystem.GetPoint(courseGrade);
        remark = GradingSystem.GetRemark(gradeUnit);

        course.Grade = courseGrade;
        course.GradeUnit = gradeUnit;
        course.Remarks = remark;
    }

    //Get the student full name
    Console.Write("Enter your full name:  ");
    studentName = Console.ReadLine();

    //Display the students name
    Console.WriteLine("    --------------------------------" + studentName + "'s Result--------------------------------");

    //Display the course table
    DisplayTable.Display(courses);

    //Calculate the totalquantitypoint
    totalPoint = GPACalculator.TotalQuantityPoint(courses);

    //Claculate the total gradepoint
    totalGradeUnit = GPACalculator.TotalGradeUnit(courses);

    //Calculate the GPA
    gpa = GPACalculator.Gpa(totalPoint, totalGradeUnit);

    //Display the Calculated GPA
    GPACalculator.DisplayGpa(gpa);

    do
    {
        Console.WriteLine(@"Enter 'y' or 'yes' if you wish to perform another transaction or 'exit' to exit from the application");
        input = Console.ReadLine().Trim().ToLower();

        if (input.Equals("exit"))
            break;

    } while (!CheckForValidInput(input));
}



bool CheckForValidInput(string input)
{
    if (string.IsNullOrEmpty(input))
        return false;

    if (!toExit.Contains(input))
        return false;

    return true;
}

