// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: 

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineSweeper.Models;


namespace MineSweeper.Controllers
{
    class HighScoresFileStorage
    {
        // Have to hard code file path because you cannot access it from the resources
        private String filePath = @"C:\Users\Michael\Documents\Visual Studio 2017\Projects\MineSweeper\MineSweeper\Resources\HighScores.txt";

        public HighScoresFileStorage() { }

        public void SetFilePath(String filePath)
        {
            this.filePath = filePath;
        }
        // Future implementation: Add empty line catch to generate default score
        public List<PlayerStats> ReadFromFile(List<PlayerStats> list)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                String line;
                String[] row = new String[3];
                while ((line = sr.ReadLine()) != null)
                {
                    row = line.Split(',');
                    list.Add(new PlayerStats(row[0], Convert.ToInt32(row[1]), row[2]));
                }
            }
            return list;
        }

        public void WriteToFile(List<PlayerStats> list)
        {
            using (StreamWriter sr = new StreamWriter(filePath))
            {
                
                foreach (PlayerStats player in list)
                {
                    sr.WriteLine(player.PlayerName + "," 
                        + player.Score.ToString() + "," 
                        + player.Difficulty);
                }
            }
        }
    }
}
