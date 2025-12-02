using System.Formats.Asn1;
// Add the difficulty things as mentioned
// Add the death stage!
// Maybe make differences for different stages?
Console.WriteLine("==Welcome to Bosse pet adoption!==");
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
int PetChoice = 0;
string PetChoiceInput;
string Pet = "";
int DifficultyInt = 10;
string DifficultyString;

Pet myPet = new();
List<string> FoodInventory = new List<string>();
while (PetChoice <= 0)
{
    PetChoiceInput = Console.ReadLine();
    bool Success = int.TryParse(PetChoiceInput, out PetChoice);
    if (!Success | PetChoice < 1 || PetChoice > 3)
    {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("         Please choose a valid pet!!");
        Console.WriteLine("------------------------------------------------");
        PetChoice = 0;
        Console.ReadLine();
        Console.Clear();
    }
    else
    {
        break;
    }
}
if (PetChoice == 1)
{
    Pet = "Duck";
    DifficultyInt = 10;
}
else if (PetChoice == 2)
{
    Pet = "Frog";
    DifficultyInt = 20;
}
else if (PetChoice == 3)
{
    Pet = "Cat";
    DifficultyInt = 30;
}
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
Console.WriteLine("------------------------------------------");
Console.WriteLine("           Excellent choice!");
Console.WriteLine($"        --you now own a {Pet}--");
Console.WriteLine($"       --difficulty level:{DifficultyString}--");
Console.WriteLine("-------------------------------------------");
Console.ReadLine();
Console.Clear();

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Would you like to choose a name, or be given a prechosen name?");
Console.WriteLine("             For prechosen name type 'random'");
Console.WriteLine("             For own chosen name type 'yes'");
Console.WriteLine("----------------------------------------------------------------");
string PetNameInput = Console.ReadLine();
while (PetNameInput != "yes" && PetNameInput != "random")
{
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Please type either 'yes' or 'random':");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    PetNameInput = Console.ReadLine().ToLower();
}
string[] RandomNames = { "Mia", "Bosse", "Leon", "Bert" };
string PetName = "";
if (PetNameInput == "yes")
{
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"Great! Now let me know what youd like to name your {Pet}:");
    myPet.Name = Console.ReadLine();
    Console.WriteLine($"Aww what a wonderful name!");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
}
else if (PetNameInput == "random")
{
    PetName = RandomNames[Random.Shared.Next(RandomNames.Length)];
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"Prechosen name chosen: {PetName}");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
}
while (string.IsNullOrWhiteSpace(PetName) || PetName.Length < 2 || PetName.Length > 12)
{
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Name must be between 2 and 12 characters. Try again:");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    PetName = Console.ReadLine();
}
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"Your new pets name is now: {PetName}");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();
Console.Clear();
int Money = 100;
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("I will now give you a small amount of coins to begin taking care of your new pet!");
Console.WriteLine($"                  -Coins added to wallet: {Money}-");
Console.WriteLine("Also! Before you go, please take this manual that explains your pet.. Good luck!! ");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();
Console.Clear();
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"-You walk home with your new pet {PetName}!-");
Console.WriteLine($"-{PetName} is only little at the moment so you will have to care for them until they grow-");
Console.WriteLine($"--You take out the manual given to you at the adoption agency--");
Console.WriteLine($"--The {Pet} will go through different stages of life.--");
Console.WriteLine("These are as follows:");
if (Pet == "Frog" || Pet == "Duck")
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
int Age = 0;
string PetCurrentStage = "";
string Egg = "Egg Stage";
string Baby = "Baby Stage";
string Teen = "Teen Stage";
string Adult = "Adult Stage";
string Elder = "Elder Stage";
if (Pet == "Frog" || Pet == "Duck")
{
    PetCurrentStage = Egg;
}
else if (Pet == "Cat")
{
    PetCurrentStage = Baby;
}
if (PetCurrentStage == Egg)
{
    Age++;
}
if (PetCurrentStage == Baby)
{
    Age++;
}
if (PetCurrentStage == Teen)
{
    Age++;
}
if (PetCurrentStage == Adult)
{
    Age++;
}
if (PetCurrentStage == Elder)
{
    Age++;
}
// temporary fix (problem for future me)

Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"-Your {Pet} is currently in the stage: {PetCurrentStage}!-");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();
Console.Clear();
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"-You enter your home with {PetName}-");
if (PetCurrentStage == Egg)
{
    Console.WriteLine("-You remember what was said in the manual-");
    Console.WriteLine("-To hatch the egg you must TAP it, but to keep the pet inside happy you can comfort it.-");
    Console.WriteLine("---write tap to continue!!---");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    string TapInput = Console.ReadLine();
    Console.Clear();
    if (TapInput == "tap")
    {
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                               -You feel the egg move-");
        Console.WriteLine("                          -You hear a subtle coo from inside-");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();

    }
    else
    {
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---Please tap the egg or use the command comfort to keep them happy!---");
        Console.WriteLine("                ---write tap or comfort to continue!!---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
    }
}
int PetHappiness = 100;
int PetHunger = 100;
int PetEnergy = 100;
int PetHealth = 100;
int PetCleanliness = 100;
static void info(int PetHappiness, int PetHunger, int PetEnergy, int PetHealth, int PetCleanliness)
{
    Console.WriteLine($"Happiness: {PetHappiness}   Hunger: {PetHunger}   Energy: {PetEnergy}   Health: {PetHealth}   Cleanliness: {PetCleanliness}");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
}
int TapAmount = 0;
if (PetHappiness > 100) PetHappiness = 100;
if (PetHappiness < 0) PetHappiness = 0;
if (PetEnergy > 100) PetEnergy = 100;
if (PetEnergy < 0) PetEnergy = 0;
if (PetHealth > 100) PetHealth = 100;
if (PetHealth < 0) PetHealth = 0;
if (PetCleanliness > 100) PetCleanliness = 100;
if (PetCleanliness < 0) PetCleanliness = 0;
if (PetHunger > 100) PetHunger = 100;
if (PetHunger < 0) PetHunger = 0;
while (PetCurrentStage == Egg)
{
    Console.Clear();
    info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
    Console.WriteLine("--Type 'tap' to tap the egg, or type 'comfort' to soothe the egg:");
    string Action = Console.ReadLine();
    if (Action == "tap")
    {
        Console.Clear();
        TapAmount++;
        PetHappiness -= 20;
        info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---You tapped the egg!---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
    }
    else if (Action == "comfort")
    {
        Console.Clear();
        PetHappiness += 10;
        info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---You comforted the egg!---");
        Console.WriteLine("---The pet inside seems happier---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
    }
    else
    {
        Console.Clear();
        info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---Oh no! The pet doesnt react, maybe try again!---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
    }

    if (TapAmount >= 5)
    {
        Console.Clear();
        PetCurrentStage = Baby;
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---the egg hatches!---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
    }
}
string PetAction = "";
static void option(int Play, int Feed, int Sleep, int Medicine, int Bathe, int Shop)
{
    Console.WriteLine("Options: Play     Feed      Sleep     Give medicine      Bathe    Shop");
}
if (Pet == "Frog" || Pet == "Duck" && PetCurrentStage == Baby)
{
    Console.Clear();
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("---Your pet has grown into a baby---");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.ReadLine();
    Console.Clear();
}
int Play, Feed, Sleep, Medicine, Bathe, Shop, PetAging;
PetInfo(ref PetHappiness, ref PetHunger, ref PetEnergy, ref PetHealth, out Play, out Feed, out Sleep, out Medicine, out Bathe, out Shop, out PetAging);
while (PetCurrentStage == Baby)
{
    Console.Clear();
    info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
    PetHappiness -= 10;
    PetHunger -= 10;
    PetEnergy -= 15;

    option(Play, Feed, Sleep, Medicine, Bathe, Shop);
    PetAction = WholeStageSection(FoodInventory, PetName, ref Money, ref PetCurrentStage, Teen, ref PetHappiness, ref PetHunger, ref PetEnergy, ref PetHealth, ref PetCleanliness, ref PetAging);
    if (PetAging >= 20)
    {
        PetCurrentStage = Teen;
    }
}
while (PetCurrentStage == Teen)
{
    Console.Clear();
    PetInfo(ref PetHappiness, ref PetHunger, ref PetEnergy, ref PetHealth, out Play, out Feed, out Sleep, out Medicine, out Bathe, out Shop, out PetAging);
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"---{PetName} has evolved into a Teen!---");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.ReadLine();
    Console.Clear();
    info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
    option(Play, Feed, Sleep, Medicine, Bathe, Shop);
    PetHappiness -= 15;
    PetHunger -= 15;
    PetEnergy -= 20;
    PetAction = WholeStageSection(FoodInventory, PetName, ref Money, ref PetCurrentStage, Teen, ref PetHappiness, ref PetHunger, ref PetEnergy, ref PetHealth, ref PetCleanliness, ref PetAging);
    if (PetAging >= 40)
    {
        PetCurrentStage = Adult;
    }
}
while (PetCurrentStage == Adult)
{
    Console.Clear();
    PetInfo(ref PetHappiness, ref PetHunger, ref PetEnergy, ref PetHealth, out Play, out Feed, out Sleep, out Medicine, out Bathe, out Shop, out PetAging);
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"---{PetName} has evolved into an Adult!---");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.ReadLine();
    Console.Clear();
    info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
    option(Play, Feed, Sleep, Medicine, Bathe, Shop);
    PetHappiness -= 15;
    PetHunger -= 20;
    PetEnergy -= 30;
    PetAction = WholeStageSection(FoodInventory, PetName, ref Money, ref PetCurrentStage, Teen, ref PetHappiness, ref PetHunger, ref PetEnergy, ref PetHealth, ref PetCleanliness, ref PetAging);
    if (PetAging >= 70)
    {
        PetCurrentStage = Elder;
    }
}
while (PetCurrentStage == Elder)
{
    Console.Clear();
    PetInfo(ref PetHappiness, ref PetHunger, ref PetEnergy, ref PetHealth, out Play, out Feed, out Sleep, out Medicine, out Bathe, out Shop, out PetAging);
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine($"---{PetName} has evolved into a Elder!---");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    Console.ReadLine();
    Console.Clear();
    info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
    option(Play, Feed, Sleep, Medicine, Bathe, Shop);
    PetHappiness -= 30;
    PetHunger -= 30;
    PetEnergy -= 40;
    PetAction = WholeStageSection(FoodInventory, PetName, ref Money, ref PetCurrentStage, Teen, ref PetHappiness, ref PetHunger, ref PetEnergy, ref PetHealth, ref PetCleanliness, ref PetAging);
    if (PetAging >= 100)
    {
        // death!!
    }
}


