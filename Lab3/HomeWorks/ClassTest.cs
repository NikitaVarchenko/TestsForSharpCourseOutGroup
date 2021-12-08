using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable
    {
        private string _name;

        private int _age;

        /// <summary>
        /// Имя
        /// </summary>
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        
        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            ClassTest classTest = obj as ClassTest;

            if (classTest != null)
            {
                return this.Age.CompareTo(classTest.Age);
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }

        public override bool Equals(object other)
        {
            return Equals(other as ClassTest);
        }

        public bool Equals(ClassTest other)
        {
            return other != null &&
                   this.Age == other.Age &&
                   this.Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Age, Name).GetHashCode();
        }
    }
}
