using System.Globalization;

bool keepLooping = true;

while (keepLooping)
{
    Console.WriteLine("Press to start.");

    var userSaidStart = Console.ReadLine();

    var startTime = DateTime.Now;

    Console.Clear();

    Console.WriteLine("Press to end.");

    var userSaidStop = Console.ReadLine();

    var endTime = DateTime.Now;

    var howLongDidHeWaitToPressTheButton = endTime - startTime;

    Console.Clear();

    Console.WriteLine($"Time Elapsed {howLongDidHeWaitToPressTheButton}. Press return to begin again.");

    Console.ReadLine();

    Console.Clear();
}