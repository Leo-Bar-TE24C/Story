Console.WriteLine("Press enter to start");
Console.ReadLine();

Console.WriteLine("Chose a name");
string name = Console.ReadLine();

Console.WriteLine("You find yourself in dark a cave, with no recollection of how you got there. What would you like to do?");
Console.WriteLine("""
A) Investigate
B) Look through bag
C) Look for an exit
""");
string choice1 = Console.ReadLine().ToLower();



// failsafe
while (choice1 != "a" && choice1 != "b" && choice1 != "c" && choice1 != "investigate" && choice1 != "look trhough bag" && choice1 != "look for an exit")
{
    Console.WriteLine("Sorry that's not an option, try again");
    Console.WriteLine("""
A) Investigate
B) Look through bag
C) Look for an exit
""");
    choice1 = Console.ReadLine().ToLower();
}



// path 1
if (choice1 == "b" || choice1 == "look through bag")
{
    Console.WriteLine("You find a flashlight");
    Console.WriteLine("""
A) Investigate
B) Look for an exit
""");
    string choice3 = Console.ReadLine().ToLower();

    while (choice3 != "a" && choice3 != "investigate" && choice3 != "b" && choice3 != "look for an exit")
    {
        Console.WriteLine("Sorry that's not an option, try again");
        Console.WriteLine("""
        A) Investigate
        B) Look for an exit
        """);

        choice3 = Console.ReadLine().ToLower();


    }
    if (choice3 == "a" || choice3 == "investigate")
    {
        Console.WriteLine("""You see a switch with a label that reads "DO NOT FLIP" """);
        Console.WriteLine("Flip switch?");
        Console.WriteLine("""
            A) Yes
            B) No
            """);

        string choice5 = Console.ReadLine().ToLower();

        while (choice5 != "a" && choice5 != "b" && choice5 != "yes" && choice5 != "no")
        {
            Console.WriteLine("Sorry that's not an option, try again");
            Console.WriteLine("""
        A) Yes
        B) No
        """);
            choice5 = Console.ReadLine().ToLower();
        }

        if (choice5 == "a" || choice5 == "yes")
        {
            Console.WriteLine($"You hear the whirring of machines coming to life, a gas starts filling the room \n{name}loses conciousnes");
            Console.WriteLine("""
  ____                                            
 / ___| __ _ _ __ ___   ___    _____   _____ _ __ 
| |  _ / _` | '_ ` _ \ / _ \  / _ \ \ / / _ \ '__|
| |_| | (_| | | | | | |  __/ | (_) \ V /  __/ |   
 \____|\__,_|_| |_| |_|\___|  \___/ \_/ \___|_|   
""");
        }

        if (choice5 == "b" || choice5 == "no")
        {
            Console.WriteLine("You decide to move along and find an exit");
            Console.WriteLine("You come to a fork on the road \nThanks to the light of your flaslight you see beartraps on the right path \nYou go left");
            Console.WriteLine(name + " managed to make it out of the cave.");
            Console.WriteLine("""
            __   __                     _       
            \ \ / /__  _   _  __      _(_)_ __  
             \ V / _ \| | | | \ \ /\ / / | '_ \ 
              | | (_) | |_| |  \ V  V /| | | | |
              |_|\___/ \__,_|   \_/\_/ |_|_| |_|
            """);

        }

    }
        if (choice3 == "b" || choice3 == "look for an exit")
        {
            Console.WriteLine("You come to a fork on the road \nThanks to the light of your flaslight you see beartraps on the right path \nYou go left");
            Console.WriteLine(name + " managed to make it out of the cave.");
            Console.WriteLine("""
            __   __                     _       
            \ \ / /__  _   _  __      _(_)_ __  
             \ V / _ \| | | | \ \ /\ / / | '_ \ 
              | | (_) | |_| |  \ V  V /| | | | |
              |_|\___/ \__,_|   \_/\_/ |_|_| |_|
            """);
        }
}
    



// path 2 (no right choice)
    if (choice1 == "a" || choice1 == "investigate")
    {
        Console.WriteLine("""
        You feel around for any clues as to why you're here and just as you're starting to give up you feel what apears to be a switch
        Do you flip it?"
        A) Yes
        B) No
        """);
        string choice2 = Console.ReadLine().ToLower();


        while (choice2 != "a" && choice2 != "b" && choice2 != "yes" && choice2 != "no")
        {
            Console.WriteLine("Sorry that's not an option, try again");
            Console.WriteLine("""
        A) Yes
        B) No
        """);
            choice2 = Console.ReadLine().ToLower();
        }


        if (choice2 == "a" || choice2 == "yes")
        {
            Console.WriteLine($"You hear the whirring of machines coming to life, a gas starts filling the room \n{name}loses conciousnes");
            Console.WriteLine("""
  ____                                            
 / ___| __ _ _ __ ___   ___    _____   _____ _ __ 
| |  _ / _` | '_ ` _ \ / _ \  / _ \ \ / / _ \ '__|
| |_| | (_| | | | | | |  __/ | (_) \ V /  __/ |   
 \____|\__,_|_| |_| |_|\___|  \___/ \_/ \___|_|   
""");
        }

        if (choice2 == "b" || choice2 == "no")
        {
            Console.WriteLine("""
You lay defeated, hungry, cold, with no idea where you are or why
  ____                                            
 / ___| __ _ _ __ ___   ___    _____   _____ _ __ 
| |  _ / _` | '_ ` _ \ / _ \  / _ \ \ / / _ \ '__|
| |_| | (_| | | | | | |  __/ | (_) \ V /  __/ |   
 \____|\__,_|_| |_| |_|\___|  \___/ \_/ \___|_|   
""");
        }

    }


// Path 3
if (choice1 == "c" || choice1 == "Look for an exit")
{
    Console.WriteLine("You come to a fork on the road");
    Console.WriteLine("""
A) Right
B) Left
""");
    string choice4 = Console.ReadLine().ToLower();

    while (choice4 != "a" && choice4 != "b" && choice4 != "right" && choice4 != "left")
    {
        Console.WriteLine("Sorry that's noyt an option");
    Console.WriteLine("""
A) Right
B) Left
""");
    choice4 = Console.ReadLine().ToLower();
    }

    if (choice4 == "a" || choice4 == "right")
        {
            Console.WriteLine("""
        As make your way trough the dark passage you step on a bear trap
          ____                                            
         / ___| __ _ _ __ ___   ___    _____   _____ _ __ 
        | |  _ / _` | '_ ` _ \ / _ \  / _ \ \ / / _ \ '__|
        | |_| | (_| | | | | | |  __/ | (_) \ V /  __/ |   
         \____|\__,_|_| |_| |_|\___|  \___/ \_/ \___|_|  
        """);

        }

    if (choice4 == "b" || choice4 == "left")
    {
        Console.WriteLine("After a few minutes of walking in the dark you see light at the en of the tunnel");
        Console.WriteLine(name + " managed to make it out of the cave.");
        Console.WriteLine("""
        __   __                     _       
        \ \ / /__  _   _  __      _(_)_ __  
         \ V / _ \| | | | \ \ /\ / / | '_ \ 
          | | (_) | |_| |  \ V  V /| | | | |
          |_|\___/ \__,_|   \_/\_/ |_|_| |_|
        """);
    }
}



Console.WriteLine(name + "thanks for playing, press anything to exit");
Console.ReadLine();