// See https://aka.ms/new-console-template for more information
using Mission4;

tictactoetools ttt = new tictactoetools();

Console.WriteLine("Welcome to our game of tic-tac-toe!");
//• Create a game board array to store the players’ choices

//• Ask each player in turn for their choice and update the game board array

//• Print the board by calling the method in the supporting class

bool gameWon = false;
bool boardFull = false;

//print the board to start the game
ttt.printBoard(board);


//Start loop that will run until the supporting class returns a True for gameWon or board is full
while (!gameWon && !boardFull)
{
    Console.WriteLine("Make your pick (0-8) player " + currentPlayer);

    //get there pick and parse it to an integer
    int currentPick;
    bool validInput = false;

    while (!validInput)
    {
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out currentPick) && currentPick >= 0 && currentPick <= 8)
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Invalid input, please choose a position between 0 and 8");
        }
    }

    if (board[currentPick] == "")
    {
        board[currentPick] = currentPlayer;

        // Check for a winner
        gameWon = ttt.checkWinner(board);

        //switch player's turn only if no one won
        if (currentPlayer == "X" && !gameWon)
        {
            currentPlayer = "Y";
        }
        else if (currentPlayer == "Y" && !gameWon)
        {
            currentPlayer = "X";
        }
    }
    else
    {
        Console.WriteLine("Space is already occupied, please pick another spot");
    }
    
    //check if the board is full
    boardFull = !Array.Exists(board, element => element == "");

    //print the board after each turn
    ttt.printBoard(board);
}

//• Print the winner only if someone actually won, otherwise declare a tie
if (gameWon)
{
    Console.WriteLine("Congrats! The Winner is " + currentPlayer);
}
else
{
    Console.WriteLine("ITS CATS!");
}






