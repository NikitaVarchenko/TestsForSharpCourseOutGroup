using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.HomeWorks
{
    public class ClassTest3 : ClassTestBase
    {
        public ClassTest3()
        {

        }

        public override string Print()
        {
            return "It is ClassTest3";
        }

        public override string PrintFromInterface()
        {
            return "It is ClassTest3Interface";
        }
    }
}
