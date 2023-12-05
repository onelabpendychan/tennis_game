using OneBackComboTrainingWeb;

namespace OneBackTests;

[TestFixture]
public class HolidayTest
{
    //for sub to extra field
    //extra method
    //extra assert should be
    private HolidayForTest _holidayForTest = null;

    [SetUp]
    public void SetUp()
    {
        _holidayForTest = new HolidayForTest();
    }


    [Test]
    public void today_is_xmas()
    {
        GivenToday(12, 25);
        ThemeShouldBe("Merry Xmas");
    }

    [Test]
    public void today_is_xmas_when_Dec_24()
    {
        GivenToday(12, 24);
        ThemeShouldBe("Merry Xmas");
    }

    [Test]
    public void today_is_xmas_when_Oct_24()
    {
        GivenToday(10, 24);
        ThemeShouldBe("Today is not Xmas");
    }

    private void ThemeShouldBe(string expected)
    {
        Assert.That(_holidayForTest.GetTheme(), Is.EqualTo(expected));
    }

    private void GivenToday(int month, int day)
    {
        _holidayForTest.Today = new DateTime(2000, month, day);
    }
}

public class HolidayForTest : Holiday
{
    protected virtual string GetTheme(int month, int day)
    {
        return month == 12 && day == 25 ? "Merry Xmax" : "Today is not Xmas";
    }

    private DateTime _today;

    public DateTime Today
    {
        set => _today = value;
    }

    protected override DateTime GetToday()
    {
        return _today;
    }
}