using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScoreCalculatorTests
  {
    [TestMethod]
    public void ScoreCalculator_CreateAScoreCalculatorObject_ScoreCalculator()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      ScoreCalculator testScore = new ScoreCalculator("test");
      Assert.AreEqual(typeof(ScoreCalculator), testScore.GetType());
    }

    [TestMethod]
    public void SetInputWord_SetInputWord_String()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string word="at";
      ScoreCalculator testScore = new ScoreCalculator(word);
      string result = testScore.UserWord;
      Assert.AreEqual(word, result);
    }


    [TestMethod]
    public void calculateScore_GetTheScore_Int()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string word="cat";
      ScoreCalculator testScore = new ScoreCalculator(word);
      int result = testScore.calculateScore(word);
      Assert.AreEqual(5, result);
    }
  }
}