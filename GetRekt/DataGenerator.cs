using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRekt
{
    public class DataGenerator
    {
        public List<string> generateStringDataBasedOnLength(int maxlength)
        {
            var testDataAsList = new List<string>();

            testDataAsList.Add(generateMaxStringLengthMinusOne(maxlength));
            testDataAsList.Add(generateMaxStringLengthExact(maxlength));
            testDataAsList.Add(generateMaxStringLengthPlusOne(maxlength));
            return testDataAsList;
        }

        public List<TestData> GenerateStringDataAsObjectList(int maxlength)
        {
            var testDataObjectsAsList = new List<TestData>();

            testDataObjectsAsList.Add(GenerateMaxStringLengthMinusOneAsObject(maxlength));

            return testDataObjectsAsList;
        }

        public TestData GenerateMaxStringLengthMinusOneAsObject(int maxlength) {
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

        public String generateMaxStringLengthMinusOne(int maxlength)
        {
            string maxStringLengthMinusOne = "";

            for (int i = 0; i < maxlength - 1; i++)
            {
                maxStringLengthMinusOne += "a";
            }
            
            return maxStringLengthMinusOne;
        }

        public String generateMaxStringLengthExact(int maxlength)
        {
            string maxStringLengthExact = "";

            for (int i = 0; i < maxlength; i++)
            {
                maxStringLengthExact += "a";
            }

            return maxStringLengthExact;
        }

        public String generateMaxStringLengthPlusOne(int maxlength)
        {
            string maxStringLengthPlusOne = "";

            for (int i = 0; i < maxlength + 1; i++)
            {
                maxStringLengthPlusOne += "a";
            }

            return maxStringLengthPlusOne;
        }

    }
}
