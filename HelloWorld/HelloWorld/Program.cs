using System.Globalization;

bool isValidResponce = true;
string userResponce = "";
int str = 10;
double multipler = str * .3;
int longswordMultipler = Convert.ToInt32(multipler);
int longSwordBaseDamage = 30 + longswordMultipler * 30;

Console.WriteLine("Choose a starting weapon:");
Console.WriteLine("1: Longsword");
Console.WriteLine();
Console.Write("Selection: ");

while (isValidResponce)
{ 
    userResponce = Console.ReadLine();
   
    if(userResponce == "1")
    {

        Console.Clear();
        Console.WriteLine("Longsword base stats");
        Console.WriteLine("Base dmamage: 30 + 30");
        Console.WriteLine("Total Damage: 60");
        Console.WriteLine();
        Console.WriteLine($"Actual damage based on stats: {longSwordBaseDamage}");
        Console.WriteLine();
        Console.Write("(press enter to continue)");
        userResponce = Console.ReadLine();
        
        if(userResponce == "")
        {
            isValidResponce = false;
        }
        else
        {
            Console.WriteLine();
            Console.Write("(press enter to continue)");
            Console.ReadLine();
        }
    }
}
Console.Clear();