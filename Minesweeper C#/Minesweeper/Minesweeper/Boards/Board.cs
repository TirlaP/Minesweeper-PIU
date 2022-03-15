using System;

namespace Minesweeper.Boards
{
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int NumMines { get; set; }
        // public int NumMinesRemaining => NumMines - FlagsPlaced();
        public bool ShowMines { get; set; }
        public bool ShowHints { get; set; }
        public bool ShowPercentage { get; set; }
        public bool ShowLocation { get; set; }
        public bool ShowCellHighlights { get; set; }
        public bool GameOver { get; set; }

        public const int CellSize = 32;

    }
}
