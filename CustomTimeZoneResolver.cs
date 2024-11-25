using Hangfire;
using System;

public class CustomTimeZoneResolver : ITimeZoneResolver
{
    public TimeZoneInfo GetTimeZoneById(string timeZoneId)
    {
        // Check if the provided time zone ID matches, if not return the default (Asia/Kolkata for GMT +5:30)
        if (string.IsNullOrEmpty(timeZoneId))
        {
            return TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata");
        }

        return TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
    }
}
