public class Pet
{
    // Basic information
    public string PetName; 
    public string Type;
    public string DifficultyString;
    //    Easy, Medium, Hard
    public string PetCurrentStage = "Baby stage";

    // Stats
    public int Happiness = 100;
    public int Hunger = 100;
    public int Energy = 100;
    public int Health = 100;
    public int Cleanliness = 100;
    public int Age = 0;

    public bool Alive
    {
        get { return Health > 0; }
    }

    // Show stats
    // public void ShowStats()
    // {
    //     UI.Stat("Happiness", Happiness);
    //     UI.Stat("Hunger", Hunger);
    //     UI.Stat("Energy", Energy);
    //     UI.Stat("Health", Health);
    //     UI.Stat("Cleanliness", Cleanliness);
    // }
    // Actions
    //     public void 
    // {

    //     }
    // options method


    // dina möjliga val för den action du vill göra med din pet
    public void option()
    {
        Console.WriteLine("Options: Play     Feed      Sleep     Give medicine      Bathe    Shop");
    }
    // stats basically
    public void info()
    {
        Console.Clear();
        Console.WriteLine($"Happiness: {Happiness}   Hunger: {Hunger}   Energy: {Energy}   Health: {Health}   Cleanliness: {Cleanliness}");
        UI.Line();
    }

    // public void ExplainPetFood(List<string> FoodInventory, int Money)
    // {

    // // }
    // is this necessary (i cant remember lol)
    //  public void PetInfo()
    //     {
    //         if (Happiness < 0) Happiness = 0;
    //         if (Hunger < 0) Hunger = 0;
    //         if (Energy < 0) Energy = 0;
    //         if (Cleanliness < 0) Cleanliness = 0;
    //         if (Health > 100) Health = 100;
    //     }
    //     public void ExplainPetPlay()
    // {

    // }

    // stats för att få de sluta gå över 100 eller under 0 
    public void clampstats()
    {
        Happiness = Math.Clamp(Happiness, 0, 100);
        Hunger = Math.Clamp(Hunger, 0, 100);
        Energy = Math.Clamp(Energy, 0, 100);
        Health = Math.Clamp(Health, 0, 100);
        Cleanliness = Math.Clamp(Cleanliness, 0, 100);
    }

