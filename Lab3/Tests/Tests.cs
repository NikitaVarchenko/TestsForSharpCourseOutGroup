using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.HomeWorks;
using NUnit.Framework;

namespace Lab3.Tests
{
	public class Tests
	{

		static object[] DivideCases =
		{
			new object[] 
			{
				new (string,int)[] 
				{
					("Dima Smirnov", 22),
					("Dacha Sidorov", 25),
					("Ivanov Ivan", 32)
				},
				new List<ClassTest>() 
				{
					new ClassTest("Dima Smirnov", 22),
					new ClassTest("Dacha Sidorov", 25),
					new ClassTest("Ivanov Ivan", 32)
				}
			},
			new object[] 
			{
				new (string,int)[] 
				{
					("Dima Smirnov", 22),
					("Dacha Sidorov", 25),
					("Ivanov Ivan", 22)
				},
				new List<ClassTest>() 
				{
					new ClassTest("Dima Smirnov", 22),
					new ClassTest("Ivanov Ivan", 22),
					new ClassTest("Dacha Sidorov", 25)
				}		
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

			//CollectionAssert.AreEqual(verificationData, tempList);
			/*
			Assert.AreEqual(verificationData.Count, tempList.Count);

			for (var i = 0; i < verificationData.Count; i++)
			{
				Assert.AreEqual(verificationData[i], tempList[i]);
			}
			*/
		}
	}
}
