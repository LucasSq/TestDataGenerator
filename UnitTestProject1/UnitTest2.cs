using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Testuni() { 

                UnitTest1 uni = new UnitTest1();
                List<Action> list = new List<Action>();
                list.Add(() => uni.TestIfNotFive(3));
                list.Add(() => uni.TestIfNotFive(6));
                list.Add(() => uni.TestIfNotFive(4));

                foreach (Action a in list)
                {
                    a.Invoke();
                }
            }
        }
    }

