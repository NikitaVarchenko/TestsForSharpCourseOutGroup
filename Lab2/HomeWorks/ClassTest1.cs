namespace Lab2.HomeWorks
{
    public class ClassTest1 : AClassTest, In
    {
        private int Num;
        public string? Name { get; set; }

        public ClassTest1() : base()
        {
            Num = 1;
        }

        public override string Print()
        {
            return "It is ClassTest1";
        }

        public string PringFromInterface()
        {
            return "It is ClassTest1Interface";
        }
    }
}