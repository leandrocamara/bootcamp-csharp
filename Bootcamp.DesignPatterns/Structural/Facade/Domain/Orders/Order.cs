using System;
using System.Collections.Generic;
using System.Linq;
using Bootcamp.DesignPatterns.Structural.Facade.Domain.Products;

namespace Bootcamp.DesignPatterns.Structural.Facade.Domain.Orders
{
    public class Order
    {
        public Guid Id { get; }
        public decimal Value { get; }
        public List<Product> Products { get; }

        public Order(List<Product> products)
        {
            Id = Guid.NewGuid();
            Products = products ?? new List<Product>();
            Value = Products.Sum(p => p.Value);
        }
    }
}