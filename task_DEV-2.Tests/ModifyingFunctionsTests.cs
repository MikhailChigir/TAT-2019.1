﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_2;

namespace Tests_DEV2
{
    [TestClass]
    public class ModifyingFunctionsTests
    {
        ModifyingFunctions m = new ModifyingFunctions();

        [TestMethod]
        public void YoatedTo2Letters_yo_YandO()
        {
            string expected = "йо";

            string actual = m.YoatedTo2Letters('ё');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void YoatedToApostrophe_yo_ApostropheAndY()
        {
            string expected = "'о";

            string actual = m.YoatedToApostrophe('ё');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VoicelessToVoiced_b_p()
        {
            string expected = "б";

            string actual = m.VoicelessToVoiced('п');

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VoicedToVoiceless_p_b()
        {
            string expected = "п";

            string actual = m.VoicedToViceless('б');

            Assert.AreEqual(expected, actual);
        }
    }
}