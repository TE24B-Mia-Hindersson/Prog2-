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
int choicep;
string input;
// bool isvalidchoice = int.TryParse(pet, out choicep);
Console.ReadLine();
Console.Clear();
while (true)
{
    input = Console.ReadLine();
    if (int.TryParse(input, out choicep) && choicep <= 1 && choicep >= 3)
        break;

    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("         Please choose a valid pet!!");
    Console.WriteLine("------------------------------------------------");
    Console.ReadLine();
}
string pet = Console.ReadLine();
int difficulty = 10;
string diff;
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
Console.WriteLine($"         --difficulty level:{diff}--");
Console.WriteLine("-------------------------------------------");
Console.ReadLine();
Console.Clear();

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Would you like to choose a name, or be given a prechosen name?");
Console.WriteLine("----------------------------------------------------------------");
string name = Console.ReadLine();


Console.ReadLine();