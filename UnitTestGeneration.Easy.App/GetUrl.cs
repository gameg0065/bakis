namespace UnitTestGeneration.Easy.App;
// https://github.com/elms64/HolidayBookingSystem/blob/main/Program%202/BookingProcessor/NormalMode.cs
// cy = 1, co = 0
public static class GetUrl
{
    public static string ExtractRequestType(Uri url)
    {
        return url.Segments.Last().TrimEnd('/');
    }
}