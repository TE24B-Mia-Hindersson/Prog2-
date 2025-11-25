Console.WriteLine("==Welcome to Stardust pet adoption!==");
Console.ReadLine();
Console.Clear();
Console.WriteLine("   Please tell me which, between these lovely three pets you would like?");
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("                      1. Duck (difficulty easy)");
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("                     2. Frog (difficulty medium)");
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("                      3. Cat (difficulty hard)");
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("                   Enter the number of your choice:");
int choicep = 0;
string input;
string pet = "";
int difficulty = 10;
string diff;
while (choicep <= 0)
{
    input = Console.ReadLine();
    bool Success = int.TryParse(input, out choicep);
    if (!Success | choicep < 1 || choicep > 3)
    {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("         Please choose a valid pet!!");
        Console.WriteLine("------------------------------------------------");
        choicep = 0;
        Console.ReadLine();
        Console.Clear();
    }
    else
    {
        break;
    }
}
if (choicep == 1)
{
    pet = "Duck";
    difficulty = 10;
}
else if (choicep == 2)
{
    pet = "Frog";
    difficulty = 20;
}
else if (choicep == 3)
{
    pet = "Cat";
    difficulty = 30;
}
if (difficulty == 10)
{
    diff = "easy";
}
else if (difficulty == 20)
{
    diff = "medium";
}
else if (difficulty == 30)
{
    diff = "hard";
}
else
{
    diff = "unknown";
}
Console.WriteLine("------------------------------------------");
Console.WriteLine("           Excellent choice!");
Console.WriteLine($"        --you now own a {pet}--");
Console.WriteLine($"       --difficulty level:{diff}--");
Console.WriteLine("-------------------------------------------");
Console.ReadLine();
Console.Clear();

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Would you like to choose a name, or be given a prechosen name?");
Console.WriteLine("             For prechosen name type 'random'");
Console.WriteLine("             For own chosen name type 'yes'");
Console.WriteLine("----------------------------------------------------------------");
string input1 = Console.ReadLine();
while (input1 != "yes" && input1 != "random")
{
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Please type either 'yes' or 'random':");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    input1 = Console.ReadLine().ToLower();
}
string[] randname = { "Mia", "Bosse", "Leon", "Bert" };
string name = "";
if (input1 == "yes")
{
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"Great! Now let me know what youd like to name your {pet}:");
    name = Console.ReadLine();
    Console.WriteLine($"Aww what a wonderful name!");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
}
else if (input1 == "random")
{
    name = randname[Random.Shared.Next(randname.Length)];
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"Prechosen name chosen: {name}");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
}
while (string.IsNullOrWhiteSpace(name) || name.Length < 2 || name.Length > 12)
{
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Name must be between 2 and 12 characters. Try again:");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    name = Console.ReadLine();
}
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"Your new pets name is now: {name}");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();
Console.Clear();
int money = 100;
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("I will now give you a small amount of coins to begin taking care of your new pet!");
Console.WriteLine($"                  -Coins added to wallet: {money}-");
Console.WriteLine("Also! Before you go, please take this manual that explains your pet.. Good luck!! ");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();
Console.Clear();
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"-You walk home with your new pet {name}!-");
Console.WriteLine($"-{name} is only little at the moment so you will have to care for them until they grow-");
Console.WriteLine($"--You take out the manual given to you at the adoption agency--");
Console.WriteLine($"--The {pet} will go through different stages of life.--");
Console.WriteLine("These are as follows:");
if (pet == "Frog" || pet == "Duck")
{
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("--The egg stage. Your pet is still new born.--");
    Console.WriteLine("--To progress you will have to tap the egg, but be patient as overdoing it may cause your pet to come out the egg very unhappy!!--");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
}
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("--The baby stage.--");
Console.WriteLine("--This stage is by far the most tricky! Be sure to carefully take care of your pet during this stage.--");
Console.WriteLine("--Your pet will not like bathing all that much during this stage. Your pet will also tire very fast during this stage, so be careful not to overwork your pet!--");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("--The teen stage.--");
Console.WriteLine("--In this stage you will have to keep a keen eye on your pet, they will need more playtime, food and will lose happiness very fast! Be sure to pay attention!!--");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("--The adult stage.--");
Console.WriteLine("--The longest stage. Way more indepented and will even bathe itself in certain circumstances.--");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("--The elder stage.--");
Console.WriteLine("--The saddest stage. Your pet is nearing its end of life.. Elder pets do not enjoy playing as much as before anymore.--");
Console.WriteLine("--Pets at this stage are very dependent on food and care. Pay close attention to prolonge their life.--");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();
Console.Clear();
string currentstage = "";
string egg = "Egg Stage";
string baby = "Baby Stage";
string teen = "Teen Stage";
string adult = "Adult Stage";
string elder = "Elder Stage";
if (pet == "Frog" || pet == "Duck")
{
    currentstage = egg;
}
else if (pet == "Cat")
{
    currentstage = baby;
}
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"-Your {pet} is currently in the stage: {currentstage}!-");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();
Console.Clear();
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"-You enter your home with {name}-");
if (currentstage == egg)
{
   Console.WriteLine("-You remember what was said in the manual-"); 
   Console.WriteLine("-Tap the egg to begin!-"); 
   Console.WriteLine("---write tap to continue!!---");
   Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
   string input2 = Console.ReadLine();
   Console.Clear();
   if (input2 == "tap")
    {
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("-You feel the egg move-");
        Console.WriteLine("-You hear a subtle coo from inside-");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();

    }
    else
    {
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---Please tap the egg!---");
        Console.WriteLine("---write tap to continue!!---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
         Console.ReadLine();
    }
}
int happiness = 100;
int hunger = 100;
int energy = 100;
int health = 100;
int cleanness = 100;
static void info(int happiness, int hunger, int energy, int health, int cleanness)
{
     Console.WriteLine($"Happiness: {happiness}   Hunger: {hunger}   Energy: {energy}   Health: {health}   Cleanliness: {cleanness}");
     Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
}



Console.ReadLine();