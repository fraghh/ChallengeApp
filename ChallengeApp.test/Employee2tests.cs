
namespace ChallengeApp.test
{
    public class Employee2tests
    {
        [Test]
        public void WhenGetStatisticsCalled_shouldReturnCorrectMax()
        {
            //arrange
            var employee = new Employee2("michal", "kam");
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
            var employee = new Employee2("michal", "kam");
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
            var employee = new Employee2("michal", "kam");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(3);


            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(Math.Round(4.67, 2), Math.Round(statistics.Average, 2));

        }
    }
}
