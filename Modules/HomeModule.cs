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

		}
	}
}
