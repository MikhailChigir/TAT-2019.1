using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ChangableSymbolsTests
    {
        [TestMethod]
        public void ChangableLetterType_c_VoicelessConsonant()
        {
            string expected = "voiceless consonant";

            ChangableSymbols c = new ChangableSymbols();
            string actual = c.ChangableLetterType("с");

            Assert.AreEqual(expected, actual);

        }
    }
}
