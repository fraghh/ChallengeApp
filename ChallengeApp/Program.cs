using ChallengeApp;






Console.WriteLine("witamy w programie");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine();


var employee = new Employee2("michal", "kaminski");

while (true)
{
    Console.WriteLine("podaj kolejna ocene pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"average: {statistics.Average}");
Console.WriteLine($"minimum: {statistics.Min}");
Console.WriteLine($"maximum: {statistics.Max}");
Console.WriteLine($"Letter: {statistics.AverageLetter}");













