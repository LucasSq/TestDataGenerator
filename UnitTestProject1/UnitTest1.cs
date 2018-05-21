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
        public void TestCheckFieldNaamWithTestDataAsObjectList()
        {
            unitTestTemplates.TestMaxLengthWithTestDataObject(11, "naam");
        }

    }


 }