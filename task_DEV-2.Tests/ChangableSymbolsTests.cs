using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_2;

namespace Tests_DEV2
{
    [TestClass]
    public class ChangableSymbolsTests
    {
        [TestMethod]
        public void ChangableLetterType_c_VoicelessConsonant()
        {
            string expected = "voiceless consonant";

            ChangableSymbols c = new ChangableSymbols();
            string actual = c.ChangableLetterType('с');

            Assert.AreEqual(expected, actual);
        }
    }
}
