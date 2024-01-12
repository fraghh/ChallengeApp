
Console.WriteLine("podaj liczbe: ");
string number = Console.ReadLine();

char[] letters = number.ToArray();
int liczba = 0;


for(int i = 0; i<10;i++)
    {
    int licznik = 0;
    foreach (char charr in  letters)
        {
            liczba = int.Parse(charr.ToString());
            if (i == liczba)
            {
            licznik=licznik+1;
            }
        
        }
    Console.WriteLine(i + " => " + licznik);
}




