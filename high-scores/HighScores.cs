using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
  public List<int> ScoresList;
  public HighScores(List<int> list)
  {
    this.ScoresList = list;
  }

  public List<int> Scores()
  {
    return this.ScoresList;
  }

  public int Latest()
  {
    return this.ScoresList.Last();
  }

  public int PersonalBest()
  {
    return this.ScoresList.Max();
  }

  public List<int> PersonalTopThree()
  {
    var cloneList = new List<int>(this.ScoresList);
    cloneList.Sort((a, b) => b.CompareTo(a));
    return cloneList.GetRange(0, 3);
  }
}