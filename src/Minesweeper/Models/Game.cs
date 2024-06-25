using MinesweeperSchneider.src.Minesweeper.Factories;

namespace MinesweeperSchneider.src.Minesweeper.Models
{

    public class Game
    {
        public Grid Grid { get; set; }
        public Player Player { get; set; }
        public bool IsGameOver { get; set; } = false;

        public Game(int rows, int cols, int minesCount, int startY)
        {
            Player = new Player(startY);
            Grid = new Grid(rows, cols, minesCount, startY);
        }
    }
}
