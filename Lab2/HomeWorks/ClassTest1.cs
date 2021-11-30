using System;

namespace Lab2.HomeWorks
{
    public class ClassTest1: AClassTest,IClassTest
    {
        public override string Print()
        {
            return "It is ClassTest1";
        }

        public ClassTest1(int id, string name) : base(id, name) {
            Id = id;
            Name = name;
        }
        string IClassTest.PringFromInterface()
        {
            return "It is ClassTest1Interface";
        }
    }
}