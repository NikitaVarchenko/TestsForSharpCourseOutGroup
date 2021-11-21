using NUnit.Framework;

namespace Lab1.Tests
{
    public class TestForHomeWork2
    {
        [TestCase(new string[] { "maxString", "world", "hi", "five", "two" }, "maxString", 9, "hi", 2)]
        [TestCase(new string[] { "mi", "rr", "ll", "ww", "kk" }, "kk", 2, "kk", 2)]
        [TestCase(new string[] { "dd", "nw", "kw", "a", "" }, "kw", 2, "", 0)]
        public void TestForVariant1(string[] temp, string max, int lengthMax, string min, int lengthMin) => Assert.AreEqual(HomeWorks.HomeWork2.Variant1(temp), (max, lengthMax, min, lengthMin),
        "Метод возвращает не верное значение");

        [TestCase(new string[] { "maxString", "111", "hi", "five", "two" }, "111")]
        [TestCase(new string[] { "maxString", "temp", "hi", "five", "two" }, null)]
        [TestCase(new string[] { "maxString", "111", "hi", "444", "two" }, "444")]
        public void TestForVariant2(string[] temp, string result) => Assert.AreEqual(HomeWorks.HomeWork2.Variant2(temp), result, "Метод возвращает не верное значение");
    }
}