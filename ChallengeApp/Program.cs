using System;

int[] grades = new int[5];

string[] daysOfWeeks = new string[7];

daysOfWeeks[0] = "poniedzialek";
daysOfWeeks[1] = "wtorek";
daysOfWeeks[2] = "sroda";
daysOfWeeks[3] = "czwartek";
daysOfWeeks[4] = "piatek";
daysOfWeeks[5] = "sobota";
daysOfWeeks[6] = "niedziela";

Console.WriteLine(daysOfWeeks[4]);

string[] daysOfTheWeek = { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };

Console.WriteLine(daysOfTheWeek[3]);

for (int i=0; i <=1000;i++)
{
    Console.WriteLine(i);
}

//int size = daysOfTheWeek.Length;

for (var i = 0; i< daysOfTheWeek.Length; i++)
{
    Console.WriteLine(daysOfTheWeek[i]);
}

//List<string> daysOfWeek = new List<string>();

//var daysOfWeek() = ( "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" );

//for (var i = 0; i < daysOfWeek.Count; i++)
//{
/// Console.WriteLine(daysOfWeek[i]);
//}

List<string> daysOfWeek = new List<string>();

daysOfWeek[0] = "poniedzialek";
daysOfWeek[1] = "wtorek";
daysOfWeek[2] = "sroda";
daysOfWeek[3] = "czwartek";
daysOfWeek[4] = "piatek";
daysOfWeek[5] = "sobota";
daysOfWeek[6] = "niedziela";


foreach (var day in daysOfWeek)
{
    Console.WriteLine(day);
}