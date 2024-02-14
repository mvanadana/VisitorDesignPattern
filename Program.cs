using System;
using VisitorDesignPattern.src;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ice Cream vendor
            var iceCreamVendor = new IceCreamVendor();

            // Visitors
            var visitor1 = new CostCalculator();
            var visitor2 = new SomeOtherVisitor(); 

            // Customer 1 orders an Ice Cream Cone
            iceCreamVendor.Accept(visitor1, new IceCreamCone());


            // You can use different visitors for different operations
            iceCreamVendor.Accept(visitor2, new IceCreamCone());
        }
    }
}





