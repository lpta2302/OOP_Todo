using System.Globalization;

public class TypeConverter
{
    private static DateTimeFormatInfo dateTimeFormat = new DateTimeFormatInfo();
    static TypeConverter()
    {
        dateTimeFormat.DayNames = new[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        dateTimeFormat.MonthNames = new[] { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
    }
    public static ResType? Convert<ParamType, ResType>(ParamType x)
    {
        if (x == null) return default;

        if (x is ResType || typeof(ResType).IsAssignableFrom(typeof(ParamType)))
        {
            return (ResType)(object)x;
        }
        else
        {
            throw new InvalidCastException($"Cannot convert {typeof(ParamType).FullName} to {typeof(ResType).FullName}");
        }
    }
    public static string ExchangeToWordDay(DateTime dateTime)
    {
        return dateTime.ToString("dddd, MMMM d", dateTimeFormat);
    }
    public static string ExchangeToDMYHMS(DateTime dateTime)
    {
        return dateTime.ToString("dd/MM/yyyy hh:mm");
    }
    public static string ExchangeToDMY(DateTime dateTime)
    {
        return dateTime.ToString("dd/MM/yyyy");
    }
    public static string GetHourTime(DateTime dateTime)
    {
        return dateTime.ToString("hh:mm");
    }
}
