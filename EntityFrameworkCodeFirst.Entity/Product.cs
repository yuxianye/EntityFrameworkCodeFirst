using System;

namespace EntityFrameworkCodeFirst.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductNum { get; set; }
        public Order Order { get; set; }
    }
}