    // Hela spelet.. 
    public string WholeStageSection(List<string> FoodInventory, string PetName, ref int Money, ref string PetCurrentStage, string Teen, ref int PetHappiness, ref int PetHunger, ref int PetEnergy, ref int PetHealth, ref int PetCleanliness, ref int PetAging)
    {
        string PetAction = Console.ReadLine().ToLower();
        if (PetAction == "play")
        {
            // ExplainPetPlay();
            Console.Clear();
            Console.WriteLine("---There are 3 different games you can choose to play with your pet---");
            Console.WriteLine("---1. Guess the number ---");
            Console.WriteLine("---Your pet will hide a number between 1-5 (dont ask how), guess right and get happiness points, guess wrong and lose happiness!---");
            Console.WriteLine("---2. Word ---");
            Console.WriteLine("---Type the word given within 2 seconds, fail and your pet loses happiness! ---");
            Console.WriteLine("---3. Feed and guess---");
            Console.WriteLine("---You are given two foods, choose wrong and your pet falls sick, succeed and you fufill both hunger and happiness points---");
            Console.WriteLine("---Please choose a game or type EXIT to exit---");
            string ChoiceGame = Console.ReadLine();
            if (ChoiceGame == "1")
            {
                info();
                Console.Clear();
                UI.Line();
                Console.WriteLine("---Good choice!---");
                Console.WriteLine("---Game begins...---");
                UI.Line();
                int Secret = Random.Shared.Next(1, 6);
                Console.WriteLine($"--- {PetName} hides a number... GUESS IT!---");
                UI.Line();
                string Guess = Console.ReadLine();
                if (Guess == Secret.ToString())
                {
                    Console.Clear();
                    UI.Line();
                    Console.WriteLine("---Good job!---");
                    Console.WriteLine("---Your pet was so happy, they give you 10 coins---");
                    UI.Line();
                    Console.ReadLine();
                    PetHappiness += 20;
                    Money += 10;

                }
                else
                {
                    Console.Clear();
                    UI.Line();
                    Console.WriteLine($"---Oh no! {PetName} was actually thinking of {Secret} ---");
                    UI.Line();
                    Console.ReadLine();
                    PetHappiness -= 5;

                }

            }
            else if (ChoiceGame == "2")
            {
                Console.Clear();
                info();
                UI.Line();
                Console.WriteLine("Type the word 'yay' within 2 seconds!");
                UI.Line();
                string Word = "yay";
                var start = DateTime.Now;
                string Response = Console.ReadLine();
                var end = DateTime.Now;

                if (Response == Word && (end - start).TotalSeconds <= 2)
                {
                    Console.Clear();
                    UI.Line();
                    Console.WriteLine("---Good job!---");
                    Console.WriteLine("---Your pet was so happy, they give you 20 coins---");
                    UI.Line();
                    PetHappiness += 20;
                    Money += 20;

                }
                else
                {
                    Console.Clear();
                    UI.Line();
                    Console.WriteLine("Too slow!");
                    UI.Line();
                    PetHappiness -= 10;

                }
                Console.ReadLine();
            }
            else if (ChoiceGame == "3")
            {
                Console.Clear();
                info();
                UI.Line();
                Console.WriteLine("---Good choice!---");
                Console.WriteLine("---Which secret food do you give your pet?---");
                Console.WriteLine("---1.---");
                UI.Line();
                Console.WriteLine("---2.---");
                UI.Line();
                // idk change 
                string ChoiceGame3 = Console.ReadLine();
                if (ChoiceGame3 == "1")
                {
                    Console.Clear();
                    UI.Line();
                    Console.WriteLine($"---Mmmm {PetName} enjoyed that!---");
                    Console.WriteLine("---Your pet was so happy, they give you 10 coins---");
                    UI.Line();
                    Console.ReadLine();
                    PetHappiness += 20;
                    PetHunger += 10;
                    Money += 10;

                }
                else
                {
                    Console.Clear();
                    UI.Line();
                    Console.WriteLine($"---Oh no! {PetName} feels sick..---");
                    UI.Line();
                    Console.ReadLine();
                    PetHappiness -= 40;
                    PetHealth -= 20;

                }
            }
            PetAging++;
        }

        else if (PetAction == "feed")
        {
            // ExplainPetFood(FoodInventory, Money);
            Console.Clear();
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
            string ChoiceFood = Console.ReadLine();
            if (ChoiceFood == "1")
            {
                Console.Clear();
                UI.Line();
                Console.WriteLine("--- Great choice!---");
                Console.WriteLine($"---{PetName} gobbles it up fast!---");
                UI.Line();
                Console.ReadLine();
                PetHunger += 10;
                PetCleanliness -= 20;
            }
            if (ChoiceFood == "2")
            {
                Console.Clear();
                UI.Line();
                Console.WriteLine("---Excellent!---");
                Console.WriteLine($"---{PetName} eats it happily---");
                UI.Line();
                Console.ReadLine();
                PetHunger += 30;
                PetHappiness += 5;

            }
            if (ChoiceFood == "3")
            {
                Console.Clear();
                UI.Line();
                Console.WriteLine("--- Good decision!---");
                Console.WriteLine($"---{PetName} enjoys their sweet treat!---");
                UI.Line();
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

                    if (Item == "Hunger fufiller")
                    {
                        Console.Clear();
                        UI.Line();
                        Console.WriteLine("--- Great choice!---");
                        Console.WriteLine($"---{PetName} eats the hunger fufiller!---");
                        UI.Line();
                        Console.ReadLine();
                        PetHunger = 100;
                    }
                    else if (Item == "Medicine boost")
                    {
                        Console.Clear();
                        UI.Line();
                        Console.WriteLine("--- Good!---");
                        Console.WriteLine($"---{PetName} drinks the med boost!---");
                        UI.Line();
                        Console.ReadLine();
                        PetHealth = 100;
                    }
                    if (Item == "Super meal")
                    {
                        Console.Clear();
                        UI.Line();
                        Console.WriteLine("--- Great choice!---");
                        Console.WriteLine($"---{PetName} really enjoys the super meal!---");
                        UI.Line();
                        Console.ReadLine();
                        PetHunger = 100;
                        PetHealth = 100;
                        PetEnergy = 100;
                        PetHappiness = 100;
                        PetCleanliness = 100;
                    }

                }
            }
            PetAging++;

        }

        else if (PetAction == "sleep")
        {
            Console.Clear();
            UI.Line();
            Console.WriteLine($"--- You put {PetName} to bed---");
            UI.Line();
            Console.ReadLine();
            PetEnergy += 70;
            PetHappiness += 5;

        }
        else if (PetAction == "give medicine")
        {
            Console.Clear();
            UI.Line();
            Console.WriteLine($"--- You give {PetName} some medicine, they feel immediatley better---");
            UI.Line();
            Console.ReadLine();
            PetHealth += 20;
            PetHappiness += 5;
        }
        if (PetAction == "bathe")
        {
            Console.Clear();
            UI.Line();
            Console.WriteLine($"--- You give {PetName} a bath, this cleans them and makes them happier---");
            UI.Line();
            Console.ReadLine();
            PetCleanliness += 30;
            PetHappiness += 5;

        }

