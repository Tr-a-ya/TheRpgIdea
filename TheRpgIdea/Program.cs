// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

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

