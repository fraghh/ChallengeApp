using ChallengeApp;

User user1 = new User("adam","1");
User user2 = new User("tom", "1");
User user3 = new User("rom", "1");


//user1.Login = "marek";
user1.AddScore(5);
user1.AddScore(5);
user1.AddScore(2);

var result = user1.Result;

Console.WriteLine(result);



    