Console.Title = "Hunting the Manticore";

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\t\t\t\t\t---------------------------------\n");
Console.WriteLine("\t\t\t\t\t     DEFENSE OF CONSOLAS CITY");
Console.WriteLine("\n\t\t\t\t\t---------------------------------\n\n");
Console.ForegroundColor = ConsoleColor.White;

// Starting conditions
int round = 1;
int cityHealth = 15;
int manticoreHealth = 10;

// Manticore's secret location
Random rnd = new Random();
int manticorePosition = rnd.Next(1, 100);

Console.Write("$ ");
Console.ReadKey(true);

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"The Manticore has positioned itself. Prepare to defend the city!\n");
Console.ForegroundColor = ConsoleColor.White;

Console.Write("$ ");
Console.ReadKey(true);

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Try to hit the Manticore by trying to guess where it is placed.\n");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("$ ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("It is in a position between 1 and 100. Destroy it before it is too late.\n\n\n\n");
Console.ForegroundColor = ConsoleColor.White;

int roundDamage;

// Game Loop
while (cityHealth > 0 && manticoreHealth > 0)
{
    // Resetting the damage every new round
    roundDamage = 0;

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("STATUS: ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Round: {round} | City: {cityHealth}/15 | Manticore: {manticoreHealth}/10 ");

    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nMIGTHY FIRE-ELETRIC BLAST! ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("The cannon is expected to deal 10 damage this round.");
        roundDamage = 10;
    }
    else if (round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nELETRIC BLAST! ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("The cannon is expected to deal 3 damage this round.");
        roundDamage = 3;
    }
    else if (round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\nFIRE BLAST! ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("The cannon is expected to deal 3 damage this round.");
        roundDamage = 3;
    }
    else
    {
        Console.WriteLine("\nThe cannon is expected to deal 1 damage this round.");
        roundDamage = 1;
    }

    Console.Write("\nEnter desired cannon range: ");
    int desiredRange = ValidateInput(Console.ReadLine());

    if (desiredRange > manticorePosition)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("That round OVERSHOT the target.");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (desiredRange < manticorePosition)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("That round FELL SHORT of the target.");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.White;
        manticoreHealth -= roundDamage;
    }

    round++;
    if (!(manticoreHealth <= 0))
    {
        cityHealth--;
    }
    Console.WriteLine("-----------------------------------------------------------");
}

bool won = false;
if (cityHealth > 0) won = true;
CheckWin(won);


Console.WriteLine("\n\n");
Console.Write("$ ");
Console.ReadKey(true);

/////////////////////////////////////////////////////////////////////////////
// Methods
int ValidateInput(string? input)
{
    int cleanInput;

    while (!int.TryParse(input, out cleanInput) || ((int)cleanInput < 1 || (int)cleanInput > 100))
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Invalid input!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Enter a position number between 1-100: ");
        input = Console.ReadLine();
    }

    return cleanInput;
}

void CheckWin(bool won)
{
    if (won)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved! Congratulations!");
        Console.WriteLine("URAAHHHH WE SAVED THE CITY. WE WILL DESTROY THE UNCODED ONE! ");
        Console.ForegroundColor = ConsoleColor.White;

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X X");
        Console.WriteLine("MUAHAHAHA Another city destroyed by the Uncoded One!");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