        else if (PetAction == "shop")
        {
            Console.Clear();
            UI.Line();
            Console.WriteLine("---You walk to the store---");
            Console.WriteLine("--Hello! Welcome to berts store!--");
            Console.WriteLine($"---Current amount: {Money}---");
            Console.WriteLine("--What would you like today?--");
            UI.Line();
            Console.ReadLine();
            Console.Clear();
            UI.Line();
            Console.WriteLine($"---Here are your choices!---");
            Console.WriteLine("---1. Hunger fufiller---");
            Console.WriteLine("--- Cost: 20 coins---");
            Console.WriteLine("--- Gives your pet full hunger immediatley---");
            UI.Line();
            Console.WriteLine("---2. Medicine boost---");
            Console.WriteLine("--- Cost: 20 coins---");
            Console.WriteLine("--- Great if your pet is very low on health, boost pet upp to 100 health immediatley---");
            UI.Line();
            Console.WriteLine("---3. Super meal---");
            Console.WriteLine("--- Cost: 50 coins---");
            Console.WriteLine("---Fufills all pets needs---");
            UI.Line();
            Console.WriteLine("---Type EXIT to leave---");

            string ShopChoice = Console.ReadLine();
            if (ShopChoice == "1")
            {
                if (Money >= 20)
                {
                    if (!FoodInventory.Contains("Hunger fufiller"))
                    {
                        Console.Clear();
                        UI.Line();
                        FoodInventory.Add("Hunger fufiller");
                        Console.WriteLine("-- Perfekt!--");
                        Console.WriteLine("---Hunger fufiller has been added to the food menu..---");
                        UI.Line();
                        Console.ReadLine();
                        Money -= 20;
                    }
                    else
                    {
                        Console.Clear();
                        UI.Line();
                        Console.WriteLine("--You already own a Hunger fufiller, it wont be added again!--");
                        UI.Line();
                        Console.ReadLine();
                    }
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
                    if (!FoodInventory.Contains("Medicine boost"))
                    {
                        Console.Clear();
                        UI.Line();
                        FoodInventory.Add("Medicine boost");
                        Console.WriteLine("--Excellent!--");
                        Console.WriteLine("---Medicine boost has been added to the food menu..---");
                        UI.Line();
                        Console.ReadLine();
                        Money -= 20;
                    }
                    else
                    {
                        Console.Clear();
                        UI.Line();
                        Console.WriteLine("--You already own a Medicine boost, it wont be added again!--");
                        UI.Line();
                        Console.ReadLine();
                    }

                }
                else
                {
                    Console.Clear();
                    UI.Line();
                    Console.WriteLine("Not enough money!");
                    UI.Line();
                    Console.ReadLine();
                }

            }
            if (ShopChoice == "3")
            {
                if (Money >= 50)
                {
                    if (!FoodInventory.Contains("Medicine boost"))
                    {
                        Console.Clear();
                        UI.Line();
                        FoodInventory.Add("Super meal");
                        Console.WriteLine("-- Good choice!--");
                        Console.WriteLine("---Super meal has been added to the food menu..---");
                        UI.Line();
                        Console.ReadLine();
                        Money -= 50;
                    }
                    else
                    {
                        Console.Clear();
                        UI.Line();
                        Console.WriteLine("--You already own a Super meal, it wont be added again!--");
                        UI.Line();
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    UI.Line();
                    Console.WriteLine("Not enough money!");
                    UI.Line();
                    Console.ReadLine();
                }

            }
            else
            {
                Console.Clear();
                UI.Line();
                Console.WriteLine("---Not enough money or exit choosen!---");
                UI.Line();
                Console.ReadLine();
            }
            PetAging++;

        }
        if (PetHunger <= 0 || PetHappiness <= 0 || PetEnergy <= 0 || PetCleanliness <= 0)
        {
            Console.Clear();
            PetHealth -= 20;
            UI.Line();
            Console.WriteLine("---WARNING!!!---");
            Console.WriteLine("--- Your pet is dying due to neglect!!---");
            UI.Line();
            Console.ReadLine();

        }
        if (PetHealth > 100) PetHealth = 100;
        if (PetHealth < 0) PetHealth = 0;

        if (PetHealth <= 0)
        {
            Console.Clear();
            UI.Line();
            Console.WriteLine("---Oh no!---");
            Console.WriteLine($"---{PetName} has passed away..---");
            UI.Line();
            Console.ReadLine();
            return "dead";
            // Environment.Exit(0);
        }
        return PetAction;
    }
}