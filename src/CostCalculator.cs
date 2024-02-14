using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern.src
{
    class CostCalculator : IVisitor
    {
        public void Visit(IceCreamCone cone)
        {
            Console.WriteLine("Calculating cost for Ice Cream Cone: Rs.40");
        }

       
    }
}
