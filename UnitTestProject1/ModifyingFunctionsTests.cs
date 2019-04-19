using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ModifyingFunctionsTests
    {
        ModifyingFunctions m = new ModifyingFunctions();
        [TestMethod]
        public void YoatedTo2Letters_yo_YandO()
        {
            string expected = "йо";

            string actual = m.YoatedTo2letters("ё");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YoatedToApostrophe_yo_ApostropheAndY()
        {
            string expected = "'о";

            string actual = m.YoatedToApostrophe("ё");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VoicelessToVoiced_b_p()
        {
            string expected = "п";

            string actual = m.VoicelessToVoiced("б");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VoicedToVoiceless_p_b()
        {
            string expected = "б";

            string actual = m.VoicedToVoiceless("п");

            Assert.AreEqual(expected, actual);
        }
    }
}
