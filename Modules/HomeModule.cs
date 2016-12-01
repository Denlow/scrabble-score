using Nancy;
using System.Collections.Generic;
using ScrabbleScore.Objects;

namespace ScrabbleScore
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ => View["index.cshtml"];
			Get["/result"] = _ =>
			{
			string userWord = Request.Query["user-word"];
			ScoreCalculator newScore = new ScoreCalculator(userWord);
			newScore.Main(userWord);
			return View["index.cshtml", newScore];
		};
		}
	}
}
