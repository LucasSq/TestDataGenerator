using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDataGenerator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        UnitTestTemplates unitTestTemplates = new UnitTestTemplates();

        [TestMethod]
        public void TestCheckEdgeCasesFieldNaam()
        {
            unitTestTemplates.TestMaxEdgeCases(10, "Naam");
        }

        [TestMethod]
        public void TestCheckEdgeCasesFieldTelefoonnummer()
        {
            unitTestTemplates.TestMaxEdgeCases(20, "Telefoonnummer");
        }

    }


 }