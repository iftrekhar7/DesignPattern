﻿using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract new string GetDiscription();

    }
}
