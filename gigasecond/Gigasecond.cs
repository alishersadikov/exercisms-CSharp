using System;

public static class Gigasecond
{
  public static DateTime Add(DateTime moment)
  {
    const int BillionSeconds = 1000000000;
    return moment.AddSeconds(BillionSeconds);
  }
}