using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_2;

namespace Tests_DEV2
{
    [TestClass]
    public class PhonemeBuilderTests
    {
        [TestMethod]
        public void BuildPhonemeTest()
        {
            string expected = "жымолост'";

            PhonemeBuilder b = new PhonemeBuilder();
            string actual = b.BuildPhoneme("жи+молость").ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
