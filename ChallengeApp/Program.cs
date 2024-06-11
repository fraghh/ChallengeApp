var digit = new int[10];

Console.Write("podaj liczbe: ");
string number = Console.ReadLine();

foreach (char a in number)
{
    int cyfra = (int)char.GetNumericValue(a);

    for (int i = 0; i < digit.Length; i++)
    {
        if (i == cyfra)
        {
            digit[i]++;
        }
    }
}
Console.WriteLine("Liczba to " + number);
for (int i = 0; i < (digit.Length); i++)
{

    Console.WriteLine("Cyfra " + i + " wystapila " + digit[i] + " razy.");
}