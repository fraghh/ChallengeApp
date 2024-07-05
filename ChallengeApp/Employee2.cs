


using System.Diagnostics;

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

            int valueInInt = Math.Ceiling((int)grade);


            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid data");
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

            //foreach (var grade in this.grades)
            //{
              //  statistics.Max = Math.Max(statistics.Max, grade);
                //statistics.Min = Math.Min(statistics.Min, grade);
                //statistics.Average += grade;

            //}
            var index = 0;
            do
            {
              

                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;

            } while(index< this.grades.Count);

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }





}
