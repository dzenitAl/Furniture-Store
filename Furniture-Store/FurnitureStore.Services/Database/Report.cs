using System;
namespace FurnitureStore.Services.Database
{
    public class Report
    {
        public long Id { get; set; }
        public DateTime GenerationDate { get; set; }
        public string Content { get; set; }
        public string AdminId { get; set; }
        public User Admin { get; set; }
    }
}

