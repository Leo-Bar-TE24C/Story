Console.WriteLine("Press enter to start");
Console.ReadLine();

Console.WriteLine("Chose a name");
string name = Console.ReadLine();

Console.WriteLine("You find yourself in dark a cave, with no recollection of how you got there. What would you like to do?");
Console.WriteLine("A) Investigate");
Console.WriteLine("B) Look through bag");
Console.WriteLine("C) Try to find an exit");
string choice1 = Console.ReadLine().ToLower();

if (choice1 == "a" || choice1 == "investigate")
{
    Console.WriteLine("You feel around for any clues as to why you're here and just as you're starting to give up you feel what apears to be a switch");
    Console.WriteLine("");
}

string choice2 = Console.ReadLine().ToLower();
string choice3 = Console.ReadLine().ToLower();
string choice4 = Console.ReadLine().ToLower();

Console.ReadLine();