using Xunit;

namespace ScrabbleScore.Objects
{
  public class ScrabbleScoreTest
  {
    [Theory]
    [InlineData("a", 1)]
    [InlineData("yz", 14)]
    [InlineData("don't", 5)]
    [InlineData("1", 0)]
    [InlineData("SPaghETti", 15)]
    [InlineData("do not", 6)]
    public void LetterValuesTest(string userWord, int wordValue)
    {
      ScoreCalculator testCalculator = new ScoreCalculator();
      int testOuput = testCalculator.LetterValues(userWord.ToLower());
      Assert.Equal(wordValue, testOuput);
    }
  }
}
