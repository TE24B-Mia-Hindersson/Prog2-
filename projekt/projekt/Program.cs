using System.Formats.Asn1;

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
int choicep = 0;
string input;
string pet = "";
int difficulty = 10;
string diff;

Pet myPet = new();
List<string> foodinv = new List<string>();
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
    myPet.Name = Console.ReadLine();
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
int age = 0;
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
if (currentstage == egg)
{
    age++;
}
if (currentstage == baby)
{
    age++;
}
if (currentstage == teen)
{
    age++;
}
if (currentstage == adult)
{
    age++;
}
if (currentstage == elder)
{
    age++;
}
// temporary fix (problem for future me)

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
    Console.WriteLine("-To hatch the egg you must TAP it, but to keep the pet inside happy you can comfort it.-");
    Console.WriteLine("---write tap to continue!!---");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    string input2 = Console.ReadLine();
    Console.Clear();
    if (input2 == "tap")
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
int tap = 0;
while (currentstage == egg)
{
    Console.Clear();
    info(happiness, hunger, energy, health, cleanness);
    Console.WriteLine("--Type 'tap' to tap the egg, or type 'comfort' to soothe the egg:");
    string action = Console.ReadLine();
    if (action == "tap")
    {
        Console.Clear();
        tap++;
        happiness -= 20;
        info(happiness, hunger, energy, health, cleanness);
        Console.WriteLine("---You tapped the egg!---");
        Console.ReadLine();
    }
    else if (action == "comfort")
    {
        Console.Clear();
        happiness += 10;
        info(happiness, hunger, energy, health, cleanness);
        Console.WriteLine("---You comforted the egg!---");
        Console.WriteLine("---The pet inside seems happier---");
        Console.ReadLine();
    }
    else
    {
        Console.Clear();
        info(happiness, hunger, energy, health, cleanness);
        Console.WriteLine("---Oh no! The pet doesnt react, maybe try again!---");
        Console.ReadLine();
    }
    if (happiness > 100) happiness = 100;
    if (happiness < 0) happiness = 0;

    if (tap >= 5)
    {
        Console.Clear();
        currentstage = baby;
        Console.WriteLine("---the egg hatches!---");
        Console.ReadLine();
    }
}
string petAction = "";
static void option(int play, int feed, int sleep, int medicine, int bathe, int shop)
{
    Console.WriteLine("Options: Play     Feed      Sleep     Give medicine      Bathe    Shop");
}
if (pet == "Frog" || pet == "Duck" && currentstage == baby)
{
    Console.Clear();
    Console.WriteLine("---Your pet has grown into a baby---");
    Console.ReadLine();
    Console.Clear();
}
while (currentstage == baby)
{
    Console.Clear();
    info(happiness, hunger, energy, health, cleanness);
    happiness -= 10;
    hunger -= 10;
    energy -= 15;
    if (happiness < 0) happiness = 0;
    if (hunger < 0) hunger = 0;
    if (energy < 0) energy = 0;
    if (health < 0) health = 0;
    if (happiness > 100) happiness = 100;
    if (hunger > 100) hunger = 100;
    if (energy > 100) energy = 100;
    if (health > 100) health = 100;
    int play = 0;
    int feed = 0;
    int sleep = 0;
    int medicine = 0;
    int bathe = 0;
    int shop = 0;
    option(play, feed, sleep, medicine, bathe, shop);
    petAction = Console.ReadLine().ToLower();
    if (petAction == "play")
    {
        // PlayWith(myPet);

        ExplainPetPlay();
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            info(happiness, hunger, energy, health, cleanness);
            Console.Clear();
            Console.WriteLine("---Good choice!---");
            Console.WriteLine("---Game begins...---");
            int secret = Random.Shared.Next(1, 6);
            Console.WriteLine($"--- {name} hides a number... GUESS IT!---");
            string guess = Console.ReadLine();
            if (guess == secret.ToString())
            {
                Console.WriteLine("---Good job!---");
                Console.WriteLine("---Your pet was so happy, they give you 10 coins---");
                Console.ReadLine();
                happiness += 20;
                money += 10;

            }
            else
            {
                Console.WriteLine($"---Oh no! {name} was actually thinking of {secret} ---");
                Console.ReadLine();
                happiness -= 5;

            }

        }
        else if (choice == "2")
        {
            Console.Clear();
            info(happiness, hunger, energy, health, cleanness);
            Console.WriteLine("Type the word 'yay' within 2 seconds!");

            string word = "yay";
            var start = DateTime.Now;
            string resp = Console.ReadLine();
            var end = DateTime.Now;

            if (resp == word && (end - start).TotalSeconds <= 2)
            {
                Console.WriteLine("---Good job!---");
                Console.WriteLine("---Your pet was so happy, they give you 20 coins---");
                happiness += 20;
                money += 20;

            }
            else
            {
                Console.WriteLine("Too slow!");
                happiness -= 10;

            }
            Console.ReadLine();
        }
        else if (choice == "3")
        {
            Console.Clear();
            info(happiness, hunger, energy, health, cleanness);
            Console.WriteLine("---Good choice!---");
            Console.WriteLine("---Which food do you give your pet?---");
            Console.WriteLine("---1. Cookie---");
            Console.WriteLine("---2. shit ---");
            // idk change 
            string choiceg3 = Console.ReadLine();
            if (choiceg3 == "1")
            {
                Console.WriteLine($"---Mmmm {name} enjoyed that!---");
                Console.WriteLine("---Your pet was so happy, they give you 10 coins---");
                Console.ReadLine();
                happiness += 20;
                hunger += 10;
                money += 10;

            }
            else
            {
                Console.WriteLine($"---Oh no! {name} feels sick..---");
                Console.ReadLine();
                happiness -= 40;
                health -= 20;

            }
        }
    }

    else if (petAction == "feed")
    {
        ExplainPetFeed(money);
        int shopnmr = 4;
        foreach (string thing in foodinv)
        {
            Console.WriteLine($"---{shopnmr}. {thing}---");
            shopnmr++;
        }
        Console.WriteLine("---Type EXIT to leave---");
        string choicef = Console.ReadLine();
        if (choicef == "1")
        {
            Console.WriteLine("--- Great choice!---");
            Console.WriteLine($"---{name} gobbles it up fast!---");
            Console.ReadLine();
            hunger += 10;
            cleanness -= 20;
        }
        if (choicef == "2")
        {
            Console.WriteLine("---Excellent!---");
            Console.WriteLine($"---{name} eats it happily---");
            Console.ReadLine();
            hunger += 30;
            happiness += 5;

        }
        if (choicef == "3")
        {
            Console.WriteLine("--- Good decision!---");
            Console.WriteLine($"---{name} enjoys their sweet treat!---");
            Console.ReadLine();
            hunger += 10;
            happiness += 30;
            health -= 10;

        }
        int num;
        if (int.TryParse(choicef, out num))
        {
            int index = num - 4;

            if (index >= 0 && index < foodinv.Count)
            {
                string thing = foodinv[index];

                if (thing == "Hunger Fufiller")
                {
                    Console.WriteLine("--- Great choice!---");
                    Console.WriteLine($"---{name} eats the hunger fufiller!---");
                    Console.ReadLine();
                    hunger = 100;
                }
                else if (thing == "Medicine boost")
                {
                    Console.WriteLine("--- Good!---");
                    Console.WriteLine($"---{name} drinks the med boost!---");
                    Console.ReadLine();
                    health = 100;
                }
                if (thing == "Super meal")
                {
                    Console.WriteLine("--- Great choice!---");
                    Console.WriteLine($"---{name} really enjoys the super meal!---");
                    Console.ReadLine();
                    hunger = 100;
                    health = 100;
                    energy = 100;
                    happiness = 100;
                    cleanness = 100;
                }

            }
        }


    }

    else if (petAction == "sleep")
    {
        Console.WriteLine($"--- You put {name} to bed---");
        Console.ReadLine();
        energy += 30;
        happiness += 5;

    }
    else if (petAction == "give medcicine")
    {
        Console.WriteLine($"--- You give {name} some medicine, they feel immediatley better---");
        Console.ReadLine();
        health += 20;
        happiness += 5;
    }
    if (petAction == "bathe")
    {
        Console.WriteLine($"--- You give {name} a bath, this cleans them and makes them happier---");
        Console.ReadLine();
        cleanness += 30;
        happiness += 5;

    }

    else if (petAction == "shop")
    {
        Console.WriteLine("---You walk to the store---");
        Console.WriteLine("--Hello! Welcome to berts store!--");
        Console.WriteLine($"---Current amount: {money}---");
        Console.WriteLine("--What would you like today?--");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"---Here are your choices!---");
        Console.WriteLine("---1. Hunger fufiller---");
        Console.WriteLine("--- Cost: 20 coins---");
        Console.WriteLine("--- Gives your pet full hunger immediatley---");
        Console.WriteLine("---2. Medicine boost---");
        Console.WriteLine("--- Cost: 20 coins---");
        Console.WriteLine("--- Great if your pet is very low on health, boost pet upp to 100 health immediatley---");
        Console.WriteLine("---3. Super meal---");
        Console.WriteLine("--- Cost: 50 coins---");
        Console.WriteLine("---Fufills all pets needs---");
        Console.WriteLine("---Type EXIT to leave---");

        string choicesh = Console.ReadLine();
        if (choicesh == "1")
        {
            if (money >= 20)
            {
                foodinv.Add("Hunger fufiller");
                Console.WriteLine("-- Perfekt!--");
                Console.WriteLine("---Hunger fufiller has been added to the food menu..---");
                Console.ReadLine();
                money -= 20;
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.ReadLine();
            }

        }
        if (choicesh == "2")
        {
            if (money >= 20)
            {
                foodinv.Add("Medicine boost");
                Console.WriteLine("--Excellent!--");
                Console.WriteLine("---Medicine boost has been added to the food menu..---");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.ReadLine();
            }

        }
        if (choicesh == "3")
        {
            if (money >= 50)
            {
                foodinv.Add("Super meal");
                Console.WriteLine("-- Good choice!--");
                Console.WriteLine("---Super meal has been added to the food menu..---");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.ReadLine();
            }

        }
        else
        {
            Console.WriteLine("---Not enough money or exit choosen!---");
            Console.ReadLine();
        }

    }
    if (hunger <= 0 || happiness <= 0 || energy <= 0 || cleanness <= 0)
    {
        health -= 20;
        Console.WriteLine("---WARNING!!!---");
        Console.WriteLine("--- Your pet is dying due to neglect!!---");
        Console.ReadLine();
    }
    if (health > 100) health = 100;
    if (health < 0) health = 0;

    if (health <= 0)
    {
        Console.WriteLine("---Oh no!---");
        Console.WriteLine($"---{name} has passed away..---");
        Console.ReadLine();
        Environment.Exit(0);
    }
}



Console.ReadLine();

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

static void ExplainPetFeed(int money)
{
    Console.WriteLine("---There are 3 different foods to feed your pet---");
    Console.WriteLine("---You can even buy food in the store for coins, these foods have special affects---");
    Console.WriteLine($"---Current amount: {money}---");
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
}