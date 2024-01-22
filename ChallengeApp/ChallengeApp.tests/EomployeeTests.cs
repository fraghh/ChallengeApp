namespace ChallengeApp.tests
{
    public class Tests
    {
       

        [Test]
        public void Test1()
        {
            //arrange
            var user1 = new Employee("adam", "torba", 26);
            var user2 = new Employee("tomasz", "flak", 37);
            var user3 = new Employee("Krzysztof", "gumiarz", 45);

            user1.AddPoints(5);
            user1.RemovePoints(3);
            user1.AddPoints(5);
            user1.AddPoints(7);
            user1.RemovePoints(6);

            user2.AddPoints(10);
            user2.RemovePoints(4);
            user2.AddPoints(5);
            user2.AddPoints(6);
            user2.RemovePoints(7);

            user3.AddPoints(6);
            user3.RemovePoints(3);
            user3.AddPoints(5);
            user3.AddPoints(7);
            user3.RemovePoints(6);

            //act
            var result1 = user1.Wynik;
            var result2 = user2.Wynik;
            var result3 = user3.Wynik;

            //assert
            Assert.AreEqual(8, result1);
            Assert.AreEqual(10, result2);
            Assert.AreEqual(9, result3);


        }


        







    }



}