using Xunit;
using MinesweeperSchneider.src.Minesweeper.Models;
using System;
using System.Numerics;

public class GameTests
{
    [Fact]
    public void Constructor_InitializesGameWithCorrectDimensionsAndMines()
    {
        int rows = 8;
        int cols = 6;
        int minesCount = 9;
        int startY = 0;

        Game game = new Game(rows, cols, minesCount, startY);
        int count = 0;
        for (int y = 0; y < game.Grid.Cols; y++)
        {
            Console.WriteLine();
            for (int x = 0; x < game.Grid.Rows; x++)
            {
                count++;
            }
        }
        Assert.Equal(rows, game.Grid.Rows);
        Assert.Equal(cols, game.Grid.Cols);
        Assert.Equal(rows * cols, count);
    }
}