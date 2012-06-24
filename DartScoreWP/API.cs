using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darts.API.Models;

namespace Darts.API
{
	public class API
	{
		private Game _currentGame;

		public void StartGame(string[] playerNames)
		{
			_currentGame = new Game(playerNames.Select(name => new Player { Name = name }).ToList());
		}

		public void RecordShot(string playerName, int sectionHit, ScoringModifier modifier)
		{
			_currentGame.AddTurn(new Turn
				{
					Modifier = modifier,
					SectionHit = sectionHit
				}, 
				new Player
				{ 
					Name = playerName 
				});
		}

		public int GetScore(string playerName)
		{
			return _currentGame.GetScore(playerName).OverallScore;
		}

		public void EndGame()
		{
			//TODO: implement this
		}
	}
}
