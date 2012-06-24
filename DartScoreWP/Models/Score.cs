using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darts.API.Models
{
	public class Score
	{
		public Score()
		{
			Turns = new List<Turn>();
		}

		public Player Player { get; set; }
		public List<Turn> Turns { get; set; }

		public int OverallScore
		{
			get { return Turns.Sum(turn => turn.Score); }
		}
	}
}
