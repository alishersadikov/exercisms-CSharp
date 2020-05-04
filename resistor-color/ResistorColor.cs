using System;

public static class ResistorColor
{
  public static int ColorCode(string color)
  {
    var colors = Colors();
    if (!Array.Exists(colors, element => element == color))
      throw new NotImplementedException(color + " is not a supported color");

    return Array.IndexOf(colors, color);
  }

  public static string[] Colors()
  {
    return new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
  }
}