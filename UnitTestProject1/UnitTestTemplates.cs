using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetRekt;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestTemplates
    {
        public void TestMaxLengthWithTestDataObject(int maxlength, string fieldname)
        {

            DataValidator datavalidator1 = new DataValidator();
            DataGenerator datagenerator1 = new DataGenerator();
            List<TestData> testData = datagenerator1.GenerateStringDataAsObjectList(maxlength);
            ValidationResult validationResult = new ValidationResult();
            int count = 0;

            foreach (var item in testData)
            {
               validationResult = datavalidator1.ValidateStringField(testData[count].input);

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