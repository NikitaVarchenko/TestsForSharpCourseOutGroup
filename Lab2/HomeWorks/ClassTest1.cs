namespace Lab2.HomeWorks
{
    public class ClassTest1 : AClassTest, LB2I
    {
        public override string Print()
        {
            return "It is ClassTest1";
        }

        public string PrintFromInterface()
        {
            return "It is ClassTest1Interface";
        }
    }
}