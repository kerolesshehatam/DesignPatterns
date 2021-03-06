﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.PremiumPreorder
{
    public class OrderDecorator : OrderBase
    {
        protected OrderBase order;

        public OrderDecorator(OrderBase order)
        {
            this.order = order;
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in a decorator class");
            return order.CalculateTotalOrderPrice();
        }
    }
}
