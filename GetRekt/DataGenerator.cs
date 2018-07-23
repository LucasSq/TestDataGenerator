using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGenerator
{
    public class DataGenerator
    {
        public List<TestData> GenerateStringData(int maxlength)
        {
            var testDataObjectsAsList = new List<TestData>();

            testDataObjectsAsList.Add(GenerateMaxStringLengthMinusOne(maxlength));
            testDataObjectsAsList.Add(GenerateMaxStringLengthExact(maxlength));
            testDataObjectsAsList.Add(GenerateMaxStringLengthPlusOne(maxlength));
            return testDataObjectsAsList;
        }
        
        public TestData GenerateMaxStringLengthMinusOne(int maxlength) {
            TestData testdata = new TestData();

            string maxStringLengthMinusOne = "";

            for (int i = 0; i < maxlength - 1; i++)
            {
                maxStringLengthMinusOne += "a";
            }

            testdata.input = maxStringLengthMinusOne;
            testdata.expectation = "okidoki";
                   
            return testdata;
        }

        public TestData GenerateMaxStringLengthExact(int maxlength)
        {
            TestData testdata = new TestData();

            string maxStringLengthExact = "";

            for (int i = 0; i < maxlength; i++)
            {
                maxStringLengthExact += "a";
            }

            testdata.input = maxStringLengthExact;
            testdata.expectation = "okidoki";

            return testdata;
        }

        public TestData GenerateMaxStringLengthPlusOne(int maxlength)
        {
            TestData testdata = new TestData();

            string maxStringLengthPlusOne = "";

            for (int i = 0; i < maxlength + 1; i++)
            {
                maxStringLengthPlusOne += "a";
            }

            testdata.input = maxStringLengthPlusOne;
            testdata.expectation = "field length too long";

            return testdata;
        }

    }
}
