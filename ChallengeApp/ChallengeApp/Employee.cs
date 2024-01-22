


namespace ChallengeApp;

public class Employee
{
  
    
    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    public int Wiek { get; private set; }
    public int Wynik { get; private set; }

    public Employee(string imie, string nazwisko, int wiek)
    {
        this.Imie = imie;
        this.Nazwisko = nazwisko;
        this.Wiek = wiek;
        
    }


    //

    public void AddPoints(int punkty) 
    {
        this.Wynik += punkty;
    }
    
    public void RemovePoints(int punkty) 
    {  
        this.Wynik -= punkty;
    }
}

