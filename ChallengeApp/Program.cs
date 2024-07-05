using ChallengeApp;

Employee2 user1 = new Employee2("tom", "bom");

user1.AddGrade("adam");
user1.AddGrade(6000);
user1.AddGrade(3);



//user1.AddGrade(3);

var statistics = user1.GetStatistics();
var statistics1 = user1.GetStatisticsWithWhile();
var statistics2 = user1.GetStatisticsWithFor();
var statistics3 = user1.GetStatisticsWithDoWhile();
var statistics4 = user1.GetStatisticsWithForEach();


user1.ShowGrades();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"maximum: {statistics.Max}");
Console.WriteLine($"minimum: {statistics.Min}");

Console.WriteLine($"==========while===========");

Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"maximum: {statistics1.Max}");
Console.WriteLine($"minimum: {statistics1.Min}");
Console.WriteLine($"==========for===========");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"maximum: {statistics2.Max}");
Console.WriteLine($"minimum: {statistics2.Min}");
Console.WriteLine($"==========Do While===========");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"maximum: {statistics3.Max}");
Console.WriteLine($"minimum: {statistics3.Min}");
Console.WriteLine($"==========for Each===========");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"maximum: {statistics4.Max}");
Console.WriteLine($"minimum: {statistics4.Min}");