Console.ReadLine();

static void ExplainPetFood(List<string> FoodInventory, int Money)
{
    Console.WriteLine("---There are 3 different foods to feed your pet---");
    Console.WriteLine("---You can even buy food in the store for coins, these foods have special affects---");
    Console.WriteLine($"---Current amount: {Money}---");
    Console.WriteLine($"---Money is only displayed within the store and when choosing food..---");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"---Here are your choices!---");
    Console.WriteLine("---(store items only displayed after purchase)---");
    Console.WriteLine("---1. Simple snack---");
    Console.WriteLine("--- Doesnt fufill a lot of hunger, good for baby stage. Leads to pet getting dirty faster!---");
    Console.WriteLine("---2. Hearty meal---");
    Console.WriteLine("--- Great if your pet is very low on hunger, fufills a small bit of happiness---");
    Console.WriteLine("---3. Sweet treat---");
    Console.WriteLine("---Bad for you and doesnt fufill a lot of hunger, in substitute it gives you a lot of happiness---");
    int ShopInvNmr = 4;
    foreach (string Item in FoodInventory)
    {
        Console.WriteLine($"---{ShopInvNmr}. {Item}---");
        ShopInvNmr++;
    }
    Console.WriteLine("---Type EXIT to leave---");
}

static void PetInfo(ref int PetHappiness, ref int PetHunger, ref int PetEnergy, ref int PetHealth, out int Play, out int Feed, out int Sleep, out int Medicine, out int Bathe, out int Shop, out int PetAging)
{
    if (PetHappiness < 0) PetHappiness = 0;
    if (PetHunger < 0) PetHunger = 0;
    if (PetEnergy < 0) PetEnergy = 0;
    if (PetHealth < 0) PetHealth = 0;
    if (PetHappiness > 100) PetHappiness = 100;
    if (PetHunger > 100) PetHunger = 100;
    if (PetEnergy > 100) PetEnergy = 100;
    if (PetHealth > 100) PetHealth = 100;
    Play = 0;
    Feed = 0;
    Sleep = 0;
    Medicine = 0;
    Bathe = 0;
    Shop = 0;
    PetAging = 0;
}

