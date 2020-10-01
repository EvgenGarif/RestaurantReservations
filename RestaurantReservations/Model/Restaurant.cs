using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestaurantReservations.Model
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string NameRestaurant { get; set; }
        public string WorkingHours { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public int NumberOfTables { get; set; }
        public ICollection<Table> Tables { get; set; }

    }
}
