
namespace ChallengeApp.test
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_shouldReturnCorrectMax()
        {
            //arrange
            var employee = new Employee("michal", "kam", 'M');
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(3);


            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(6, statistics.Max);

        }

        [Test]
        public void WhenGetStatisticsCalled_shouldReturnCorrectMin()
        {
            //arrange
            var employee = new Employee("michal", "kam", 'M');
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(3);


            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(3, statistics.Min);

        }

        [Test]
        public void WhenGetStatisticsCalled_shouldReturnCorrectAverage()
        {
            //arrange
            var employee = new Employee("michal", "kam",'M');
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(3);


            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(Math.Round(4.67, 2), Math.Round(statistics.Average, 2));

        }
        [Test]
        public void WhenAddGradeWithStringAdded_shouldRecordCorrectValueInFloat()
        {
            //arrange
            var employee = new Employee("michal", "kam",'M');
            employee.AddGrade("5");
            employee.AddGrade("5");

            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(5, statistics.Average);

        }
        [Test]
        public void whenGradeAsLetterIsAdded_shouldRecordCorrectAverage()
        {
            //arrange
            var employee = new Employee("michal", "kam", 'M');
            employee.AddGrade('A');
            employee.AddGrade('b');

            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(90, statistics.Average);

        }

        [Test]
        public void whenAverageEquals90_shouldRecordCorrectAverageLetter()
        {
            //arrange
            var employee = new Employee("michal", "kam", 'M');
            employee.AddGrade(100);
            employee.AddGrade(90);
            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual('A', statistics.AverageLetter);

        }

        [Test]
        public void whenAverageEqualsBelow80_shouldRecordCorrectAverageLetter()
        {
            //arrange
            var employee = new Employee("michal", "kam", 'M');
            employee.AddGrade(79);
            employee.AddGrade(80);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }
        [Test]
        public void whenAverageEqualsBelow70_shouldRecordCorrectAverageLetter()
        {
            //arrange
            var employee = new Employee("michal", "kam", 'M');
            employee.AddGrade(59);
            employee.AddGrade(60);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}
