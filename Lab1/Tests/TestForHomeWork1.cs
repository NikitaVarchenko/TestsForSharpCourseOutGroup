using NUnit.Framework;

namespace Lab1.Tests
{
    public class TestForHomeWork1
    {
        [TestCase(new int[] { 1, -10, 3, 4, -8, 20, 7, 43, -15, -9 }, new int[] { -15, -10, 3, 4, -8, 20, 7, 43, 1, -9 })]
        [TestCase(new int[] { 1, 10, 3, 4, 8, 20, 7, 43, 15, 9 }, new int[] { 1, 10, 3, 4, 8, 20, 7, 43, 15, 9 })]
        [TestCase(new int[] { -1, -10, -3, -4, -8, -20, -7, -43, -15, -9 }, new int[] { -1, -10, -3, -4, -8, -20, -7, -43, -15, -9 })]
        //[Ignore("Убрать после реализации метода")]
        public void TestForVariant1(int[] temp, int[] temp2) => Assert.AreEqual(HomeWorks.HomeWork1.Variant1(temp), temp2,
        "Метод возвращает не верное значение");

        [TestCase(new int[] { 1, -10, 3, 4, -8, 20, 7, 43, -15, -9 }, -12)]

        public void TestForVariant2(int[] temp, int temp2) => Assert.AreEqual(HomeWorks.HomeWork1.Variant2(temp), temp2,
        "Метод возвращает не верное значение");

        [TestCase(new int[] { 1, -10, 3, 4, -8, 20, 7, 43, -15, -9 }, new int[] { 1, 0, 3, 4, 0, 20, 7, 43, 0, 0 })]

        public void TestForVariant3(int[] temp, int[] temp2) => Assert.AreEqual(HomeWorks.HomeWork1.Variant3(temp), temp2,
        "Метод возвращает не верное значение");

        [TestCase(new int[] { 0, -10, 3, 4, -8, 20, 7, 43, -15, -9 }, new int[] { 0, -10, 3, 12, -8, 20, 7, 129, -15, -9 })]

        public void TestForVariant4(int[] temp, int[] temp2) => Assert.AreEqual(HomeWorks.HomeWork1.Variant4(temp), temp2,
        "Метод возвращает не верное значение");

        [TestCase(new int[] { 1, -10, 3, 4, -8, 20, 7, 43, -15, -9 }, 18.6)]
        [TestCase(new int[] { 1, 10, 3, 4, 8, 20, 7, 43, 15, 9 }, 11)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { -1, -10, -3, -4, -8, -20, -7, -43, -15, -9 }, 31)]
        public void TestForVariant5(int[] temp, double temp2) => Assert.AreEqual(HomeWorks.HomeWork1.Variant5(temp), temp2,
        "Метод возвращает не верное значение");
    }
}