

namespace ChallengeApp.test
{
    public class Tests
    {
        [Test]
        public void Setup()
        {
            //arrange
            var user = new User("adam", "1");
            user.AddScore(5);
            user.AddScore(6);


            //act

            var result = user.Result;

            //assert

            Assert.AreEqual(11, result);

        }

        
    }
}