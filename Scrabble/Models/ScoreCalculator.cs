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
      Dictionary<char, int> CharacterValues = new Dictionary<char, int>() {
        {'a', 1},
        {'e', 1},
        {'i', 1},
        {'o', 1},
        {'u', 1},
        {'l', 1},
        {'n', 1},
        {'r', 1},
        {'s', 1},
        {'t', 1},
        {'d', 2},
        {'g', 2},
        {'b', 3},
        {'c', 3},
        {'m', 3},
        {'p', 3},
        {'f', 4},
        {'h', 4},
        {'v', 4},
        {'w', 4},
        {'y', 4},
        {'k', 5},
        {'j', 8},
        {'x', 8},
        {'q', 10},
        {'z', 10}
      };
      
      char[] wordArr = UserWord.ToCharArray();
      int result = 0;
      for(int i = 0; i < wordArr.Length; i++)
      {
        result += CharacterValues[wordArr[i]];
        //.Value;
      }
// for(int i=0; i<wordArr.length ;i++)//c
// {
//  result += CharacterValues[wordArr[i]]//CharacterValues[c]==>3
  
// }
//iterate the user input through for
//find the value of the letter inside the for

    return result;
    }
  }
}