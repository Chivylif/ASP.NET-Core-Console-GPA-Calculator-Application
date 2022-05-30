using System.Text.RegularExpressions;

public class StartUp
{
    public static List<Courses> InitiateCalculator()
    {
        int score = 0;
        string code = string.Empty;
        string courseName = string.Empty;
        int unit = 0;
        int option = 0;
        int courseNumber = 0;
        List<Courses> courses = new List<Courses>();

        Console.WriteLine("******************************************Welcome*****************************************\n");
        while (true)
        {
            var status = true;
            while (status)
            {
                Console.Write("Enter \"options\" to see the available options or exit to exit out of the program:  ");
                var selectedOption = Console.ReadLine();

                if (selectedOption != null)
                {
                    if (selectedOption.Equals("options"))
                    {
                        status = false;
                    }

                    if (selectedOption.Equals("exit"))
                        Environment.Exit(1);
                }
            }

            break;
        }

        var input = String.Empty;
        do
        {
            Options();
            input = Console.ReadLine();
            var converted = int.TryParse(input, out option);
        } while (!CheckForValidNumber(option));

        if (option == 1)
        {
            Console.WriteLine("You have chosen to calculate your GPA:  \n");

            do
            {
                Console.Write("Enter the number of course you wish to calculate:  ");
                input = Console.ReadLine();
                var converted = int.TryParse(input, out courseNumber);
            } while (!CheckForValidNumberOfCourses(courseNumber));

            var num = 1;

            while (courseNumber > 0)
            {
                Console.WriteLine("Entry number " + num + "\n");

                Console.Write($"{num} Enter course code name, eg \"MTH\":  ");
                courseName = Console.ReadLine().Trim().ToUpper();

                Console.Write($"Enter course code, eg \"101\":  ");
                code = Console.ReadLine().Trim();

                do
                {
                    Console.Write("Enter the course credit load:  ");
                    input = Console.ReadLine();
                    var converted = int.TryParse(input, out unit);
                } while (!CheckForValidNumber(unit));

                do
                {
                    Console.Write("Enter your score:  ");
                    input = Console.ReadLine();
                    Console.WriteLine();
                    var converted = int.TryParse(input, out score);
                } while (!CheckForValidScore(score));

                courses.Add(new Courses()
                {
                    Score = score,
                    Name = courseName,
                    Code = code,
                    CourseUnit = unit
                });

                courseNumber--;
                num++;
            }
        }

        return courses;
    }

    private static void Options()
    {
        var options = @"Available Options
PRESS 1 To Calculate GPA
PRESS 2 To View Result
PRESS 3 For Options";

        Console.WriteLine("\n" + options);
    }

    public static bool CheckCourseName(string name)
    {
        var regex = @"\%$#[]\_@!*^~+";
        Regex newRegex = new Regex(regex);

        if (newRegex.IsMatch(name))
            return false;
        return true;
    }

    private static bool CheckForValidScore(int score)
    {
        if (score < 0 || score > 100)
            return false;

        return true;
    }

    private static bool CheckForValidUnit(int unit)
    {
        if (unit < 0 || unit > 5)
            return false;

        return true;
    }

    private static bool CheckForValidNumber(int num)
    {
        if (num < 0 || num > 3)
            return false;

        return true;
    }

    private static bool CheckForValidNumberOfCourses(int num)
    {
        if (num < 0 || num > 10)
            return false;

        return true;
    }
}
