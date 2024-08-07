﻿

namespace ChallengeApp
{
    public abstract class Person : System.Object
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
    }
}
