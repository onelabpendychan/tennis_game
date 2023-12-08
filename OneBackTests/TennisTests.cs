using OneBackComboTrainingWeb;

namespace OneBackTests
{
    [TestFixture]
    public class TennisTests
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void SetUp()
        {
            _tennisGame = new TennisGame("Eva", "Eric");
        }


        [Test]
        public void score_is_love_all()
        {
            Assert.That(_tennisGame.Score(), Is.EqualTo("love all"));
        }

        [Test]
        public void score_is_fifteen_all()
        {
            AddFirstPlayerScore(1);
            AddSecondPlayerScore(1);
            Assert.That(_tennisGame.Score(), Is.EqualTo("fifteen all"));
        }

        [Test]
        public void score_is_thirty_all()
        {
            AddFirstPlayerScore(2);
            Assert.That(_tennisGame.Score(), Is.EqualTo("thirty all"));
        }


        public void AddFirstPlayerScore(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _tennisGame.AddFirstPlayerScore();
            }
        }
    }
}
