// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
/*
string playerClass = ("");
string classChoice = ("");
bool pickedAclass = false;
 

while (pickedAclass != true) {
    Console.WriteLine("Welcome to Elysium!");
    Console.Write(" Choose a class:");
    Console.WriteLine(" Press W for warrior, M for Mage and R for Rogue");
    classChoice = Console.ReadLine();

switch(classChoice) 
    {
        case "W":
            playerClass = ("Warrior");
            Console.WriteLine("Strong and true, the bravehearted fighter has been chosen.");
            pickedAclass = true;
            break;
        case "M":
            playerClass = ("Mage");
            Console.WriteLine("Master of the mystic arts, the mage has been chosen.");
            pickedAclass = true;
            break;
        case "R":
            playerClass = ("Rogue");
            Console.WriteLine("Equal parts cunning and quick, the nimble rogue has been chosen.");
            pickedAclass = true;
            break;
        default:
            Console.WriteLine("Invalid choice, try again.");
            Console.Clear();
            break;  
    }

}
Console.WriteLine(" Enter your name:");
string playerName = Console.ReadLine();

Console.WriteLine( playerName+" the " + playerClass + ", the world awaits.");
Console.WriteLine(" Press enter to continue");
Console.ReadLine();
Console.Clear();
*/
static void Continue()
{
    Console.WriteLine("Press 'enter' to continue");
    Console.ReadLine();
    Console.Clear();
}
/*
static void FreeRoam()
{
    string moveDirection = "";
    bool pointOfInterest = false;
    int northCount = 0;
    int southCount = 0;
    int westCount = 0;
    int eastCount = 0;
    int moveCount = 0;
    while (pointOfInterest == false)
    {
        Console.Clear();
        Console.WriteLine("Choose a diection.");
        moveDirection = Console.ReadLine();
        switch (moveDirection)
        {
            case "w":
                Console.WriteLine("You walk a few feet to the north.");
                northCount++;
                moveCount = (northCount + southCount + westCount + eastCount);
                
                pointOfInterest = true;
                break;
            case "a":
                Console.WriteLine("You walk a few feet to the west.");
                westCount++;
                moveCount = (northCount + southCount + westCount + eastCount);
                
                pointOfInterest = true;

                break;
            case "s":
                Console.WriteLine("You walk a few feet to the south.");
                southCount++;
                moveCount = (northCount + southCount + westCount + eastCount);
               
                pointOfInterest = true;

                break;
            case "d":
                Console.WriteLine("You walk a few feet to the east.");
                eastCount++;
                moveCount = (northCount + southCount + westCount + eastCount);
             
                pointOfInterest = true;
                break;
            default:
                Console.WriteLine("Invalid choice, try again.");
                Console.Clear();
                
                pointOfInterest = true;
                break;

        }
    }
    Console.WriteLine(moveCount);
}

Console.WriteLine("Upon entering the cave of wonders , your eyes dialate quickly, adjusting to the sudden shift from brilliant white sunlight to your new cool dank surroundings.");
Continue();
Console.WriteLine("After this brief message, you will see a map, at any given time, your options for what to do next will be based on the symbols you can see on said map");
Console.WriteLine("You will always be represented on the map as the letter Y");
Continue();
Console.WriteLine(" After this message you will be expected to press the W,A,S,and D keys to move in the directions coresponding to their cardinal direcions on your keyboard");
Continue();
FreeRoam ();

*/

// If there are issues with anything from here on, note that I typed this all up at 2:30 AM with no sleep and a baby in my arms

int Str = 12;
int Dex = 12;
int Wis = 12;

string poiTheFog = "heavy fog";

string poiTheChest = "chest";
static bool PoiTheChest(int Str, int Dex)
{
    string userInput;
    Console.WriteLine("Upon closer inspection, the chest appears to be roughly hewn from scrapwood and sheet metal, not like your typical storage chests. The thing looks more like a hastily thrown together bin with a lock.");
    if (Str >= 11)
    {
        Console.WriteLine("The lock seems secure enough, but the boxes construction is shody at best, you think you might be able to simply smash through the side.");
        Console.WriteLine("Press the 'S' key to smash the box.");
        userInput = Console.ReadLine();
        if (userInput == "s" )
        {
            Console.WriteLine("You rear back in preparation to kick the thing with all your might.");
            Console.WriteLine("CRASH!!");
            Console.WriteLine("Your armored clad boot tears wood from metal, leaving the contents exposed.");
            Continue();
            Console.WriteLine("Legend of Zelda treasure chest music .mp4");
            Console.WriteLine("You found a mysterious blue stone.");
                return true;
        }
        else
        {
            Console.WriteLine("Better not mess around with this too much.");
            return false;
        }

        
           
    }
    else if (Dex >= 11)
    {
        Console.WriteLine("Upon closer inspection, the lock seems to like it would be easily raked open with the proper set of picks. A set you happen to be proficient with.");
        Console.WriteLine("Press the 'P' key to pick the lock.");
        userInput = Console.ReadLine();
        if (userInput == "p" ) 
        {
            Console.WriteLine("You deftly slip your metalic shim into the lock making short work of its defences.");
            Continue();
            Console.WriteLine("Legend of Zelda treasure chest music .mp4");
            Console.WriteLine("You found a mysterious blue stone.");
            return true;
        }
        else
        {
            Console.WriteLine("Better not mess around with this too much.");
            return false;
        }
    }
    else
    {
        Console.WriteLine("Hmm, it looks like without a key there isnt much you can do.");
        return false;
    }
}
static bool PoiTheMimic(int Wis)
{
    if (Wis >= 11 )
    {
        Console.WriteLine("As you turn to walk away, you see something shift out of the corner of your eye.");
        Console.WriteLine("After a second look, nothing looks out of sorts, so you decide to move forward with your weapon drawn as a precaution.");
        return true;
    }
    else
    {
        return false;
    }
}
static bool PointOfInterestRunner(string poiName)
{
    Console.WriteLine("You notice a " + poiName + " a short ways ahead." );
    Console.WriteLine("Press 'enter' to approach.");
    Console.WriteLine("Press another input to skip this encounter");
    string playerChoice = Console.ReadLine();
    if( playerChoice == "")
    {
        Console.Clear();
        Console.WriteLine("You make your way closer for a better view");
        Continue();
        return true;
    }
    else 
    {
        Console.Clear() ;
        Console.WriteLine("You decide you'd better leave it for another to happen upon.");
        Continue();
        return false;
    }
}


if(PointOfInterestRunner(poiTheChest))
{
    PoiTheChest(Str, Dex);
}
else
{
    PoiTheMimic(Wis);
}

static bool PoiTheFog(int Wis, int Int)
{
    Console.WriteLine("");
}

if(PointOfInterestRunner(poiTheFog))
{
    PoiTheFog();
}
else
{
    Continue();
}
    
