namespace MinesweeperSchneider.src.Minesweeper.Models
{
    public class Player
    {
        public int Lives { get; set; } = 3;
        public int Moves { get; set; } = 0;
        public Coordinates Coordinates { get; set; }
        public Player(int startY) {
            // x is always 0
            Coordinates = new Coordinates(0, startY);
        }

        // could be implemented by a interface but it would be an overkill
        public void LoseLife()
        {
            Lives--;
        }

        public void AddMoves()
        {
            Moves++;
        }
    }
}
