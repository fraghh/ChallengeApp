
using ChallengeApp;
var user1 = new Employee("adam", "kowalski", 23);
var user2 = new Employee("tomek", "kowalski", 24);
var user3 = new Employee("krzys", "kowalski", 25);

user1.AddPoints(5);
user1.AddPoints(4);
user1.AddPoints(5);
user1.AddPoints(3);
user1.AddPoints(2);

user2.AddPoints(5);
user2.AddPoints(6);
user2.AddPoints(7);
user2.AddPoints(8);
user2.AddPoints(9);

user3.AddPoints(1);
user3.AddPoints(2);
user3.AddPoints(3);
user3.AddPoints(4);
user3.AddPoints(5);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach(var user in users)
{ 
    if(user.Wynik > maxResult)
    {
        maxResult= user.Wynik;
        userWithMaxResult=user;
    }
}
Console.WriteLine("Uzytkownik " + userWithMaxResult.Nazwisko +" "+ userWithMaxResult.Imie + " posiada najwieksza liczbe punktow, a jego wynik to: " + userWithMaxResult.Wynik+" punktow.");



