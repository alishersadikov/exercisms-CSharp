using System;
using System.Text;
using System.Collections.Generic;

public class Robot
{
  private static List<string> ExistingNames = new List<string>();

  public Robot()
  {
    this._name = GenerateName();
  }
  private string _name;
  public string Name
  {
    get { return _name; }
    set { _name = value; }
  }

  public void Reset()
  {
    ExistingNames.Remove(Name);
    _name = GenerateName();
  }

  public string GenerateName()
  {
    StringBuilder strBuild = new StringBuilder();

    do
    {
      strBuild.Clear();
      var random = new Random();

      char letter;

      // first two letters
      for (int i = 0; i < 2; i++)
      {
        var flt = random.NextDouble();
        var shift = Convert.ToInt32(Math.Floor(25 * flt));
        letter = Convert.ToChar(shift + 65);
        strBuild.Append(letter);
      }

      // last 3 digits
      for (int i = 0; i < 3; i++)
      {
        var digit = random.Next(0, 9);
        strBuild.Append(digit.ToString());
      }
    } while (ExistingNames.Contains(strBuild.ToString()));

    var newName = strBuild.ToString();
    ExistingNames.Add(newName);

    return newName;
  }
}