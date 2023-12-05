using System.Reflection.Metadata.Ecma335;

namespace OneBackComboTrainingWeb;

public class Holiday
{
    protected virtual DateTime GetToday()
    {
        return DateTime.Now;
    }

    public string GetTheme()
    {
        var dateTime = GetToday();

        return dateTime.Month == 12 && (dateTime.Day is 25 or 24) ? "Merry Xmas" : "Today is not Xmas";
    }
}