using System;

namespace Lab2.HomeWorks
{
    public class ClassTest2 : AClassTest,IClassTest
    {
        public override string Print()
        {
            return "It is ClassTest2";
        }

        public ClassTest2(int id, string name) : base(id, name)
        {
            Id = id;
            Name = name;
        }
        string IClassTest.PringFromInterface()
        {
            return "It is ClassTest2Interface";
        }
    }
}