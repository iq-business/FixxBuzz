﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LinqLoopTest()
        {
            var expected = 2;
            var duration = LinqLoop.Loop(10000);

            Assert.IsTrue(expected>duration);
        }
    }
}
