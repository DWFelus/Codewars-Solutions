/*
Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

HH = hours, padded to 2 digits, range: 00 - 99
MM = minutes, padded to 2 digits, range: 00 - 59
SS = seconds, padded to 2 digits, range: 00 - 59
The maximum time never exceeds 359999 (99:59:59)

You can find some examples in the test fixtures. */

public static class TimeFormat
{
  public static string GetReadableTime(int x)
  {
    int hours = x / 3600;
    int minutes = (x - hours * 3600) / 60;
    int seconds = x - (hours * 3600 + minutes * 60);

    string stringHours = "";
    string stringMinutes = "";
    string stringSeconds = "";

    if (hours < 10) stringHours = "0" + hours;
    else stringHours = hours.ToString();

    if (minutes < 10) stringMinutes = "0" + minutes;
    else stringMinutes = minutes.ToString();

    if (seconds < 10) stringSeconds = "0" + seconds;
    else stringSeconds = seconds.ToString();

    return stringHours + ":" + stringMinutes + ":" + stringSeconds; 
  }
}