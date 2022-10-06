class Board{

    List<string> spaces = new List<string>();

    public Board() {
        for (int i = 1; i <= 9; i++)
        {
            spaces.Add(i.ToString());
        }
    }

    public void display() {
        Console.WriteLine($"{spaces[0]}|{spaces[1]}|{spaces[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{spaces[3]}|{spaces[4]}|{spaces[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{spaces[6]}|{spaces[7]}|{spaces[8]}");
    }

    public void makeMove(int square, string player) {
        // Convert the 1-based spot number to a 0-based index.
        int index = square - 1;

        // It would be good to include an additional check here to ensure that
        // the spot is available.
        spaces[index] = player;
    }

    public bool hasUnclaimedSquares() {
        bool foundDigit = false;

        foreach (string value in spaces)
        {
            if (char.IsDigit(value[0]))
            {
                foundDigit = true;
                break;
            }
        }

        return foundDigit;
    }

    public bool isPlayerWinner(string player) {
        // There are more elegant ways to check for a win, especially if
        // something besides a 3x3 squares were anticipated. This brute force
        // approach is sufficient to check for the possibilities.

        bool isWinner = false;

        if ((spaces[0] == player && spaces[1] == player && spaces[2] == player)
            || (spaces[3] == player && spaces[4] == player && spaces[5] == player)
            || (spaces[6] == player && spaces[7] == player && spaces[8] == player)
            || (spaces[0] == player && spaces[3] == player && spaces[6] == player)
            || (spaces[1] == player && spaces[4] == player && spaces[7] == player)
            || (spaces[2] == player && spaces[5] == player && spaces[8] == player)
            || (spaces[0] == player && spaces[4] == player && spaces[8] == player)
            || (spaces[2] == player && spaces[4] == player && spaces[6] == player)
            )
        {
            isWinner = true;
        }

        return isWinner;
    }

}