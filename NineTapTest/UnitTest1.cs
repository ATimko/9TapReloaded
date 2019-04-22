using _9TapReloaded;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NineTapTest
{
    [TestClass]
    public class UnitTest1
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
    }
}
