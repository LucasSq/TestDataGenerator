using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGenerator
{
    public class ExpectationGenerator
    {
        public List<string> generateExpactationsAsList()
        {
            var testExpectation = new List<string>();
            testExpectation.Add("okidoki");
            testExpectation.Add("okidoki");
            testExpectation.Add("field length too long");
            return testExpectation;
        }
    }
}
