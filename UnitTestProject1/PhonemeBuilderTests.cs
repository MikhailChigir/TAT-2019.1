using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PhonemeBuilderTests
    {
        [TestMethod]
        public void BuildPhonemeTest()
        {
            string expected = "жымолост'";

            PhonemeBuilder b = new PhonemeBuilder();
            string actual = b.BuildPhoneme("жи+молость");

            Assert.AreEqual(expected, actual);
        }
    }
}
