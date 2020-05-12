using System;
using System.Collections.Generic;

public static class NucleotideCount
{
  public static IDictionary<char, int> Count(string sequence)
  {
    var dict = new Dictionary<char, int>
    {
      ['A'] = 0,
      ['C'] = 0,
      ['G'] = 0,
      ['T'] = 0
    };

    var chars = sequence.ToCharArray();

    for (int i = 0; i < chars.Length; i++)
    {
      if (dict.ContainsKey(chars[i]))
        dict[chars[i]]++;
      else
        throw new ArgumentException("The sequence can only contain: A, C, G, T types.");
    }

    return dict;
  }
}