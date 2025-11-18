Console.WriteLine("Welcome to ... pet adoption!");
Console.WriteLine("Please tell me which, between these lovely three pets you would like?");
Console.WriteLine("1. Duck (difficulty easy)");
Console.WriteLine("2. Frog (difficulty medium)");
Console.WriteLine("3. Cat (difficulty hard)");
string pet = Console.ReadLine();
int choicep;
int.TryParse(pet, out choicep);
int difficulty = 10;
Console.Clear();
Console.ReadLine();
if (choicep == 1)
{
    pet = "Duck";
}
else if (choicep == 2)
{
    pet = "Frog";
    difficulty += 10;
}
else if (choicep == 3)
{
    pet = "Cat";
     difficulty += 20;
}
Console.WriteLine("Excellent choice!");
Console.WriteLine($"-you now own a {pet}-");
Console.WriteLine($"-{difficulty}-");




Console.ReadLine();