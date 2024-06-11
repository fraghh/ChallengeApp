using ChallengeApp;

Employee user1 = new Employee("tom", "bom", 14);
Employee user2 = new Employee("bob", "tob", 34);
Employee user3 = new Employee("mob", "fob", 54);




user1.AddScore(5);
user1.AddScore(3);
user1.AddScore(2);
user1.AddScore(1);
user1.AddScore(2);

user2.AddScore(5);
user2.AddScore(2);
user2.AddScore(5);
user2.AddScore(2); 
user2.AddScore(1);

user3.AddScore(5);
user3.AddScore(1);
user3.AddScore(5);
user3.AddScore(3);
user3.AddScore(5);


var result = user1.Result;

Console.WriteLine(result);



    