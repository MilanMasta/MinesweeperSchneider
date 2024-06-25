using MinesweeperSchneider.src.Minesweeper.Factories;

namespace MinesweeperSchneider.src.Minesweeper.Models
{
    public class Grid
    {
        public Cell[,] Fields { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int StartX { get; set; } = 0;
        public int StartY { get; set; }
        private HashSet<(int, int)> MinesCoordinates { get; set; } = new HashSet<(int, int)>();

        public Grid(int rows, int cols, int minesCount, int startY)
        {
            Rows = rows;
            Cols = cols;
            StartY = startY;
            Fields = new Cell[Rows, Cols];
            InitializeMinesCoordinates(minesCount);
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Fields[i, j] = CellFactory.CreateCell(MinesCoordinates, i, j);
                    if (i == StartX && j == StartY) Fields[i, j].IsRevealed = true;
                }
            }
        }
        private void InitializeMinesCoordinates(int count)
        {
            Random random = new Random();
            while (MinesCoordinates.Count < count)
            {
                int newRows = random.Next(Rows);
                int newCols = random.Next(Cols);
                // we should not have a mine on the first step
                if (newRows == StartX && newCols == StartY) continue;
                MinesCoordinates.Add((newRows, newCols));
            }
        }
    }
}
