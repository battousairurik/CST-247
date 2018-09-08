// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineSweeper.Models;


namespace MineSweeper.Controllers
{
    class PlayerStatsController
    {
        private HighScoresFileStorage scores;
        private List<PlayerStats> masterList;
        private List<PlayerStats> easyScores;
        private List<PlayerStats> mediumScores;
        private List<PlayerStats> hardScores;
        
        // Method to mark game difficulty and create list of scores
        public PlayerStatsController()
        {
            scores = new HighScoresFileStorage();
            masterList = new List<PlayerStats>();
            masterList = scores.ReadFromFile(masterList);
            SplitMasterList();
            //this.difficulty = difficulty;
        }

        private void SplitMasterList()
        {
            easyScores = SplitMasterListHelper("easy");
            mediumScores = SplitMasterListHelper("medium");
            hardScores = SplitMasterListHelper("hard");
        }

        private List<PlayerStats> SplitMasterListHelper(String difficulty)
        {
            // Create temp list to be returned
            List<PlayerStats> tempList = new List<PlayerStats>();
            // LINQ query to select player objects that have the appropriate difficulty
            var listQuery = from player in masterList
                            where player.Difficulty == difficulty
                            select player;
            // Loop to add all player objects to temp list
            foreach (var player in listQuery)
            {
                tempList.Add(player);
            }
            // Return temp list for use
            return tempList;
        }

        public List<PlayerStats> GetDifficultyScores(String difficulty)
        {
            switch (difficulty)
            {
                
                case "easy":
                    return easyScores;
                
                case "medium":
                    return mediumScores;
                
                case "hard":
                    return hardScores;
                
                default:
                    return null;
            }
        }

        public void WriteListToFile()
        {
            CombineSubLists();
            scores.WriteToFile(masterList);
        }

        private void CombineSubLists()
        {
            masterList.Clear();
            masterList.AddRange(easyScores);
            masterList.AddRange(mediumScores);
            masterList.AddRange(hardScores);
        }

        public void UpdateList(PlayerStats newPlayer, String difficulty)
        {
            switch (difficulty)
            {

                case "easy":
                    UpdateListHelper(newPlayer, easyScores);
                    break;
                case "medium":
                    UpdateListHelper(newPlayer, mediumScores);
                    break;
                case "hard":
                    UpdateListHelper(newPlayer, hardScores);
                    break;
                default:
                    break;
            }
        }
        // Difficulty because foreach doesnt iterate when a list is changed
        private void UpdateListHelper (PlayerStats newPlayer, List<PlayerStats> list)
        {
            
            PlayerStats tempPlayer = newPlayer;
            
            for (int y = 0; y < 5; y++)
            {
                PlayerStats player = list[y];
                if (tempPlayer.CompareTo(player) < 0)
                {
                    list.Insert(y, tempPlayer);
                    tempPlayer = player;
                    list.Remove(player);
                }
                
            }
            
        }
       
    }
}
