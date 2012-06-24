using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Darts.API.Models;

namespace Darts.API.Models
{
    public class Game
    {
        /// <summary>
        /// Scores for all players
        /// </summary>
        public List<Score> Scores { get; private set; }

        public Game(List<Player> players)
        {
            Scores = new List<Score>();

            players.ForEach(player => Scores.Add(new Score {Player = player}));
        }

        /// <summary>
        /// Add a turn to the current game
        /// </summary>
        /// <param name="turn"></param>
        /// <param name="player"></param>
        public void AddTurn(Turn turn, Player player)
        {
            if (turn == null) throw new ArgumentNullException("A turn must be supplied");
            if (player == null) throw new ArgumentNullException("A player must be supplied");

            var playerScore = Scores.FirstOrDefault(score => score.Player.Name == player.Name);
            if (playerScore == null) throw new ArgumentException("Unable to find player in this game.");

            playerScore.Turns.Add(turn);
        }

        public Score GetScore(Player player)
        {
            return Scores.FirstOrDefault(x => x.Player == player);
        }

        public Score GetScore(string playerName)
        {
			return GetScore(Scores.FirstOrDefault(x => x.Player.Name.ToLower() == playerName.ToLower()).Player);
        }
    }
}
