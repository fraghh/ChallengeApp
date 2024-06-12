

namespace ChallengeApp.test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //arrange
            var employee = new Employee("adam", "1", 34);
            employee.AddScore(5);
            employee.AddScore(6);


            //act

            var result = employee.Result;

            //assert

            Assert.AreEqual(11, result);

        }
        [Test]
        public void Test2()
        {
            //arrange
            var employee = new Employee("adam", "1", 34);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-6);


            //act

            var result = employee.Result;

            //assert

            Assert.AreEqual(5, result);

        }
        [Test]
        public void Test3()
        {
            //arrange
            var employee = new Employee("adam", "1", 34);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-6);
            employee.AddScore(-5);



            //act

            var result = employee.Result;

            //assert

            Assert.AreEqual(0, result);

        }


    }
}