using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetRekt;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        UnitTestTemplates unitTestTemplates = new UnitTestTemplates();

        [TestMethod]
        public void TestCheckFieldNaam()
        {
           unitTestTemplates.TestMaxLength(10, "naam");
        }

        
        public void TestIfNotFive(int number)
        {
            Assert.AreNotEqual(5, number);
        }

        [TestMethod]
        public void TestCheckFieldNaamWithTestDataAsObjectList()
        {
            unitTestTemplates.TestMaxLengthWithTestDataObject(10, "naam");
        }

    }


 }