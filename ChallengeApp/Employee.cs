namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }

        public int Result { get
            {
                return this.score.Sum();
            } 
        }

        public Employee(string imie, string nazwisko, int wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
            
        }


        public void AddScore(int score)
        {
            this.score.Add(score);
        }

        
    }
}
