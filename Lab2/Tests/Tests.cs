using NUnit.Framework;

namespace Lab2.Tests
{
    public class Tests
    {
        [TestCase(new string[] { "It is ClassTest1", "It is ClassTest1", "It is ClassTest2" }, 3)]
        
        public void Test1(string[] verificationData, int count)
        {
            HomeWorks.AClassTest[] objs = { new HomeWorks.ClassTest1(), new HomeWorks.ClassTest1(), new HomeWorks.ClassTest2() };
            string[] tempString = new string[objs.Length];
            for (int i = 0; i < objs.Length; i++)
            {
                tempString[i] = objs[i].Print();
            }
            Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }

        [TestCase(new string[] { "It is ClassTest1Interface", "It is ClassTest1Interface", "It is ClassTest2Interface" }, 3)]
        
        public void Test2(string[] verificationData, int count)
        {
            LB2I[] objs = { new HomeWorks.ClassTest1(), new HomeWorks.ClassTest1(), new HomeWorks.ClassTest2() };
            string[] tempString = new string[objs.Length];
            for (int i = 0; i < objs.Length; i++)
            {
                tempString[i] = objs[i].PrintFromInterface();
            }
            Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }
    }
}