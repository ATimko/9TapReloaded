using _9TapReloaded;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NineTapTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        [DataRow((short)0)]
        [DataRow((short)300)]
        [DataRow((short)135)]
        public void Game1_SetValidScore_UpdatesScore(short score)
        {
            Game g = new Game();
            g.Game1 = score;

            Assert.AreEqual(score, g.Game1);
        }
        [TestMethod]
        public void Game1_InvalidScore_ThrowsArgumentException()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void UpdateGameScoreProperties_UpdatesTotalScore()
        {
            Game g = new Game();
            g.Game1 = 200;
            g.Game2 = 200;
            g.Game3 = 150;
            g.Game4 = 150;

            short expectedTotalScore = 700;
            Assert.AreEqual(expectedTotalScore, g.TotalScore);

            g.Game3 = 100;

            short newExpectedTotalScore = 650;
            Assert.AreEqual(newExpectedTotalScore, g.TotalScore);
        }
    }
}
