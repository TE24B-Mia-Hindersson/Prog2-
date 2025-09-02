//bool isAlive = true;
//isAlive = 6 != 10;


using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

//string name = Console.ReadLine();

//if (name == "mia")
//{
// Console.WriteLine("welcome!");
//}
//if (name != "mia")
//else if (name == "leon")
//{
// Console.WriteLine("hejjj :D");
//}
//else
//{
// Console.WriteLine("stick här ifrån");
//}

//Console.ReadLine();



Console.WriteLine("You are walking home from work one autumn evening.You want to continue walking a bit to take in the fresh air.");
Console.WriteLine("The path breaks off into two, which do you follow? Left or Right?");
string pathone = Console.ReadLine();
Console.ReadLine();
if (pathone.ToLower() == "left")
{
    Console.WriteLine("You choose to take the long way home, the left path. The wind starts picking up and you regret your choice.");
    Console.WriteLine("You contemplate for awhile. Should you take shelter (write shelter) or continue home (write house)?");
    Console.ReadLine();
}
else if (pathone.ToLower() == "right")
{
    Console.WriteLine("You choose the short way home. The walk is wonderful up untill the wind drastically picks up.");
    Console.WriteLine("You are sad because you wouldve liked to walk a bit longer but the wind is just too strong to continue. Do you run home (write home) or do you keep walking onwards past your house (write continue)?");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Follow instructions...");
}
string pathtwo = Console.ReadLine();
if (pathtwo.ToLower() == "house")
{
    Console.WriteLine("You continue to your home, the wind almost blowing you off your feet.");
    Console.WriteLine("Suddenly a large burst of wind knocks you off your feet and you die from the impact");
    Console.WriteLine("game over");
}
else if (pathtwo.ToLower() == "shelter")
{
    Console.WriteLine("You run to take shelter and just as you do the wind picks up so drastically that trees almost blow over.");
    Console.WriteLine("You wait in the shelter untill the wind passes and safely get home");
    Console.WriteLine("game over");
}
else
{
    Console.WriteLine("Follow instructions...");
}
string paththree = Console.ReadLine();
if (paththree.ToLower() == "home")
{
    Console.WriteLine("You run home having to dodge debris left and right. ");
}
else if (paththree.ToLower() == "continue")
{
    Console.WriteLine("");
}
else
{
    Console.WriteLine("Follow instructions...");
}

Console.ReadLine();