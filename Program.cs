#region software_information
// Author: Noah Fogarty
// Created: 12-Nov-2022
// Version: 1.0.0

Console.Title = "Simple Flash Cards";

string version = "1.0.0";
Console.WriteLine("Simple Flash Cards - Version {0}", version);

Console.WriteLine("\n");
#endregion

#region software_setup
Random rnd = new Random();
#endregion

#region variables
int multiplyBy;

int cardSelect; // Holds a randomly generated number that is used to select which card to display next.
int cardAnswer; // Users answer.

// Used to check if a card or the deck has been completed or not.
bool card01 = false;
bool card02 = false;
bool card03 = false;
bool card04 = false;
bool card05 = false;
bool card06 = false;
bool card07 = false;
bool card08 = false;
bool card09 = false;
bool card10 = false;
bool card11 = false;
bool card12 = false;
bool cardsFinished = false;

bool debug = false; // !!!DEBUG MODE!!!
#endregion

#region console_output
Console.Write("What would you like to multiply by?: ");
multiplyBy = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
while (!cardsFinished) // If user has gone through all cards, this will stop looping.
{
    // Determines whether all cards have been completed or not.
    if (card01 && card02 && card03 && card04 && card05 && card06 && card07 && card08 && card09 && card10 && card11 && card12)
    {
        Console.Beep();
        Console.Write("\nDeck finished! Would you like to continue?: ");
        string restartChoice = Console.ReadLine();
        if (restartChoice == "Yes" || restartChoice == "yes")
        {
            card01 = card02 = card03 = card04 = card05 = card06 = card07 = card08 = card09 = card10 = card11 = card12 = false;
            
            Console.Write("What would you like to multiply by?: ");
            multiplyBy = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
        }
        else cardsFinished = true;
    }

    cardAnswer = 0; // Resets answer.
    cardSelect = rnd.Next(1, 13); // Generates a new random number to determine what card to display next.
    
    // !!!DEBUG MODE!!! -  To enable, change the debug variable from "false" to "true".
    if (debug) Console.WriteLine($"\n Debug - {cardSelect}" + "\n");

    // A series of checks to see if a card has been completed or not.
    // If the card has already been completed, then it skips the card. If not, then it proceeds with the card.
    //
    // This is also where you would change the cards contents, as well as add or remove cards.

    #region cards
    if (cardSelect == 1 && !card01) // multiplyBy X 1
    {
        while (cardAnswer != multiplyBy * 1)
        {
            Console.Write($"What is {multiplyBy} X 1?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card01 = true;
    }

    else if (cardSelect == 2 && !card02) // multiplyBy X 2
    {
        while (cardAnswer != multiplyBy * 2)
        {
            Console.Write($"What is {multiplyBy} X 2?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card02 = true;
    }

    else if (cardSelect == 3 && !card03) // multiplyBy x 3
    {
        while (cardAnswer != multiplyBy * 3)
        {
            Console.Write($"What is {multiplyBy} X 3?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card03 = true;
    }

    else if (cardSelect == 4 && !card04) // multiplyBy X 4
    {
        while (cardAnswer != multiplyBy * 4)
        {
            Console.Write($"What is {multiplyBy} X 4?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card04 = true;
    }
    
    else if (cardSelect == 5 && !card05) // multiplyBy 3 X 5
    {
        while (cardAnswer != multiplyBy * 5)
        {
            Console.Write($"What is {multiplyBy} X 5?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card05 = true;
    }

    else if (cardSelect == 6 && !card06) // multiplyBy X 6
    {
        while (cardAnswer != multiplyBy * 6)
        {
            Console.Write($"What is {multiplyBy} X 6?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card06 = true;
    }

    else if (cardSelect == 7 && !card07) // multiplyBy X 7
    {
        while (cardAnswer != multiplyBy * 7)
        {
            Console.Write($"What is {multiplyBy} X 7?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card07 = true;
    }

    else if (cardSelect == 8 && !card08) // multiplyBy X 8
    {
        while (cardAnswer != multiplyBy * 8)
        {
            Console.Write($"What is {multiplyBy} X 8?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card08 = true;
    }

    else if (cardSelect == 9 && !card09) // multiplyBy X 9
    {
        while (cardAnswer != multiplyBy * 9)
        {
            Console.Write($"What is {multiplyBy} X 9?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card09 = true;
    }

    else if (cardSelect == 10 && !card10) // multiplyBy X 10
    {
        while (cardAnswer != multiplyBy * 10)
        {
            Console.Write($"What is {multiplyBy} X 10?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card10 = true;
    }

    else if (cardSelect == 11 && !card11) // multiplyBy 3 X 11
    {
        while (cardAnswer != multiplyBy * 11)
        {
            Console.Write($"What is {multiplyBy} X 11?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card11 = true;
    }

    else if (cardSelect == 12 && !card12) // multiplyBy X 12
    {
        while (cardAnswer != multiplyBy * 12)
        {
            Console.Write($"What is {multiplyBy} X 12?: ");
            cardAnswer = Convert.ToInt32(Console.ReadLine());
        }
        card12 = true;
    }
    #endregion
}

Console.Clear();
Console.WriteLine("Press any key to exit...");
Console.ReadKey(true); // Pauses program.
#endregion
