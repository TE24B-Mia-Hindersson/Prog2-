using System.Reflection.Metadata.Ecma335;
using System.Security;
// skapare spelaren och UI
Player player = new Player();
UI ui = new UI();

// Spelet börjar!
UI.Line();
Console.WriteLine("==Welcome to Bosse pet adoption!==");
UI.Line();
Console.ReadLine();
Console.Clear();
Console.WriteLine("   Please tell me which, between these lovely three pets you would like?");
UI.Line();
Console.WriteLine("                      1. Duck (difficulty easy)");
UI.Line();
Console.WriteLine("                     2. Frog (difficulty medium)");
UI.Line();
Console.WriteLine("                      3. Cat (difficulty hard)");
UI.Line();
Console.WriteLine("                   Enter the number of your choice:");
int PetChoice = 0;
string PetChoiceInput;
string Type = "";
int DifficultyInt = 10;
string DifficultyString;
List<string> FoodInventory = new List<string>();
// loop för att säkerställa gilltigt val
while (PetChoice <= 0)
{
    PetChoiceInput = Console.ReadLine();
    bool Success = int.TryParse(PetChoiceInput, out PetChoice);
    if (!Success | PetChoice < 1 || PetChoice > 3)
    {
       UI.Line();
        Console.WriteLine("         Please choose a valid pet!!");
       UI.Line();
        PetChoice = 0;
        Console.ReadLine();
        Console.Clear();
    }
    else
    {
        break;
    }
}
// gör så att den pet man valde har den difficulty som står övan (difficulty inte gjord än :( )
if (PetChoice == 1)
{
    Type = "Duck";
    DifficultyInt = 10;
}
else if (PetChoice == 2)
{
    Type = "Frog";
    DifficultyInt = 20;
}
else if (PetChoice == 3)
{
    Type = "Cat";
    DifficultyInt = 30;
}
// sätter difficulty som text
if (DifficultyInt == 10)
{
    DifficultyString = "easy";
}
else if (DifficultyInt == 20)
{
    DifficultyString = "medium";
}
else if (DifficultyInt == 30)
{
    DifficultyString = "hard";
}
else
{
    DifficultyString = "unknown";
}
UI.Line();
Console.WriteLine("           Excellent choice!");
Console.WriteLine($"        --you now own a {Type}--");
Console.WriteLine($"       --difficulty level:{DifficultyString}--");
UI.Line();
Console.ReadLine();
Console.Clear();

