using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class ScoreCalculator
  {
    // properties, constructors, methods, etc. go here
    //getting the input from user
    //charArray-to find teach letter's value and add it
    public string UserWord { get; set; }
    //private string _word;

    //constructor
    public  ScoreCalculator(string inputWord)
    {
      UserWord= inputWord;
    }

    //method to calculate the score
    public int calculateScore(string UserWord)
    {
      Dictionary<string, int> CharacterValues = new Dictionary<string, int>() {
        {"a,e,i,o,u,l,n,r,s,t",1},
        {"d,g",2},
        {"b,c,m,p",3},
        {"f,h,v,w,y",4},
        {"k",5},
        {"j,x",8},
        {"q,z",10}
      };
      char[] wordArr = UserWord.ToCharArray();
      int result = 0;
      for(int i = 0; i < wordArr.Length; i++)
      {
        string inputCharString= wordArr[i].ToString();
        foreach (KeyValuePair<string, int> entry in CharacterValues)
        {
          if((entry.Key).Contains(inputCharString))
            {
              result += entry.Value;
            }
        }
      }  
      return result;
    }
  }
}