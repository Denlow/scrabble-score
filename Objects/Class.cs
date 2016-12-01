using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace ScrabbleScore.Objects
{
	public class ScoreCalculator
	{
		public string wordToCheck { get; set; }
		public string wordScore { get; set; }

		private List<Tuple<List<Char>, int>> _letterValueList = new List<Tuple<List<Char>, int>>
		{
			Tuple.Create(new List<Char> {'a','e','i', 'o', 'u', 'l', 'n', 'r', 's', 't'}, 1),
			Tuple.Create(new List<Char> {'d', 'g'}, 2),
			Tuple.Create(new List<Char> {'b', 'c', 'm', 'p'}, 3),
			Tuple.Create(new List<Char> {'f', 'h', 'v', 'w', 'y'}, 4),
			Tuple.Create(new List<Char> {'k'}, 5),
			Tuple.Create(new List<Char> {'j', 'x'}, 8),
			Tuple.Create(new List<Char> {'q', 'z'}, 10)

			// {{'a','e','i', 'o', 'u', 'l', 'n', 'r', 's', 't'}, 1},
			// {{'d', 'g'}, 2},
			// {{'b', 'c', 'm'}, 3},
			// {{'f', 'h', 'v', 'w', 'y'}, 4},
			// {{'k'}, 5},
			// {{'j', 'x'}, 8},
			// {{'q', 'z'}, 10}
		};

		public ScoreCalculator(string word)
		{
			wordToCheck = word;
		}

		public int LetterValues(string word)
		{
			int currentScore = 0;
			foreach (char letter in word)
			{
				foreach (Tuple<List<Char>, int> tuplePair in _letterValueList)
				{
					List<Char> letterList = tuplePair.Item1;
					int letterValue = tuplePair.Item2;
					if (letterList.Contains(letter))
					{
						currentScore += letterValue;
					}
				}
			}
			return currentScore;
		}

		public void Main(string userWord)
		{
			string output;
			string lowerWord = userWord.ToLower();
			string pattern = "[^a-z\'\\s]";
			Regex badCharacters = new Regex(pattern);
			if (!badCharacters.IsMatch(lowerWord))
			{
				output = LetterValues(lowerWord).ToString();
			}
			else
			{
				output = "Error: Bad Input. Please enter a single word without punctuation.";
			}
			wordScore = output;
		}
	}
}

//EXAMPLE OF LOGIC -- FOR DAVE
// //foreach (dataType variableNameForData in thingToLoopOver)
//
//
// exampleTuple{List<apple, pear>, orange}
//
// exampleTuple.Item1 //apple
// exampleTuple.Item2 //orange
//
// if exampleTuple.Item1.Contains(letterWereChecking)
// 	wordScore = wordScore + exampleTuple.Item2;
