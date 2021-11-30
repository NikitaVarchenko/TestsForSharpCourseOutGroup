namespace Lab2.HomeWorks
{

    public abstract class AClassTest
    {
        private int _id;
        private string _name;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;   
            }
        }
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

        public AClassTest(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public abstract string Print();

    }
}