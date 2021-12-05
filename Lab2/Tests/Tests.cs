using NUnit.Framework;
using Lab2.HomeWorks;

namespace Lab2.Tests
{
    public class Tests
    {
        [TestCase("It is ClassTest1", "It is ClassTest1", "It is ClassTest2")]
        public void Test1(params string[] verificationData)
        {
            AClassTest[] objs = { new ClassTest1(), new ClassTest1(), new ClassTest2() };
            string[] tempString = new string[objs.Length];
            for (int i = 0; i < objs.Length; i++)
            {
                tempString[i] = objs[i].Print();
            }
            Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }

        [TestCase("It is ClassTest1Interface", "It is ClassTest1Interface", "It is ClassTest2Interface")]
        public void Test2(params string[] verificationData)
        {
            Iinterf[] objs = { new ClassTest1(), new ClassTest1(), new ClassTest2() };
            string[] tempString = new string[objs.Length];
            for (int i = 0; i < objs.Length; i++)
            {
                tempString[i] = objs[i].PrintFromInterface();
            }
            Assert.AreEqual(tempString, verificationData, "Данные реализованы не верно");
        }
    }
}