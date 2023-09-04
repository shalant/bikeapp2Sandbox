using BikeApp.Models;

namespace BikeApp.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string? Name { get; set; }
        public DateTime EventDate { get; set; }
        public string? Route { get; set; }

    }
}
