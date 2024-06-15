

namespace ChallengeApp.test
{
    public class TypeTests
    {

        [Test]
        public void Test1()
        {
            //arrange
            var user1 = GetUser("adam", "pass");
            var user2 = GetUser("adam", "pass");


            //act



            //assert
            Assert.AreEqual(user1.Login, user2.Login);


        }

        [Test]
        public void Test2()
        {
            //arrange
            var number1 = 1;
            var number2 = 2;


            //act



            //assert
            Assert.AreEqual(number1, number2);


        }

        private User GetUser(string name, string pass)
        {
            return new User(name, pass);
        }
    }
}
