using Newtonsoft.Json;
using System;

namespace RestaurantReservations.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int NumberOfPersons { get; set; }
        [JsonIgnore]
        public Table Table { get; set; }
        public int TableId { get; set; }
        public DateTime BookingTime { get; set; }
        public DateTime DurationOfBooking { get; set; }
    }
}

