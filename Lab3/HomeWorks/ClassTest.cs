using System;

namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable
    {
        private string name = "";

        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }

        public int CompareTo(object? obj)
        {
            ClassTest classTest = obj as ClassTest;
            if (classTest == null)
                throw new Exception("Невозможно сравнить объекты");
            if (this.Age > classTest.Age)
                return 1;
            if (this.Age < classTest.Age)
                return -1;
            return 0;
        }
    }
}