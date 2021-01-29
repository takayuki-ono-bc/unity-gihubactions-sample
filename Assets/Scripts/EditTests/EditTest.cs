using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EditTest
    {
        [Test]
        [TestCase(1,false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        public void EditTestSimplePasses(int count, bool result)
        {
            Util testObject = new Util();
            Assert.AreEqual(testObject.IsOver(count), result);
        }
    }
}
