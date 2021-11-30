using System;

namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable<ClassTest>
    {
        private string name = "";

        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }

       

        public int CompareTo(ClassTest? c)
        {
            if (c != null)
            {
                if (this.Age > c.Age)
                    return 1;
                else if (this.Age < c.Age)
                    return -1;
                else
                    return 0;
            }else
            throw new Exception();
        }

        public override bool Equals(object? obj)
        {
            ClassTest? c = obj as ClassTest;
            if (obj != null) 
                return this.Name == c.Name && this.Age == c.Age;
            else 
                return false;
        }
    }
}