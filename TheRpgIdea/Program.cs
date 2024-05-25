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


string poiTheChest = "chest";
static void PoiTheChest(int Str, int Dex)
{
    Console.WriteLine("Upon closer inspection, the chest appears to be roughly hewn from scrapwood and sheet metal, not like your typical storage chests. The thing looks more like a hastily thrown together bin with a lock.");
    if (Str >= 11)
    {
        Console.WriteLine("The lock seems secrue enough, but the boxes construction is shody at best, you think you might be able to simply smash through the side.");
        Console.WriteLine("Press the 'S' key to smash the box.");
        
           
    }
}
static void PoiTheMimic()
{

}
static bool PointOfInterest(string poiName)
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


if(PointOfInterest(poiTheChest))
{
    PoiTheChest(Str, Dex);
}
else
{
    PoiTheMimic();
}
    
