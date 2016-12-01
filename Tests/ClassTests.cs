using Xunit;

namespace ScrabbleScore.Objects
{
  public class ScrabbleScoreTest
  {
    [Theory]
    [InlineData("a", "1")]
    [InlineData("yz", "14")]
    [InlineData("don't", "5")]
    [InlineData("1", "0")]
    [InlineData("SPaghETti", "15")]
    public void LetterValuesTest(string userWord, string wordValue)
    {
      ScoreCalculator testCalculator = new ScoreCalculator(userWord);
      testCalculator.Main(userWord);
      Assert.Equal(wordValue, testCalculator.wordScore);
    }
  }
}
