using MinesweeperSchneider.src.Minesweeper.Models;

namespace MinesweeperSchneider.src.Minesweeper.Views
{
    public class ConsoleView
    {
        public void DisplayBoard(Game game, Player player)
        {
            Console.Clear();
            for (int y = 0; y < game.Grid.Cols; y++)
            {
                Console.WriteLine();
                for (int x = 0; x < game.Grid.Rows; x++)
                {
                    string output = " * "; // Unrevealed cell

                    if (game.Grid.Fields[x, y].IsRevealed)
                    {
                        if (game.Grid.Fields[x, y].IsMine)
                        {
                            output =" | "; // Reavealed mine
                        }
                        else
                        {
                            output = " . "; // Revealed empty cell
                        }
                    }

                    if (player.Coordinates.X == x && player.Coordinates.Y == y)
                    {
                        output = " P "; // Player position
                    }

                    Console.Write(output);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Lives: {player.Lives} Moves: {player.Moves} Current Postion: {player.Coordinates.X}, {player.Coordinates.Y}");
        }
        public ConsoleKey GetInput()
        {
            Console.Write("Use arrow keys to navigate through minefield:");
            return Console.ReadKey(true).Key;
        }

        public void DisplayResult(string result)
        {
            Console.WriteLine("\n\n" + result + "\n");
        }
    }
}
