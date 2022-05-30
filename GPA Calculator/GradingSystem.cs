
public static class GradingSystem
{
    public static string GetGrade(int score)
    {
        var grade = "";

        if (score > 69)
            grade = "A";

        else if (score > 59)
            grade = "B";

        else if (score > 49)
            grade = "C";

        else if (score > 44)
            grade = "D";

        else if (score > 39)
            grade = "E";

        else
            grade = "F";

        return grade;
    }

    public static int GetPoint(string grade)
    {
        var point = 0;

        switch (grade)
        {
            case "A":
                point = 5;
                break;
            case "B":
                point = 4;
                break;
            case "C":
                point = 3;
                break;
            case "D":
                point = 2;
                break;
            case "E":
                point = 1;
                break;
            case "F":
                point = 0;
                break;
            default:
                break;
        }

        return point;
    }

    public static string GetRemark(int grade)
    {
        var remark = string.Empty;

        switch (grade)
        {
            case 5:
                remark = "Excellent";
                break;
            case 4:
                remark = "Very Good";
                break;
            case 3:
                remark = "Good";
                break;
            case 2:
                remark = "Fair";
                break;
            case 1:
                remark = "Pass";
                break;
            case 0:
                remark = "Fail";
                break;
            default:
                break;
        }

        return remark;
    }
}
