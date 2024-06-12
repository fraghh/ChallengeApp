using ChallengeApp;

User user1 = new User("tom", "bom");
User user2 = new User("bob", "tob");
User user3 = new User("mob", "fob");




user1.AddScore(5);
user1.AddScore(3);



user2.AddScore(6);
user2.AddScore(2);


user3.AddScore(5);
user3.AddScore(1);



var result1 = user1.Result;
var result2 = user2.Result;
var result3 = user3.Result;

