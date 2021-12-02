namespace Lab2.HomeWorks
{
    public class ClassTest2: AClassTest, LB2I
    {
        public override string Print()
        {
            return "It is ClassTest2";
        }

        public string PrintFromInterface()
        {
            return "It is ClassTest2Interface";
        }
}
}