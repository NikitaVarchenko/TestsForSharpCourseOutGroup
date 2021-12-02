using System;
using NUnit.Framework;

namespace Lab4.Tests

{

public class Tests
{
    [TestCase(10)]
    [TestCase(4)]
    [TestCase(99)]
    [Ignore("Убрать после реализации метода")]
    public void TestWithException(int temp) => Assert.Throws<Exception>(delegate { HomeWorks.ClassTest.MetrodWithException(temp); },
        "Метод не возвращает исключение на указных параметрах");

    [TestCase(11)]
    [TestCase(2)]
    [TestCase(89)]
    [Ignore("Убрать после реализации метода")]
    public void TestWithOutException(int temp) => Assert.DoesNotThrow(delegate { HomeWorks.ClassTest.MetrodWithException(temp); },
    "Метод возвращает исключение на указных параметрах");
}
}