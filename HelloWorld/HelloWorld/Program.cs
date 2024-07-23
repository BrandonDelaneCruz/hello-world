
using HelloWorld;



Console.Beep();
Console.WriteLine("Select one:");
Console.Beep();
Console.WriteLine();
Console.Beep();
Console.WriteLine("1: Movie reference");
Console.Beep();
Console.WriteLine("2: Tea");
string userResponse = Console.ReadLine();
Console.Clear();


Console.WriteLine();
string userType = FunctionTest.AddValues(userResponse);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(userType);
Console.ReadLine();

//int firstNumber = int.Parse(Console.ReadLine());
//int secondNumber = int.Parse(Console.ReadLine());

//int sum = FunctionTest.SumNumbers(firstNumber, secondNumber);

//Console.WriteLine($"The sum is {sum}");