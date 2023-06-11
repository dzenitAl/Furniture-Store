using System;
namespace FurnitureStore.Services.Database
{
    public class Reservation
    {
        public long Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationStatus { get; set; }
        public string CustomerId { get; set; }
        public User Customer { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}

