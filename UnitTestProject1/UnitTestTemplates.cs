using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDataGenerator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestTemplates
    {
        public void TestMaxEdgeCases(int maxlength, string fieldname)
        {

            AppCode.DataValidator datavalidator1 = new AppCode.DataValidator();
            DataGenerator datagenerator1 = new DataGenerator();
            List<TestData> testData = datagenerator1.GenerateStringData(maxlength);

            AppCode.ValidationResult validationResult = new AppCode.ValidationResult();
            int count = 0;

            foreach (var item in testData)
            {
                validationResult = datavalidator1.ValidateStringField(testData[count].input, fieldname);

                if (testData[count].expectation == validationResult.Message) { 
                    Console.WriteLine("OK" + "\t|| if I fill " + fieldname + " (max length = " + maxlength + ") field with value " + testData[count] + " length = " + testData[count].input.Length + " results in messages: " + testData[count].expectation);
                    count += 1;
                }

                else {
                    Console.WriteLine("NOK" + "\t|| if I fill " + fieldname + " (max length = " + maxlength + ") field with value " + testData[count] + " length = " + testData[count].input.Length + " results in messages: " + testData[count].expectation);
                    count += 1;
                }
            }
        }

    }


}