using System;
namespace FurnitureStore.Services.Database
{
    public class Payment
    {
        public long Id { get; set; }
        public double Amount { get; set; }
        public string Notes { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CustomerId { get; set; }
        public User Customer { get; set; }
    }
}

