using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darts.API.Models
{
	public class Player
	{
		public string Name { get; set; }

        public enum Color
        {
            Red, Blue, Green, Yellow
        }
	}
}
