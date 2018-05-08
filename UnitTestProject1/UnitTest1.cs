using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetRekt;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public void TestMaxLength(int maxlength, string fieldname)
        {

            DataValidator datavalidator1 = new DataValidator();
            DataGenerator datagenerator1 = new DataGenerator();
            ExpectationGenerator expectationgenerator1 = new ExpectationGenerator();
            List<string> testData = datagenerator1.generateStringDataBasedOnLength(maxlength);
            List<string> testExpectation = expectationgenerator1.generateExpactationsAsList();
            int count = 0;

            foreach (var item in testData)
            {
                datavalidator1.validateStringField(testData[count]);
                Assert.AreEqual(testExpectation[count], datavalidator1.message);
                Console.WriteLine("if I fill " + fieldname + " (max length = " + maxlength + ") field with value " + testData[count] + " length = " + testData[count].Length + " results in messages: " + testExpectation[count]);
                count += 1;
            }
        }

        [TestMethod]
        public void TestCheckFieldNaam()
        {
            TestMaxLength(10, "naam");
        }

        
        public void TestIfNotFive(int number)
        {
            Assert.AreNotEqual(5, number);
        }

    }


 }