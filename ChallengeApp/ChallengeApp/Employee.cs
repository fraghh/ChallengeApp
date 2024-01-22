


namespace ChallengeApp;

public class Employee
{
    //public int wynik;
    //public int maxResult;
    
    public string Imie { get; private set; }
    public string Nazwisko { get; private set; }
    public int Wiek { get; private set; }
    public int Wynik { get; private set; }

    public Employee(string imie, string nazwisko, int wiek)
    {
        this.Imie = imie;
        this.Nazwisko = nazwisko;
        this.Wiek = wiek;
        int Wynik = 0;
    }




    public void AddPoints(int punkty) 
    {
        this.Wynik += punkty;
    }
    //public int Wynik()
    //{
      //  return this.wynik;
   // }
    
    public void wyswietlanie() 
    {

    }


}

