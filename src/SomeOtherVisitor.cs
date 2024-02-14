using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern.src
{
    class SomeOtherVisitor : IVisitor
    {
        public void Visit(IceCreamCone cone)
        {
            Console.WriteLine("Chocolate for Ice Cream ");
        }

      
    }
}
