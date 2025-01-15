using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
int game0 = 1;
int attempts = 0;
int numberofrounds = 0;
int numberofgames = 0;
// Start or Stop
Console.ForegroundColor = ConsoleColor.DarkYellow;
do
{
    Console.WriteLine("                                                                                    ");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |               Guess The Number               |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |1:Start                                       |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |0:Stop                                        |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.WriteLine("                                    |                                              |");
    Console.Write("Select: ");
    int game1;
    string game1Input = Console.ReadLine();
    bool game1Valid = int.TryParse(game1Input, out game1);
    while (!game1Valid)
    {
        game1Input = Console.ReadLine();
        game1Valid = int.TryParse(game1Input, out game1);
    }
    Console.Clear();
    if (game1 == 0)
    {
        Console.WriteLine("Stop!");
        return;
    }
    Console.Clear();
    if (game1 > 1)
    {
        continue;
    }
    Console.Clear();
    if (game1 < 0)
    {
        continue;
    }
    Console.Clear();
    // Main Menu
    do
    {
        Console.WriteLine("                                                                                    ");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                   Main Menu                  |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |1:Play                                        |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |2:Statistics                                  |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |3:Instructions                                |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |4:Exit                                        |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.WriteLine("                                    |                                              |");
        Console.Write("Select: ");
        int game2;
        string game2Input = Console.ReadLine();
        bool game2Valid = int.TryParse(game2Input, out game2);
        while (!game2Valid)
        {
            game2Input = Console.ReadLine();
            game2Valid = int.TryParse(game2Input, out game2);
        }
        Console.Clear();
        if (game2 > 4)
        {
            continue;
        }
        Console.Clear();
        if (game2 < 1)
        {
            continue;
        }
        Console.Clear();
        if (game2 < 0)
        {
            continue;
        }
        Console.Clear();
        // Play
        do
        {
            if (game2 == 1)
            {
                int round1 = 1;
                int round2 = 2;
                int round3 = 3;
                int gameover = 4;
                // Round 1
                if (round1 == 1)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 1                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |-  | +  +  +  +  + | 5 Attempts!              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |1:Choose                                      |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int game3Round1;
                    string game3Round1Input = Console.ReadLine();
                    bool game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    while (!game3Round1Valid)
                    {
                        game3Round1Input = Console.ReadLine();
                        game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    }
                    Console.Clear();
                    if (game3Round1 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round1 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round1 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 1 Attempt 1
                if (round1 == 1)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 1                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int a;
                    string aInput = Console.ReadLine();
                    bool aValid = int.TryParse(aInput, out a);
                    while (!aValid)
                    {
                        aInput = Console.ReadLine();
                        aValid = int.TryParse(aInput, out a);
                    }
                    Console.Clear();
                    if (a == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (a < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (a > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound1 = 1;
                    const int limitaSuperioaraRound1 = 5;
                    Random generatorDeNumereAleatoareRound1 = new Random();
                    int[] arrayDeNumereRound1 = new int[1];
                    for (int r1 = 0; r1 < arrayDeNumereRound1.Length; r1++)
                    {
                        arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                        if (a != arrayDeNumereRound1[r1])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                            Console.WriteLine("                                    |" + a + "| +  +  +  +    | Wrong Number! | 4 Attempts!|");
                            if (a != arrayDeNumereRound1[r1])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (a == arrayDeNumereRound1[r1] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 1                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(a + " ");
                        if (a == arrayDeNumereRound1[r1])
                        {
                            round1 = round2;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 2!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round1;
                    string game3Round1Input = Console.ReadLine();
                    bool game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    while (!game3Round1Valid)
                    {
                        game3Round1Input = Console.ReadLine();
                        game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    }
                    Console.Clear();
                    if (game3Round1 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round1 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round1 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 1 Attempt 2
                if (round1 == 1)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 1                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int a;
                    string aInput = Console.ReadLine();
                    bool aValid = int.TryParse(aInput, out a);
                    while (!aValid)
                    {
                        aInput = Console.ReadLine();
                        aValid = int.TryParse(aInput, out a);
                    }
                    Console.Clear();
                    if (a == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (a < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (a > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound1 = 1;
                    const int limitaSuperioaraRound1 = 5;
                    Random generatorDeNumereAleatoareRound1 = new Random();
                    int[] arrayDeNumereRound1 = new int[1];
                    for (int r1 = 0; r1 < arrayDeNumereRound1.Length; r1++)
                    {
                        arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                        if (a != arrayDeNumereRound1[r1])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                            Console.WriteLine("                                    |" + a + "| +  +  +       | Wrong Number! | 3 Attempts!|");
                            if (a != arrayDeNumereRound1[r1])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (a == arrayDeNumereRound1[r1] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 1                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(a + " ");
                        if (a == arrayDeNumereRound1[r1])
                        {
                            round1 = round2;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 2!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round1;
                    string game3Round1Input = Console.ReadLine();
                    bool game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    while (!game3Round1Valid)
                    {
                        game3Round1Input = Console.ReadLine();
                        game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    }
                    Console.Clear();
                    if (game3Round1 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round1 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round1 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 1 Attempt 3
                if (round1 == 1)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 1                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int a;
                    string aInput = Console.ReadLine();
                    bool aValid = int.TryParse(aInput, out a);
                    while (!aValid)
                    {
                        aInput = Console.ReadLine();
                        aValid = int.TryParse(aInput, out a);
                    }
                    Console.Clear();
                    if (a == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (a < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (a > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound1 = 1;
                    const int limitaSuperioaraRound1 = 5;
                    Random generatorDeNumereAleatoareRound1 = new Random();
                    int[] arrayDeNumereRound1 = new int[1];
                    for (int r1 = 0; r1 < arrayDeNumereRound1.Length; r1++)
                    {
                        arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                        if (a != arrayDeNumereRound1[r1])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                            Console.WriteLine("                                    |" + a + "| +  +          | Wrong Number! | 2 Attempts!|");
                            if (a != arrayDeNumereRound1[r1])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (a == arrayDeNumereRound1[r1] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 1                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(a + " ");
                        if (a == arrayDeNumereRound1[r1])
                        {
                            round1 = round2;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 2!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round1;
                    string game3Round1Input = Console.ReadLine();
                    bool game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    while (!game3Round1Valid)
                    {
                        game3Round1Input = Console.ReadLine();
                        game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    }
                    Console.Clear();
                    if (game3Round1 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round1 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round1 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 1 Attempt 4
                if (round1 == 1)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 1                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int a;
                    string aInput = Console.ReadLine();
                    bool aValid = int.TryParse(aInput, out a);
                    while (!aValid)
                    {
                        aInput = Console.ReadLine();
                        aValid = int.TryParse(aInput, out a);
                    }
                    Console.Clear();
                    if (a == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (a < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (a > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound1 = 1;
                    const int limitaSuperioaraRound1 = 5;
                    Random generatorDeNumereAleatoareRound1 = new Random();
                    int[] arrayDeNumereRound1 = new int[1];
                    for (int r1 = 0; r1 < arrayDeNumereRound1.Length; r1++)
                    {
                        arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                        if (a != arrayDeNumereRound1[r1])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                            Console.WriteLine("                                    |" + a + "| +             | Wrong Number! | 1 Attempts!|");
                            if (a != arrayDeNumereRound1[r1])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (a == arrayDeNumereRound1[r1] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 1                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(a + " ");
                        if (a == arrayDeNumereRound1[r1])
                        {
                            round1 = round2;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 2!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round1;
                    string game3Round1Input = Console.ReadLine();
                    bool game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    while (!game3Round1Valid)
                    {
                        game3Round1Input = Console.ReadLine();
                        game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    }
                    Console.Clear();
                    if (game3Round1 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round1 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round1 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 1 Attempt 5
                if (round1 == 1)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 1                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int a;
                    string aInput = Console.ReadLine();
                    bool aValid = int.TryParse(aInput, out a);
                    while (!aValid)
                    {
                        aInput = Console.ReadLine();
                        aValid = int.TryParse(aInput, out a);
                    }
                    Console.Clear();
                    if (a == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (a < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (a > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound1 = 1;
                    const int limitaSuperioaraRound1 = 5;
                    Random generatorDeNumereAleatoareRound1 = new Random();
                    int[] arrayDeNumereRound1 = new int[1];
                    for (int r1 = 0; r1 < arrayDeNumereRound1.Length; r1++)
                    {
                        arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                        if (a != arrayDeNumereRound1[r1])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound1[r1] = generatorDeNumereAleatoareRound1.Next(limitaInferioaraRound1, limitaSuperioaraRound1 + 1);
                            Console.WriteLine("                                    |" + a + "|               | Wrong Number! | 0 Attempts!|");
                            if (a != arrayDeNumereRound1[r1])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Continue To Round 2!                        |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (a == arrayDeNumereRound1[r1] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (a == arrayDeNumereRound1[r1] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 1                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(a + " ");
                        if (a == arrayDeNumereRound1[r1])
                        {
                            round1 = round2;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 1                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 2!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round1;
                    string game3Round1Input = Console.ReadLine();
                    bool game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    while (!game3Round1Valid)
                    {
                        game3Round1Input = Console.ReadLine();
                        game3Round1Valid = int.TryParse(game3Round1Input, out game3Round1);
                    }
                    Console.Clear();
                    if (game3Round1 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round1 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round1 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                Console.Clear();
                // Round 2
                if (round2 == 2)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 2                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |-  | +  +  +  +  + | 5 Attempts!              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |1:Choose                                      |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int game3Round2;
                    string game3Round2Input = Console.ReadLine();
                    bool game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    while (!game3Round2Valid)
                    {
                        game3Round2Input = Console.ReadLine();
                        game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    }
                    Console.Clear();
                    if (game3Round2 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round2 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round2 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 2 Attempt 1
                if (round2 == 2)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 2                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int b;
                    string bInput = Console.ReadLine();
                    bool bValid = int.TryParse(bInput, out b);
                    while (!bValid)
                    {
                        bInput = Console.ReadLine();
                        bValid = int.TryParse(bInput, out b);
                    }
                    Console.Clear();
                    if (b == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (b < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (b > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound2 = 1;
                    const int limitaSuperioaraRound2 = 5;
                    Random generatorDeNumereAleatoareRound2 = new Random();
                    int[] arrayDeNumereRound2 = new int[1];
                    for (int r2 = 0; r2 < arrayDeNumereRound2.Length; r2++)
                    {
                        arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                        if (b != arrayDeNumereRound2[r2])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                            Console.WriteLine("                                    |" + b + "| +  +  +  +    | Wrong Number! | 4 Attempts!|");
                            if (b != arrayDeNumereRound2[r2])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (b == arrayDeNumereRound2[r2] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 2                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(b + " ");
                        if (b == arrayDeNumereRound2[r2])
                        {
                            round2 = round3;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 3!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round2;
                    string game3Round2Input = Console.ReadLine();
                    bool game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    while (!game3Round2Valid)
                    {
                        game3Round2Input = Console.ReadLine();
                        game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    }
                    Console.Clear();
                    if (game3Round2 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round2 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round2 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 2 Attempt 2
                if (round2 == 2)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 2                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int b;
                    string bInput = Console.ReadLine();
                    bool bValid = int.TryParse(bInput, out b);
                    while (!bValid)
                    {
                        bInput = Console.ReadLine();
                        bValid = int.TryParse(bInput, out b);
                    }
                    Console.Clear();
                    if (b == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (b < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (b > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound2 = 1;
                    const int limitaSuperioaraRound2 = 5;
                    Random generatorDeNumereAleatoareRound2 = new Random();
                    int[] arrayDeNumereRound2 = new int[1];
                    for (int r2 = 0; r2 < arrayDeNumereRound2.Length; r2++)
                    {
                        arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                        if (b != arrayDeNumereRound2[r2])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                            Console.WriteLine("                                    |" + b + "| +  +  +       | Wrong Number! | 3 Attempts!|");
                            if (b != arrayDeNumereRound2[r2])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (b == arrayDeNumereRound2[r2] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 2                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(b + " ");
                        if (b == arrayDeNumereRound2[r2])
                        {
                            round2 = round3;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 3!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round2;
                    string game3Round2Input = Console.ReadLine();
                    bool game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    while (!game3Round2Valid)
                    {
                        game3Round2Input = Console.ReadLine();
                        game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    }
                    Console.Clear();
                    if (game3Round2 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round2 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round2 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 2 Attempt 3
                if (round2 == 2)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 2                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int b;
                    string bInput = Console.ReadLine();
                    bool bValid = int.TryParse(bInput, out b);
                    while (!bValid)
                    {
                        bInput = Console.ReadLine();
                        bValid = int.TryParse(bInput, out b);
                    }
                    Console.Clear();
                    if (b == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (b < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (b > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound2 = 1;
                    const int limitaSuperioaraRound2 = 5;
                    Random generatorDeNumereAleatoareRound2 = new Random();
                    int[] arrayDeNumereRound2 = new int[1];
                    for (int r2 = 0; r2 < arrayDeNumereRound2.Length; r2++)
                    {
                        arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                        if (b != arrayDeNumereRound2[r2])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                            Console.WriteLine("                                    |" + b + "| +  +          | Wrong Number! | 2 Attempts!|");
                            if (b != arrayDeNumereRound2[r2])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (b == arrayDeNumereRound2[r2] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 2                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(b + " ");
                        if (b == arrayDeNumereRound2[r2])
                        {
                            round2 = round3;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 3!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round2;
                    string game3Round2Input = Console.ReadLine();
                    bool game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    while (!game3Round2Valid)
                    {
                        game3Round2Input = Console.ReadLine();
                        game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    }
                    Console.Clear();
                    if (game3Round2 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round2 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round2 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 2 Attempt 4
                if (round1 == 1)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 2                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int b;
                    string bInput = Console.ReadLine();
                    bool bValid = int.TryParse(bInput, out b);
                    while (!bValid)
                    {
                        bInput = Console.ReadLine();
                        bValid = int.TryParse(bInput, out b);
                    }
                    Console.Clear();
                    if (b == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (b < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (b > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound2 = 1;
                    const int limitaSuperioaraRound2 = 5;
                    Random generatorDeNumereAleatoareRound2 = new Random();
                    int[] arrayDeNumereRound2 = new int[1];
                    for (int r2 = 0; r2 < arrayDeNumereRound2.Length; r2++)
                    {
                        arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                        if (b != arrayDeNumereRound2[r2])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                            Console.WriteLine("                                    |" + b + "| +             | Wrong Number! | 1 Attempts!|");
                            if (b != arrayDeNumereRound2[r2])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (b == arrayDeNumereRound2[r2] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 2                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(b + " ");
                        if (b == arrayDeNumereRound2[r2])
                        {
                            round2 = round3;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 3!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round2;
                    string game3Round2Input = Console.ReadLine();
                    bool game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    while (!game3Round2Valid)
                    {
                        game3Round2Input = Console.ReadLine();
                        game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    }
                    Console.Clear();
                    if (game3Round2 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round2 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round2 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 2 Attempt 5
                if (round2 == 2)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 2                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int b;
                    string bInput = Console.ReadLine();
                    bool bValid = int.TryParse(bInput, out b);
                    while (!bValid)
                    {
                        bInput = Console.ReadLine();
                        bValid = int.TryParse(bInput, out b);
                    }
                    Console.Clear();
                    if (b == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (b < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (b > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound2 = 1;
                    const int limitaSuperioaraRound2 = 5;
                    Random generatorDeNumereAleatoareRound2 = new Random();
                    int[] arrayDeNumereRound2 = new int[1];
                    for (int r2 = 0; r2 < arrayDeNumereRound2.Length; r2++)
                    {
                        arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                        if (b != arrayDeNumereRound2[r2])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound2[r2] = generatorDeNumereAleatoareRound2.Next(limitaInferioaraRound2, limitaSuperioaraRound2 + 1);
                            Console.WriteLine("                                    |" + b + "|               | Wrong Number! | 0 Attempts!|");
                            if (b != arrayDeNumereRound2[r2])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Continue To Round 2!                        |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (b == arrayDeNumereRound2[r2] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (b == arrayDeNumereRound2[r2] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 2                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(b + " ");
                        if (b == arrayDeNumereRound2[r2])
                        {
                            round2 = round3;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 2                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Continue To Round 3!                          |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round2;
                    string game3Round2Input = Console.ReadLine();
                    bool game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    while (!game3Round2Valid)
                    {
                        game3Round2Input = Console.ReadLine();
                        game3Round2Valid = int.TryParse(game3Round2Input, out game3Round2);
                    }
                    Console.Clear();
                    if (game3Round2 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round2 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round2 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                Console.Clear();
                // Round 3
                if (round3 == 3)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 3                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |-  | +  +  +  +  + | 5 Attempts!              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |1:Choose                                      |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int game3Round3;
                    string game3Round3Input = Console.ReadLine();
                    bool game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    while (!game3Round3Valid)
                    {
                        game3Round3Input = Console.ReadLine();
                        game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    }
                    Console.Clear();
                    if (game3Round3 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round3 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round3 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 3 Attempt 1
                if (round3 == 3)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 3                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int c;
                    string cInput = Console.ReadLine();
                    bool cValid = int.TryParse(cInput, out c);
                    while (!cValid)
                    {
                        cInput = Console.ReadLine();
                        cValid = int.TryParse(cInput, out c);
                    }
                    Console.Clear();
                    if (c == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (c < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (c > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound3 = 1;
                    const int limitaSuperioaraRound3 = 5;
                    Random generatorDeNumereAleatoareRound3 = new Random();
                    int[] arrayDeNumereRound3 = new int[1];
                    for (int r3 = 0; r3 < arrayDeNumereRound3.Length; r3++)
                    {
                        arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                        if (c != arrayDeNumereRound3[r3])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                            Console.WriteLine("                                    |" + c + "| +  +  +  +    | Wrong Number! | 4 Attempts!|");
                            if (c != arrayDeNumereRound3[r3])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (c == arrayDeNumereRound3[r3] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 3                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(c + " ");
                        if (c == arrayDeNumereRound3[r3])
                        {
                            round3 = gameover;
                            numberofgames = numberofgames + 1;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round3;
                    string game3Round3Input = Console.ReadLine();
                    bool game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    while (!game3Round3Valid)
                    {
                        game3Round3Input = Console.ReadLine();
                        game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    }
                    Console.Clear();
                    if (game3Round3 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round3 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round3 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 3 Attempt 2
                if (round3 == 3)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 3                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int c;
                    string cInput = Console.ReadLine();
                    bool cValid = int.TryParse(cInput, out c);
                    while (!cValid)
                    {
                        cInput = Console.ReadLine();
                        cValid = int.TryParse(cInput, out c);
                    }
                    Console.Clear();
                    if (c == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (c < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (c > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound3 = 1;
                    const int limitaSuperioaraRound3 = 5;
                    Random generatorDeNumereAleatoareRound3 = new Random();
                    int[] arrayDeNumereRound3 = new int[1];
                    for (int r3 = 0; r3 < arrayDeNumereRound3.Length; r3++)
                    {
                        arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                        if (c != arrayDeNumereRound3[r3])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                            Console.WriteLine("                                    |" + c + "| +  +  +       | Wrong Number! | 3 Attempts!|");
                            if (c != arrayDeNumereRound3[r3])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (c == arrayDeNumereRound3[r3] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 3                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(c + " ");
                        if (c == arrayDeNumereRound3[r3])
                        {
                            round3 = gameover;
                            numberofgames = numberofgames + 1;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round3;
                    string game3Round3Input = Console.ReadLine();
                    bool game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    while (!game3Round3Valid)
                    {
                        game3Round3Input = Console.ReadLine();
                        game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    }
                    Console.Clear();
                    if (game3Round3 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round3 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round3 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 3 Attempt 3
                if (round3 == 3)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 3                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int c;
                    string cInput = Console.ReadLine();
                    bool cValid = int.TryParse(cInput, out c);
                    while (!cValid)
                    {
                        cInput = Console.ReadLine();
                        cValid = int.TryParse(cInput, out c);
                    }
                    Console.Clear();
                    if (c == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (c < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (c > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound3 = 1;
                    const int limitaSuperioaraRound3 = 5;
                    Random generatorDeNumereAleatoareRound3 = new Random();
                    int[] arrayDeNumereRound3 = new int[1];
                    for (int r3 = 0; r3 < arrayDeNumereRound3.Length; r3++)
                    {
                        arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                        if (c != arrayDeNumereRound3[r3])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                            Console.WriteLine("                                    |" + c + "| +  +          | Wrong Number! | 2 Attempts!|");
                            if (c != arrayDeNumereRound3[r3])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (c == arrayDeNumereRound3[r3] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 3                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(c + " ");
                        if (c == arrayDeNumereRound3[r3])
                        {
                            round3 = gameover;
                            numberofgames = numberofgames + 1;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round3;
                    string game3Round3Input = Console.ReadLine();
                    bool game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    while (!game3Round3Valid)
                    {
                        game3Round3Input = Console.ReadLine();
                        game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    }
                    Console.Clear();
                    if (game3Round3 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round3 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round3 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 3 Attempt 4
                if (round3 == 3)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 3                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int c;
                    string cInput = Console.ReadLine();
                    bool cValid = int.TryParse(cInput, out c);
                    while (!cValid)
                    {
                        cInput = Console.ReadLine();
                        cValid = int.TryParse(cInput, out c);
                    }
                    Console.Clear();
                    if (c == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (c < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (c > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound3 = 1;
                    const int limitaSuperioaraRound3 = 5;
                    Random generatorDeNumereAleatoareRound3 = new Random();
                    int[] arrayDeNumereRound3 = new int[1];
                    for (int r3 = 0; r3 < arrayDeNumereRound3.Length; r3++)
                    {
                        arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                        if (c != arrayDeNumereRound3[r3])
                        {
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                            Console.WriteLine("                                    |" + c + "| +             | Wrong Number! | 1 Attempts!|");
                            if (c != arrayDeNumereRound3[r3])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Choose                                      |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (c == arrayDeNumereRound3[r3] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 3                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(c + " ");
                        if (c == arrayDeNumereRound3[r3])
                        {
                            round3 = gameover;
                            numberofgames = numberofgames + 1;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round3;
                    string game3Round3Input = Console.ReadLine();
                    bool game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    while (!game3Round3Valid)
                    {
                        game3Round3Input = Console.ReadLine();
                        game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    }
                    Console.Clear();
                    if (game3Round3 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round3 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round3 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Round 3 Attempt 5
                if (round3 == 3)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                    Round 3                   |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |Pick a number from 1 to 5!                    |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int c;
                    string cInput = Console.ReadLine();
                    bool cValid = int.TryParse(cInput, out c);
                    while (!cValid)
                    {
                        cInput = Console.ReadLine();
                        cValid = int.TryParse(cInput, out c);
                    }
                    Console.Clear();
                    if (c == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (c < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (c > 5)
                    {
                        continue;
                    }
                    Console.Clear();
                    const int limitaInferioaraRound3 = 1;
                    const int limitaSuperioaraRound3 = 5;
                    Random generatorDeNumereAleatoareRound3 = new Random();
                    int[] arrayDeNumereRound3 = new int[1];
                    for (int r3 = 0; r3 < arrayDeNumereRound3.Length; r3++)
                    {
                        arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                        if (c != arrayDeNumereRound3[r3])
                        {
                            numberofgames = numberofgames + 1;
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            arrayDeNumereRound3[r3] = generatorDeNumereAleatoareRound3.Next(limitaInferioaraRound3, limitaSuperioaraRound3 + 1);
                            Console.WriteLine("                                    |" + c + "|               | Wrong Number! | 0 Attempts!|");
                            if (c != arrayDeNumereRound3[r3])
                            {
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |1:Continue                                    |");
                                Console.WriteLine("                                    |                                              |");
                                Console.WriteLine("                                    |0:Back                                        |");
                                Console.WriteLine("                                    |                                              |");
                                if (c == arrayDeNumereRound3[r3] - 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] - 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 1)
                                {
                                    Console.WriteLine("                                    |You are close by!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                if (c == arrayDeNumereRound3[r3] + 2)
                                {
                                    Console.WriteLine("                                    |You are far away!                             |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    Console.WriteLine("                                    |                                              |");
                                    continue;
                                }
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.Write("                                                    |                    Round 3                   |");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(c + " ");
                        if (c == arrayDeNumereRound3[r3])
                        {
                            round3 = gameover;
                            numberofgames = numberofgames + 1;
                            numberofrounds = numberofrounds + 1;
                            Console.Clear();
                            Console.WriteLine("                                                                                    ");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                    Round 3                   |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |Right Number! You Win!                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |1:Continue                                    |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |0:Back                                        |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            Console.WriteLine("                                    |                                              |");
                            continue;
                        }
                    }
                    Console.Write("Select: ");
                    int game3Round3;
                    string game3Round3Input = Console.ReadLine();
                    bool game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    while (!game3Round3Valid)
                    {
                        game3Round3Input = Console.ReadLine();
                        game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    }
                    Console.Clear();
                    if (game3Round3 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round3 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round3 > 1)
                    {
                        continue;
                    }
                    Console.Clear();
                }
                // Game Over
                if (gameover == 4)
                {
                    Console.WriteLine("                                                                                    ");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                   Game Over!                 |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |2:Statistics                                  |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |1:Play                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |0:Back                                        |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.WriteLine("                                    |                                              |");
                    Console.Write("Select: ");
                    int game3Round3;
                    string game3Round3Input = Console.ReadLine();
                    bool game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    while (!game3Round3Valid)
                    {
                        game3Round3Input = Console.ReadLine();
                        game3Round3Valid = int.TryParse(game3Round3Input, out game3Round3);
                    }
                    Console.Clear();
                    if (game3Round3 == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    if (game3Round3 == 1)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round3 < 0)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round3 > 2)
                    {
                        continue;
                    }
                    Console.Clear();
                    if (game3Round3 == 2)
                    {
                        gameover = round1;
                        Console.WriteLine("                                                                                    ");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                  Statistics                  |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine($"                                    |Games  | {numberofgames}                                    |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine($"                                    |Rounds | {numberofrounds}                                    |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |1:Play                                        |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |0:Back                                        |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.WriteLine("                                    |                                              |");
                        Console.Write("Select: ");
                        int game4;
                        string game4Input = Console.ReadLine();
                        bool game4Valid = int.TryParse(game4Input, out game4);
                        while (!game4Valid)
                        {
                            game4Input = Console.ReadLine();
                            game4Valid = int.TryParse(game4Input, out game4);
                        }
                        Console.Clear();
                        if (game4 == 0)
                        {
                            break;
                        }
                        Console.Clear();
                        if (game4 > 1)
                        {
                            continue;
                        }
                        Console.Clear();
                        if (game4 < 0)
                        {
                            continue;
                        }
                        Console.Clear();
                        if (game4 == 1)
                        {
                            game3Round3 = round1;
                        }
                    }
                }
                Console.Clear();
            }
            Console.Clear();
        } while (game2 == 1);
        Console.Clear();
        // Statistics
        do
        {
            if (game2 == 2)
            {
                Console.WriteLine("                                                                                    ");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                  Statistics                  |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine($"                                    |Games  | {numberofgames}                                    |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine($"                                    |Rounds | {numberofrounds}                                    |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |1:Clear                                       |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |0:Back                                        |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.Write("Select: ");
                int game4;
                string game4Input = Console.ReadLine();
                bool game4Valid = int.TryParse(game4Input, out game4);
                while (!game4Valid)
                {
                    game4Input = Console.ReadLine();
                    game4Valid = int.TryParse(game4Input, out game4);
                }
                Console.Clear();
                if (game4 == 0)
                {
                    break;
                }
                Console.Clear();
                if (game4 > 1)
                {
                    continue;
                }
                Console.Clear();
                if (game4 < 0)
                {
                    continue;
                }
                Console.Clear();
                if (game4 == 1)
                {
                    numberofrounds = 0;
                    numberofgames = 0;
                }
            }
        } while (game2 == 2);
        Console.Clear();
        // Instructions
        do
        {
            if (game2 == 3)
            {
                Console.WriteLine("                                                                                    ");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                 Instructions                 |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |Each game has 3 rounds.                       |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |You have 5 attempts per round.                |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |If you burn all attempts, you lose the round. |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |Using Numpad on your keyboard is recommended. |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |0:Back                                        |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.WriteLine("                                    |                                              |");
                Console.Write("Select: ");
                int game5;
                string game5Input = Console.ReadLine();
                bool game5Valid = int.TryParse(game5Input, out game5);
                while (!game5Valid)
                {
                    game5Input = Console.ReadLine();
                    game5Valid = int.TryParse(game5Input, out game5);
                }
                Console.Clear();
                if (game5 == 0)
                {
                    break;
                }
                Console.Clear();
                if (game5 > 0)
                {
                    continue;
                }
                Console.Clear();
                if (game5 < 0)
                {
                    continue;
                }
                Console.Clear();
            }
            Console.Clear();
        } while (game2 == 3);
        Console.Clear();
        // Exit
        if (game2 == 4)
        {
            break;
        }
        Console.Clear();
    } while (game0 == 1);
    Console.Clear();
} while (game0 == 1);
Console.Clear();