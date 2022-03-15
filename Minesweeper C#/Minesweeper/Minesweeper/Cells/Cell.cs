using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Minesweeper.Core.Boards;
using Minesweeper.Core.Cells;

namespace Minesweeper.Core
{
    public class Cell
    {
        public int XLoc { get; set; }
        public int YLoc { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int CellSize { get; set; }
        public int NumMines { get; set; }

    }
}