static void ExplainPetPlay()
{
    Console.Clear();
    Console.WriteLine("---There are 3 different games you can choose to play with your pet---");
    Console.WriteLine("---1. Guess the number ---");
    Console.WriteLine("---Your pet will hide a number between 1-5 (dont ask how), guess right and get happiness points, guess wrong and lose happiness!---");
    Console.WriteLine("---2. Word ---");
    Console.WriteLine("---Type the word given within 2 seconds, fail and your pet loses happiness! ---");
    Console.WriteLine("---3. Feed and guess---");
    Console.WriteLine("---You are given two foods, choose wrong and your pet falls sick, succeed and you fufill both hunger and happiness points---");
    Console.WriteLine("---Please choose a game or type EXIT to exit---");
}

static string WholeStageSection(List<string> FoodInventory, string PetName, ref int Money, ref string PetCurrentStage, string Teen, ref int PetHappiness, ref int PetHunger, ref int PetEnergy, ref int PetHealth, ref int PetCleanliness, ref int PetAging)
{
    string PetAction = Console.ReadLine().ToLower();
    if (PetAction == "play")
    {
        ExplainPetPlay();
        string ChoiceGame = Console.ReadLine();
        if (ChoiceGame == "1")
        {
            info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---Good choice!---");
            Console.WriteLine("---Game begins...---");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            int Secret = Random.Shared.Next(1, 6);
            Console.WriteLine($"--- {PetName} hides a number... GUESS IT!---");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            string Guess = Console.ReadLine();
            if (Guess == Secret.ToString())
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("---Good job!---");
                Console.WriteLine("---Your pet was so happy, they give you 10 coins---");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
                PetHappiness += 20;
                Money += 10;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"---Oh no! {PetName} was actually thinking of {Secret} ---");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
                PetHappiness -= 5;

            }

        }
        else if (ChoiceGame == "2")
        {
            Console.Clear();
            info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Type the word 'yay' within 2 seconds!");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            string Word = "yay";
            var start = DateTime.Now;
            string Response = Console.ReadLine();
            var end = DateTime.Now;

            if (Response == Word && (end - start).TotalSeconds <= 2)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("---Good job!---");
                Console.WriteLine("---Your pet was so happy, they give you 20 coins---");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                PetHappiness += 20;
                Money += 20;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Too slow!");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                PetHappiness -= 10;

            }
            Console.ReadLine();
        }
        else if (ChoiceGame == "3")
        {
            Console.Clear();
            info(PetHappiness, PetHunger, PetEnergy, PetHealth, PetCleanliness);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---Good choice!---");
            Console.WriteLine("---Which secret food do you give your pet?---");
            Console.WriteLine("---1.---");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---2.---");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            // idk change 
            string ChoiceGame3 = Console.ReadLine();
            if (ChoiceGame3 == "1")
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"---Mmmm {PetName} enjoyed that!---");
                Console.WriteLine("---Your pet was so happy, they give you 10 coins---");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
                PetHappiness += 20;
                PetHunger += 10;
                Money += 10;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"---Oh no! {PetName} feels sick..---");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
                PetHappiness -= 40;
                PetHealth -= 20;

            }
        }
        PetAging++;
    }

    else if (PetAction == "feed")
    {
        ExplainPetFood(FoodInventory, Money);
        string ChoiceFood = Console.ReadLine();
        if (ChoiceFood == "1")
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--- Great choice!---");
            Console.WriteLine($"---{PetName} gobbles it up fast!---");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
            PetHunger += 10;
            PetCleanliness -= 20;
        }
        if (ChoiceFood == "2")
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---Excellent!---");
            Console.WriteLine($"---{PetName} eats it happily---");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
            PetHunger += 30;
            PetHappiness += 5;

        }
        if (ChoiceFood == "3")
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--- Good decision!---");
            Console.WriteLine($"---{PetName} enjoys their sweet treat!---");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
            PetHunger += 10;
            PetHappiness += 30;
            PetHealth -= 10;

        }
        int ShopNumSlot;
        if (int.TryParse(ChoiceFood, out ShopNumSlot))
        {
            int Index = ShopNumSlot - 4;

            if (Index >= 0 && Index < FoodInventory.Count)
            {
                string Item = FoodInventory[Index];

                if (Item == "Hunger Fufiller")
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("--- Great choice!---");
                    Console.WriteLine($"---{PetName} eats the hunger fufiller!---");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadLine();
                    PetHunger = 100;
                }
                else if (Item == "Medicine boost")
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("--- Good!---");
                    Console.WriteLine($"---{PetName} drinks the med boost!---");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadLine();
                    PetHealth = 100;
                }
                if (Item == "Super meal")
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("--- Great choice!---");
                    Console.WriteLine($"---{PetName} really enjoys the super meal!---");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadLine();
                    PetHunger = 100;
                    PetHealth = 100;
                    PetEnergy = 100;
                    PetHappiness = 100;
                    PetCleanliness = 100;
                }

            }
        }


    }

    else if (PetAction == "sleep")
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"--- You put {PetName} to bed---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
        PetEnergy += 30;
        PetHappiness += 5;

    }
    else if (PetAction == "give medicine")
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"--- You give {PetName} some medicine, they feel immediatley better---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
        PetHealth += 20;
        PetHappiness += 5;
    }
    if (PetAction == "bathe")
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"--- You give {PetName} a bath, this cleans them and makes them happier---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
        PetCleanliness += 30;
        PetHappiness += 5;

    }

    else if (PetAction == "shop")
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---You walk to the store---");
        Console.WriteLine("--Hello! Welcome to berts store!--");
        Console.WriteLine($"---Current amount: {Money}---");
        Console.WriteLine("--What would you like today?--");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"---Here are your choices!---");
        Console.WriteLine("---1. Hunger fufiller---");
        Console.WriteLine("--- Cost: 20 coins---");
        Console.WriteLine("--- Gives your pet full hunger immediatley---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---2. Medicine boost---");
        Console.WriteLine("--- Cost: 20 coins---");
        Console.WriteLine("--- Great if your pet is very low on health, boost pet upp to 100 health immediatley---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---3. Super meal---");
        Console.WriteLine("--- Cost: 50 coins---");
        Console.WriteLine("---Fufills all pets needs---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---Type EXIT to leave---");

        string ShopChoice = Console.ReadLine();
        if (ShopChoice == "1")
        {
            if (Money >= 20)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                FoodInventory.Add("Hunger fufiller");
                Console.WriteLine("-- Perfekt!--");
                Console.WriteLine("---Hunger fufiller has been added to the food menu..---");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
                Money -= 20;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Not enough money!");
                Console.ReadLine();
            }

        }
        if (ShopChoice == "2")
        {
            if (Money >= 20)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                FoodInventory.Add("Medicine boost");
                Console.WriteLine("--Excellent!--");
                Console.WriteLine("---Medicine boost has been added to the food menu..---");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Not enough money!");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
            }

        }
        if (ShopChoice == "3")
        {
            if (Money >= 50)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                FoodInventory.Add("Super meal");
                Console.WriteLine("-- Good choice!--");
                Console.WriteLine("---Super meal has been added to the food menu..---");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Not enough money!");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                Console.ReadLine();
            }

        }
        else
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---Not enough money or exit choosen!---");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }

    }
    if (PetHunger <= 0 || PetHappiness <= 0 || PetEnergy <= 0 || PetCleanliness <= 0)
    {
        Console.Clear();
        PetHealth -= 20;
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---WARNING!!!---");
        Console.WriteLine("--- Your pet is dying due to neglect!!---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();

    }
    if (PetHealth > 100) PetHealth = 100;
    if (PetHealth < 0) PetHealth = 0;

    if (PetHealth <= 0)
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("---Oh no!---");
        Console.WriteLine($"---{PetName} has passed away..---");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        Console.ReadLine();
        Environment.Exit(0);
    }
    return PetAction;
}