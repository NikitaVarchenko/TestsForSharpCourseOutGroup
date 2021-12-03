using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.HomeWorks
{
    public abstract class ClassTestBase: InterfaceClass
    {
        public virtual string Print()
        {
            return "It is ClassTest1";
        }

        public abstract string PrintFromInterface();
    }
}
