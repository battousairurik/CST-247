// Author: Michael Weaver
// Grand Canyon University
// CST - 227

// Description: Extended custom button class, will contain a reference to cell objects in the future.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineSweeper.ObjectModels;

namespace MineSweeper.FormControls
{
    class ClickableCell : Button
    {
        //Reference to cell object containing all minesweeper necessitated logic
        private Cell tileCell;
        private bool isClicked;
        public bool RightClicked { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public ClickableCell() : base () { }

        public void SetTileCell(Cell cell) { this.tileCell = cell; }
        public Cell GetTileCell() { return tileCell; }

        public void SetIsClicked(bool value) { this.isClicked = value; }
        public bool GetIsClicked() { return isClicked; }

        

    }
}
