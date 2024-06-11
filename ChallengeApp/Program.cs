using ChallengeApp;

Employee user1 = new Employee("tom", "bom", 14);
Employee user2 = new Employee("bob", "tob", 34);
Employee user3 = new Employee("mob", "fob", 54);




user1.AddScore(5);
user1.AddScore(3);
user1.AddScore(2);
user1.AddScore(1);
user1.AddScore(2);

user2.AddScore(6);
user2.AddScore(2);
user2.AddScore(5);
user2.AddScore(2);
user2.AddScore(1);

user3.AddScore(5);
user3.AddScore(1);
user3.AddScore(5);
user3.AddScore(3);
user3.AddScore(5);


var result1 = user1.Result;
var result2 = user2.Result;
var result3 = user3.Result;

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine(user1.Imie + " " + user1.Nazwisko + " ma najwieksza ilosc punktow. Jego wynik to: " + result1);

}

else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine(user2.Imie + " " + user2.Nazwisko + " ma najwieksza ilosc punktow. Jego wynik to: " + result2);
}


else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine(user3.Imie + " " + user3.Nazwisko + " ma najwieksza ilosc punktow. Jego wynik to: " + result3);

}

else
{
    Console.WriteLine("Wszycy maja taka sama ilosc punktow");
}







