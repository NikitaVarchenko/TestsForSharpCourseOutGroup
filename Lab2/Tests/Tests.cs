using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Tests
{
    public class Tests
    {
        [TestCase(new string[] { "It is ClassTest1", "It is ClassTest2", "It is ClassTest3" }, 3)]
        public void Test1(string[] verificationData, int count)
        {
            HomeWorks.ClassTestBase[] objs = { new HomeWorks.ClassTest1(), new HomeWorks.ClassTest2(), new HomeWorks.ClassTest3() };
            string[] tempString = new string[objs.Length];
            for (int i = 0; i < objs.Length; i++)
            {
                tempString[i] = objs[i].Print();
            }
            Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }

        [TestCase(new string[] { "It is ClassTest1Interface", "It is ClassTest2Interface", "It is ClassTest3Interface" }, 3)]
        public void Test2(string[] verificationData, int count)
        {
            //?[] objs = { new ?(), new ?(), new ?() };
            HomeWorks.ClassTestBase[] objs = { new HomeWorks.ClassTest1(), new HomeWorks.ClassTest2(), new HomeWorks.ClassTest3() };
            string[] tempString = new string[objs.Length];
            for (int i = 0; i < objs.Length; i++)
            {
            tempString[i] = objs[i].PrintFromInterface();
            }
            Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }
    }
}
