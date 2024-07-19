Console.WriteLine("Press to start.");

var userSaidStart = Console.ReadLine();

var startTime = DateTime.Now;

Console.Clear();

Console.WriteLine("Press to end.");

var userSaidStop = Console.ReadLine();

var endTime = DateTime.Now;

var howLongDidHeWaitToPressTheButton = endTime - startTime;

Console.Clear();

Console.WriteLine(howLongDidHeWaitToPressTheButton);