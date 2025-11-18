Console.WriteLine("Welcome to Stardust pet adoption!");
Console.WriteLine("Please tell me which, between these lovely three pets you would like?");
Console.WriteLine("1. Duck (difficulty easy)");
Console.WriteLine("2. Frog (difficulty medium)");
Console.WriteLine("3. Cat (difficulty hard)");
Console.WriteLine("Enter the number of your choice:");
string pet = Console.ReadLine();
int choicep;
bool isvalidchoice = int.TryParse(pet, out choicep);
int difficulty = 10;
string diff;
Console.Clear();
Console.ReadLine();
if (!isvalidchoice || choicep < 1 || choicep > 3 )
{
   Console.WriteLine("Please choose a valid pet!!"); 
}
 else if ( choicep == 1)
{
    pet = "Duck";
    difficulty = 10;
}
else if ( choicep == 2)
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
if (difficulty == 20)
{
    diff = "medium";
}
if (difficulty == 30)
{
    diff = "hard";
}
else
{
    diff = "unknown";
}
Console.WriteLine("Excellent choice!");
Console.WriteLine($"-you now own a {pet}-");
Console.WriteLine($"- difficulty level:{diff}-");




Console.ReadLine();