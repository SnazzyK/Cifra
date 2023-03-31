
int _seconds = 0;
DateTime finishDateTime = new DateTime(2023, 3, 31, 23, 48, 0);
DateTime _diffDateTime;

while (true)
{
    
    Console.Clear();
    _seconds = AddSeconds(_seconds);
    Console.WriteLine($"DayOfWeek:{GetDayOfWeek()}\nDay:{GetDay()}\nMonth:{GetMonth()}\nYear:{GetYear()}");
    Console.WriteLine($"Time:{GetHours()}:{GetMinutes(DateTime.Now)}:{GetSeconds(DateTime.Now)}");
    Console.WriteLine($"Second:{_seconds}");
    _diffDateTime = new DateTime(finishDateTime.Ticks - DateTime.Now.Ticks);
    Console.WriteLine($"До конца пары осталось: {GetMinutes(_diffDateTime)}:{GetSeconds(_diffDateTime)}");

    Thread.Sleep(1000);
}
Console.ReadLine();
//PROGRAM END

string GetDayOfWeek()
{
    return DayOfWeek.Friday.ToString();
}
int GetHours()
{
    return DateTime.Now.Hour;
}
int GetDay()
{
    return DateTime.Now.Day;
}
int GetMonth()
{
    return DateTime.Now.Month;
}
int GetYear()
{
    return DateTime.Now.Year;
}
int AddSeconds(int seconds)
{

    return seconds + GetSeconds(DateTime.Now);
}
int GetSeconds(DateTime dateTimeParam)
{
    return dateTimeParam.Second;
}
int GetMinutes(DateTime dateTimeParam)
{
    return DateTime.Now.Minute;
}
