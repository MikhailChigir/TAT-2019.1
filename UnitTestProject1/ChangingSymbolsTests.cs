using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ChangingSymbolsTests
    {
        [TestMethod] public void ChangingLetterType_c_VoicelessHissingConsonant()
        {
            string expected = "voiceles hissing consonant";

            ChangingSymbols c = new ChangingSymbols;
            string actual = c.ChangingLetterType("с");

            Assert.AreEqual(expected, actual);
        }
    }
}
