// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: Object to store individual player data and scores which are comparable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper.ObjectModels
{
    public class PlayerStats : IComparable
    {
        public String PlayerName { get; set; }
        public String Difficulty { get; set; }
        public int Score { get; set; }

        public PlayerStats() { }
        public PlayerStats (String name, int score, String difficulty)
        {
            PlayerName = name;
            Difficulty = difficulty;
            Score = score;
        }
        // Is this proper?
        public int CompareTo(object obj)
        {
            PlayerStats player = (PlayerStats)obj;
            if (this.Score < player.Score)
            {
                return -1;
            }
            else if (this.Score > player.Score)
            {
                return 1;
            }
            else
                return 0;
        }

    }
}
