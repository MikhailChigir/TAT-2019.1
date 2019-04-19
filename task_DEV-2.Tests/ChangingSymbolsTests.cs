using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_2;

namespace Tests_DEV2
{
    [TestClass]
    public class ChangingSymbolsTests
    {
        [TestMethod] public void ChangingLetterType_c_VoicelessHissingConsonant()
        {
            string expected = "voiceless consonant";

            ChangingSymbols c = new ChangingSymbols();
            string actual = c.ChangingLetterType('с');

            Assert.AreEqual(expected, actual);
        }
    }
}
