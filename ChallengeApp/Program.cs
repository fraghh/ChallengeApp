using ChallengeApp;

Console.WriteLine("witamy w programie");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine();

var employee = new Employee("michal", "kaminski", 'M');

while (true)
{
    Console.WriteLine("podaj kolejna ocene pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exeption catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine($"average: {statistics.Average}");
Console.WriteLine($"minimum: {statistics.Min}");
Console.WriteLine($"maximum: {statistics.Max}");
Console.WriteLine($"Letter: {statistics.AverageLetter}");













