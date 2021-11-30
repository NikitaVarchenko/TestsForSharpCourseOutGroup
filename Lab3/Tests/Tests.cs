using System.Collections.Generic;
using Lab3.HomeWorks;
using NUnit.Framework;

namespace Lab3.Tests
{
    public class Tests
    {

        static object[] DivideCases =
        {
            new object[] {
                new (string,int)[] {
                    ("Dima Smirnov", 22),
                    ("Dacha Sidorov", 25),
                    ("Ivanov Ivan", 32)},
                new List<ClassTest>() {
                    new ClassTest("Dima Smirnov", 22),
                    new ClassTest("Dacha Sidorov", 25),
                    new ClassTest("Ivanov Ivan", 32)}
                        },
            new object[] {
                new (string,int)[] {
                    ("Dima Smirnov", 22),
                    ("Dacha Sidorov", 25),
                    ("Ivanov Ivan", 22)},
                new List<ClassTest>() {
                    new ClassTest("Dima Smirnov", 22),
                    new ClassTest("Ivanov Ivan", 22),
                    new ClassTest("Dacha Sidorov", 25)}
                        }
        };

        [TestCaseSource(nameof(DivideCases))]
        public void TestWithSort((string, int)[] dataForTest, List<ClassTest> verificationData)
        {
            List<ClassTest> tempList = new List<ClassTest>();
            foreach (var temp in dataForTest)
            {
                tempList.Add(new ClassTest(temp.Item1, temp.Item2));
            }
            tempList.Sort();
            Assert.AreEqual(verificationData, tempList, "Данные реализованы не верно");
        }
    }
}