﻿using ChallengeApp;

Employee2 user1 = new Employee2("tom", "bom");

user1.AddGrade(5);
user1.AddGrade(6);
user1.AddGrade(3);

//user1.AddGrade(3);

var statistics = user1.GetStatistics();













Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"maximum: {statistics.Max}");
Console.WriteLine($"minimum: {statistics.Min}");



