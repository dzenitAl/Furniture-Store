using System;
namespace FurnitureStore.Services.Database
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}

