﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern.src
{
    class IceCreamCone : IIceCream
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
