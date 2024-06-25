namespace MinesweeperSchneider.src.Minesweeper.Models
{
    public class Cell
    {
        public bool IsMine { get; set; }
        public bool IsRevealed { get; set; } = false;

        public Cell(bool IsMine)
        {
            this.IsMine = IsMine;
        }
    }
}
