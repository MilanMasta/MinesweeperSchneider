using MinesweeperSchneider.src.Minesweeper.Models;
using MinesweeperSchneider.src.Minesweeper.Views;

namespace MinesweeperSchneider.src.Minesweeper.Controller
{
    public class GameController
    {
        private readonly Game _game;
        private readonly ConsoleView _view;

        public GameController(Game game, ConsoleView view)
        {
            _game = game;
            _view = view;
        }

        public void RunGame()
        {
            while (_game.Player.Lives > 0)
            {
                _view.DisplayBoard(_game, _game.Player);
                ConsoleKey move = _view.GetInput();
                ProcessMove(move);

                if (_game.Player.Coordinates.X == _game.Grid.Rows - 1)
                {
                    _view.DisplayResult("You won the game");
                    return;
                }
            }
            _view.DisplayResult("Game Over");
        }

        private void ProcessMove(ConsoleKey move)
        {
            switch (move)
            {
                case ConsoleKey.UpArrow:
                    _game.Player.Coordinates.Y = Math.Max(0, _game.Player.Coordinates.Y - 1);
                    break;
                case ConsoleKey.DownArrow:
                    _game.Player.Coordinates.Y = Math.Min(_game.Grid.Cols - 1, _game.Player.Coordinates.Y + 1);
                    break;
                case ConsoleKey.LeftArrow:
                    _game.Player.Coordinates.X = Math.Max(0, _game.Player.Coordinates.X - 1);
                    break;
                case ConsoleKey.RightArrow:
                    _game.Player.Coordinates.X = Math.Min(_game.Grid.Rows - 1, _game.Player.Coordinates.X + 1);
                    break;
                default:
                    return;
            }

            _game.Player.AddMoves();
            _game.Grid.Fields[_game.Player.Coordinates.X, _game.Player.Coordinates.Y].IsRevealed = true;

            if (_game.Grid.Fields[_game.Player.Coordinates.X, _game.Player.Coordinates.Y].IsMine) _game.Player.LoseLife();
        }
    }
}
