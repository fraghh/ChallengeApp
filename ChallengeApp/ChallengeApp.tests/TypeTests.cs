
namespace ChallengeApp.tests
{
    public class TypeTests
    {
        [Test]
        public void referenceTypesTestGetUserShouldReturnDifferentObjects()
        {
            //arrange
            var user1 = GetUser("Adam", "torba",34);
            var user2 = GetUser("Adam", "klocek", 32);

            //act

            //assert
            Assert.AreNotEqual(user1, user2);
            
        }


        [Test]
        public void stringTypesTestShouldReturnSameValues()
        {
            //arrange
            var user1 = GetUser("Adam", "torba", 34);
            var user2 = GetUser("Adam", "klocek", 32);
            //act

            //assert
            Assert.AreEqual(user2.Imie, user1.Imie);
        }
        [Test]
        public void intTypesTestShouldReturnSameValues()
        {
            //arrange
            int num1 = 2;
            int num2 = 2;
            
            //act

            //assert
            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void floatTypesTestShouldReturnSameValues()
        {
            //arrange
            float numb1 = 2.3f;
            float numb2 = 2.3f;
            //act

            //assert
            Assert.AreEqual(numb1, numb2);
        }


        [Test]
        public void doubleTypesTestShouldReturnSameValues()
        {
            //arrange
            double numb1 = 2.3;
            double numb2 = 2.3;
            //act

            //assert
            Assert.AreEqual(numb1, numb2);

        }

            private Employee GetUser(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
