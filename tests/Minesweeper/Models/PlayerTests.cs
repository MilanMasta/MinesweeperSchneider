using MinesweeperSchneider.src.Minesweeper.Models;
using Xunit;

public class PlayerTests
{
    [Fact]
    public void LoseLife_DecrementsLivesCorrectly()
    {
        Player player = new Player(0);
        int initialLives = player.Lives;

        player.LoseLife();

        Assert.Equal(initialLives - 1, player.Lives);
    }

    [Fact]
    public void AddMoves_IncrementsMoveCountCorrectly()
    {
        Player player = new Player(0);
        int initialMovesCount = player.Moves;

        player.AddMoves();

        Assert.Equal(initialMovesCount + 1, player.Moves);
    }
}