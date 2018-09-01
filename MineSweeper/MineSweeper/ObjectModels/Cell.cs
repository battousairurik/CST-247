// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: Cell object, also potentially a tile, used to store information about each individual cell
//      on the game board.

using System;

namespace MineSweeper.ObjectModels
{
    class Cell
    {
        private int row;
        private int column;
        private int neighbors;
        private Boolean isVisited;
        private Boolean isLive;

        public Cell() { }

        public Cell(int row, int column)
        {
            this.row = row;
            this.column = column;
            neighbors = 0;
            isVisited = false;
            isLive = false;
        }
        //Default accessor and mutator methods
        public int Row
        {
            set { row = value; }
            get { return row; }
        }
        public int Column
        {
            set => column = value;
            get => column;
        }

        public int Neighbors
        {
            set => neighbors = value;
            get => neighbors;
        }
        public Boolean IsVisited
        {
            set => isVisited = value;
            get => isVisited;
        }
        public Boolean IsLive
        {
            set => isLive = value;
            get => isLive;
        }
    }
}