UI.Line();
Console.WriteLine("Would you like to choose a name, or be given a prechosen name?");
Console.WriteLine("             For prechosen name type 'random'");
Console.WriteLine("             For own chosen name type 'yes'");
UI.Line();
string PetNameInput = Console.ReadLine();
// loop för gilltigt svar för namn
while (PetNameInput != "yes" && PetNameInput != "random")
{
    UI.Line();
    Console.WriteLine("Please type either 'yes' or 'random':");
    UI.Line();
    PetNameInput = Console.ReadLine().ToLower();
}
string[] RandomNames = { "Mia", "Bosse", "Leon", "Bert" };
string PetName = "";
if (PetNameInput == "yes")
{
    UI.Line();
    Console.WriteLine($"Great! Now let me know what youd like to name your {Type}:");
    PetName = Console.ReadLine();
    Console.WriteLine($"Aww what a wonderful name!");
    UI.Line();
}
else if (PetNameInput == "random")
{
    PetName = RandomNames[Random.Shared.Next(RandomNames.Length)];
    UI.Line();
    Console.WriteLine($"Prechosen name chosen: {PetName}");
    UI.Line();
}
// säkerställer att namnen är mellan 2-12 bokstäver (stylistic choice typ)
while (string.IsNullOrWhiteSpace(PetName) || PetName.Length < 2 || PetName.Length > 12)
{
    UI.Line();
    Console.WriteLine("Name must be between 2 and 12 characters. Try again:");
    UI.Line();
    PetName = Console.ReadLine();
}
UI.Line();
Console.WriteLine($"Your new pets name is now: {PetName}");
UI.Line();
Console.ReadLine();
Console.Clear();
// skapar själva husdjuret på riktigt
Pet pet = new Pet
{
   PetName = PetName,
    Type = Type,
    PetCurrentStage = (Type == "Duck" || Type == "Frog")? "Egg Stage" : "Baby Stage"
};
int Money = 100;
UI.Line();
Console.WriteLine("I will now give you a small amount of coins to begin taking care of your new pet!");
Console.WriteLine($"                  -Coins added to wallet: {Money}-");
Console.WriteLine("Also! Before you go, please take this manual that explains your pet.. Good luck!! ");
UI.Line();
Console.ReadLine();
Console.Clear();
UI.Line();
Console.WriteLine($"-You walk home with your new pet {PetName}!-");
Console.WriteLine($"-{PetName} is only little at the moment so you will have to care for them until they grow-");
Console.WriteLine($"--You take out the manual given to you at the adoption agency--");
Console.WriteLine($"--The {Type} will go through different stages of life.--");
Console.WriteLine("These are as follows:");
// förklarar alla stadier av livet
// skulle originellt fungera som något med difficulty men nu gör de bara cat stadiet lättare lol :(
if (Type == "Frog" || Type == "Duck")
{
    UI.Line();
    Console.WriteLine("--The egg stage. Your pet is still new born.--");
    Console.WriteLine("--To progress you will have to tap the egg, but be patient as overdoing it may cause your pet to come out the egg very unhappy!!--");
    UI.Line();
}
UI.Line();
Console.WriteLine("--The baby stage.--");
Console.WriteLine("--This stage is by far the most tricky! Be sure to carefully take care of your pet during this stage.--");
Console.WriteLine("--Your pet will not like bathing all that much during this stage. Your pet will also tire very fast during this stage, so be careful not to overwork your pet!--");
UI.Line();
Console.WriteLine("--The teen stage.--");
Console.WriteLine("--In this stage you will have to keep a keen eye on your pet, they will need more playtime, food and will lose happiness very fast! Be sure to pay attention!!--");
UI.Line();
Console.WriteLine("--The adult stage.--");
Console.WriteLine("--The longest stage. Way more indepented and will even bathe itself in certain circumstances.--");
UI.Line();
Console.WriteLine("--The elder stage.--");
Console.WriteLine("--The saddest stage. Your pet is nearing its end of life.. Elder pets do not enjoy playing as much as before anymore.--");
Console.WriteLine("--Pets at this stage are very dependent on food and care. Pay close attention to prolonge their life.--");
UI.Line();
Console.ReadLine();
Console.Clear();
string PetCurrentStage = "";
string Egg = "Egg Stage";
string Baby = "Baby Stage";
string Teen = "Teen Stage";
string Adult = "Adult Stage";
string Elder = "Elder Stage";

if (Type == "Frog" || Type == "Duck")
{
    PetCurrentStage = Egg;
}
else if (Type == "Cat")
{
    PetCurrentStage = Baby;
}
UI.Line();
Console.WriteLine($"-Your {Type} is currently in the stage: {PetCurrentStage}!-");
UI.Line();
Console.ReadLine();
Console.Clear();
UI.Line();
Console.WriteLine($"-You enter your home with {PetName}-");
Console.ReadLine();
Console.Clear();
// pet.ExplainPetFood(FoodInventory, Money);
// pet.ExplainPetPlay();

// huvud loop för spelet
string action = "";
while (action != "dead" )
{
pet.info();
pet.option();
pet.WholeStageSection(FoodInventory, PetName, ref Money, ref PetCurrentStage, Teen, ref pet.Happiness, ref pet.Hunger, ref pet.Energy, ref pet.Health, ref pet.Cleanliness, ref pet.Age);
pet.clampstats();
// gör så att när djuret dör så slutar spelet!
if (action == "dead")
    {
        break;
    }
}
Console.ReadLine();

