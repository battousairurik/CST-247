// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: This is an abstract game board that can be used to extend to various custom game boards.

namespace MineSweeper.ObjectModels
{
    public abstract class AGameBoard
    {
        protected int gameBoardSize;
        protected int minSize;
        protected int maxSize;

        public AGameBoard(int gameBoardSize, int minSize, int maxSize)
        {
            this.gameBoardSize = gameBoardSize;
            this.minSize = minSize;
            this.maxSize = maxSize;
        }

        public AGameBoard (int boardSize)
        {
            this.gameBoardSize = boardSize;
        }

        protected abstract void PopulateBoard();

    }
}
