Console.WriteLine("Welcome to the Detroit Casino!");

//Use exception handling to only allow numbers
int numberOfSides;
int firstRoll;
int secondRoll;
int total;
while (true)
{
    try
    {
        Console.WriteLine("Please enter the number of sides for a pair of dice");
        if (int.TryParse(Console.ReadLine(), out numberOfSides) && numberOfSides >= 1)

        {
            Console.WriteLine($"You picked {numberOfSides} sides.");
            break;
        }
        else
        {
            Console.WriteLine("Enter a valid number.");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    
}

Console.WriteLine("Now lets play the game! Please roll your dice");

if (numberOfSides == 6)
{
    firstRoll = GetRandom(numberOfSides);
    secondRoll = GetRandom(numberOfSides);
    total = firstRoll + secondRoll;

    Console.WriteLine($"Your total for the roll is {total}");

    Console.WriteLine(sixSidedDie(firstRoll, secondRoll));
}
else
{
    firstRoll = GetRandom(numberOfSides);
    secondRoll = GetRandom(numberOfSides);
    total = firstRoll + secondRoll;

    Console.WriteLine($"Your total for the roll is {total}");
}



static int GetRandom(int r)
{
    Random rnd = new Random();
    return rnd.Next(1, r);
}

static string sixSidedDie (int diceV1, int diceV2)
{
    string resonse;
    if(diceV1 == 1 && diceV2 == 1)
    {
        return "Snake Eyed";
    }
    if(diceV1 == 1 && diceV2 ==2 || diceV2 == 2 && diceV1 == 1)
    {
        return "Ace Deuce";
    }
    if(diceV1 == 6 && diceV2 == 6)
    {
        return "Box Cars";
    }
    if(diceV1 + diceV2 == 7)
    {
        return "Win!";
    }
    if(diceV1 + diceV2 == 11)
    {
        return "Win!";
    }
    if(diceV1 + diceV2 == 2 || diceV1 + diceV2 == 3 || diceV1 + diceV2 == 12)
    {
        return "Craps";
    }
    else
    {
        return " ";
    }
}


//for (int i = 0; i < numberOfSides; i++)
//{
//    Console.WriteLine(rnd.Next(1,13));
//}

/*static bool GoAgain()
  {
      while(true)
      {
            Console.WriteLine("Do you want to go again(y/n)?");
            string input = Console.ReadLine();
            try
            {
                if(input.ToLower().Trim() == "y"
                {
                    return true;
                }
                else if(input.ToLower().Trim() == "n")
                {
                    return false;
                }
                else
                {
                    throw new exception("Not a valid option, please try again.");
                }
            }
            catch(Exception e)
            {
                Consol.WriteLine(e.Message);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);

        }
    }
}
*/
