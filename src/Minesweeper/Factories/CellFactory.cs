using MinesweeperSchneider.src.Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperSchneider.src.Minesweeper.Factories
{
    public static class CellFactory
    {
        private static readonly Random _random = new Random();

        public static Cell CreateCell(HashSet<(int, int)> minesCoordinates, int x, int y)
        {
            bool isMine = minesCoordinates.Contains((x, y));
            return new Cell(isMine);
        }
    }
}
