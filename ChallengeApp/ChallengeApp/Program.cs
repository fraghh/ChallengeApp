var name = "ewa";
var sex = "M";
var age = 17;

if (sex == "F" && age < 30)
{
    Console.WriteLine("kobieta lat 30");
}
else if (name == "ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30.");
}
else if(sex=="M" &&  age < 18)
{
    Console.WriteLine("niepelnoletni mezczyzna");
}
else 
{
    Console.WriteLine("nic");
}