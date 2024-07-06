

namespace ChallengeApp
{
    public class Employee2
    {

        private List<float> grades = new List<float>();
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee2(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {

            //int valueInInt = Math.Ceiling((int)grade);


            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }

            else
            {
                Console.WriteLine("string is not float");
            }


        }
        public void AddGrade(int grade)
         {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
         }
        public void AddGrade(long grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }


        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;



            }

        }


        public void ShowGrades()
            {
                Console.Write("Lista: ");
                foreach (var grade in this.grades)
                {
                    Console.Write($" {grade} ");
                }
                Console.WriteLine();

            }


        public Statistics GetStatistics()
            {

                var statistics = new Statistics();




                statistics.Average = 0;
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;

                foreach (var grade in this.grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;

                }


                statistics.Average /= this.grades.Count;

                switch(statistics.Average)
            {
                case var average when average >= 90:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'E';
                    break;
            }

                return statistics;
            }




        }





    } 

