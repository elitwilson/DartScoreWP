using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darts.API.Models
{
	public class Turn
	{
		/// <summary>
		/// The section the dart hit (e.g. 20, 5, 7)
		/// </summary>
		public int SectionHit { get; set; }
		public ScoringModifier Modifier { get; set; }
		public int Score
		{
			get { return (int)SectionHit * (int)Modifier; }
		}
	}
}
