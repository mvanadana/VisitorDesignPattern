using System;
using System.Collections.Generic;

namespace VisitorDesignPattern.src
{
    class IceCreamVendor
    {
        private readonly List<IIceCream> iceCreams = new List<IIceCream>();

        public void AddIceCream(IIceCream iceCream)
        {
            iceCreams.Add(iceCream);
        }

        public void Accept(IVisitor visitor, IIceCream iceCream)
        {
            iceCream.Accept(visitor);
        }
    }

}