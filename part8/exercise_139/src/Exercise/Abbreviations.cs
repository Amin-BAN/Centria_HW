using System.Collections.Generic;

namespace Exercise
{
  public class Abbreviations
  {
    //add dictionary for abbreves;
     private Dictionary<string, string> abbRevs;

     // add empty constructor
     public Abbreviations()
     {
       this.abbRevs = new Dictionary<string, string>();
     }

     // add to abbrevs
    public void AddAbbreviation(string abbreviation, string explanation)
    {
      this.abbRevs.Add(abbreviation, explanation);

    }

    public bool HasAbbreviation(string abbreviation)
    { 
    if(this.abbRevs.ContainsKey(abbreviation))
      {
        return true;
      }   
      else
    {
      return false;
    }
    }

    public string FindExplanationFor(string abbreviation)
    {
      if (HasAbbreviation(abbreviation))
      {
        return abbRevs[abbreviation];
      }
      else
      {
        return "not found";
      }
    }
  }
}