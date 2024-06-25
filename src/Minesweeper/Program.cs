//Create a console application that runs a minefield/minesweeper style game, in which the player navigates from one
//side of a chessboard grid to the other whilst trying to avoid hidden mines. The player has a number of lives, losing one
//each time a mine is hit, and the final score is the number of moves taken in order to reach the other side of the board.
//The console interface should be simple, allowing the player to input move direction (up, down, left, right) and the
//game to show the resulting position (e.g. C2 in chess board terminology) along with number of lives left and number
//of moves taken.
//• You should take effort to demonstrate clean coding and use of recognized design principles in your solution
//• Implement appropriate automated unit testing


using MinesweeperSchneider.src.Minesweeper.Controller;
using MinesweeperSchneider.src.Minesweeper.Models;
using MinesweeperSchneider.src.Minesweeper.Views;


// configuration settings
int rows = 8;
int cols = 6;
int minesCount = 9;
int startY = 0;
///////////////////////////

Game game = new Game(rows, cols, minesCount, startY);

GameController controller = new GameController(game, new ConsoleView());
controller.RunGame();
