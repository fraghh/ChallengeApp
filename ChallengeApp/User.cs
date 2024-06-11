﻿
namespace ChallengeApp
{
    public class User
    {
        public static string GameName = "diablo";

        private List<int> score = new List<int>();



        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
            this.Name = "-";

        }

        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }



        public void AddScore(int number)
        {
            this.score.Add(number);
        }












    }
}
